using System;
using Sulakore;
using System.Linq;
using Sulakore.Habbo;
using System.Drawing;
using Kendax.Properties;
using Sulakore.Protocol;
using System.Windows.Forms;
using System.Threading.Tasks;
using Sulakore.Communication;
using Sulakore.Protocol.Encryption;

namespace Kendax
{
    public partial class Main : Form
    {
        public Action<bool> UpdateAccountUICB;
        public Action<string, bool> DisplayFinishCB;
        public Action<bool> UpdateConnectionFeatsCB;

        public Main()
        {
            InitializeComponent();
            DisplayFinishCB = DisplayFinish;
            UpdateAccountUICB = UpdateAccountUI;
            UpdateConnectionFeatsCB = UpdateConnectionFeats;
            LocationRandomizer = new Random();
        }
        private void UpdateAccountUI(bool ToEnable)
        {
            if (InvokeRequired) { Invoke(UpdateAccountUICB, ToEnable); return; }
            ConnectBtn.Enabled = ToEnable;
        }
        private void UpdateConnectionFeats(bool ToEnable)
        {
            if (InvokeRequired) { Invoke(UpdateConnectionFeatsCB, ToEnable); return; }
            AllAccountsChckbx.Enabled = ToEnable;
            AccountTxt.Enabled = ToEnable;
            LoginBtn.Enabled = ToEnable;
        }
        private void DisplayFinish(string Status, bool UpdateProfileUI = true)
        {
            if (InvokeRequired) { Invoke(DisplayFinishCB, Status, UpdateProfileUI); return; }

            AnimationTmr.Stop();
            StatusTxt.Text = Status;
            LoggingIn = ConnectingBot = false;
            if (UpdateProfileUI)
                AccountTxt_SelectedIndexChanged(Status, EventArgs.Empty);
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;
            int LoadedAccs = 0;
            HSession[] HSs = HSession.Extract(((string[])(e.Data.GetData(DataFormats.FileDrop)))[0]);
            foreach (HSession HS in HSs)
            {
                if (HS != null && !Program.Emails.ContainsKey(HS.Email))
                {
                    Program.Emails[HS.Email] = HS;
                    AccountTxt.Items.Add(HS.Email);
                    if (AccountTxt.Items.Count == 1) AccountTxt.SelectedIndex = 0;
                    if (!AccountTxt.Enabled) AccountTxt.Enabled = true;
                    if (!LoginBtn.Enabled) LoginBtn.Enabled = true;
                    if (AccountTxt.Items.Count > 1) AllAccountsChckbx.Enabled = true;
                    LoadedAccs++;
                }
            }
            AccountsGrpbx.Text = string.Format("Account(s) - Total: {0} | Connected:", AccountTxt.Items.Count);
            ConnectedLbl.Location = new Point(TextRenderer.MeasureText(AccountsGrpbx.Text, AccountsGrpbx.Font).Width + 1, 0);
            StatusTxt.Text = string.Format("Accounts Loaded! - ({0}/{1})", LoadedAccs, HSs.Length);
        }
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".txt"))
                e.Effect = DragDropEffects.Copy;
        }

        private bool LoggingIn = false;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoggingIn = true;
            UpdateAccountUI(false);
            UpdateConnectionFeats(false);

            if (AllAccountsChckbx.Checked)
            {
                #region Account Login: Multiple
                int LoginCount = 0;
                int LoginFails = AccountTxt.Items.Count;
                string[] Accounts = AccountTxt.Items.Cast<object>().Select(i => i.ToString()).ToArray();
                AnimationDisplay = string.Format("Logging In% | (1/{0})", Accounts.Length);
                AnimationTmr.Start();
                foreach (string Account in Accounts)
                {
                    if (Account.Contains('@'))
                    {
                        Program.Emails[Account].BeginLogin(new AsyncCallback((iAr) =>
                        {
                            HSession HS = (HSession)iAr.AsyncState;
                            if (HS.EndLogin(iAr))
                            {
                                LoginFails--;
                                Program.Accounts[HS.PlayerName] = HS;
                                Invoke(new Action(() =>
                                {
                                    AccountTxt.Items.Remove(HS.Email);
                                    AccountTxt.Items.Add(HS.PlayerName);
                                    AccountTxt.SelectedIndex = AccountTxt.Items.IndexOf(HS.PlayerName);
                                }));
                            }
                            AnimationDisplay = string.Format("Logging In% | ({0}/{1})", LoginCount + 2, Accounts.Length);
                            if (++LoginCount == Accounts.Length)
                                DisplayFinish(string.Format("Login(s) Succeeded! | ({0}/{1})", Accounts.Length - LoginFails, Accounts.Length));
                        }), Program.Emails[Account]);
                    }
                    else
                    {
                        Program.Accounts[Account].BeginLogin(new AsyncCallback((iAr) =>
                        {
                            if ((iAr.AsyncState as HSession).EndLogin(iAr))
                                LoginFails--;
                            AnimationDisplay = string.Format("Logging In% | ({0}/{1})", LoginCount + 2, Accounts.Length);
                            if (++LoginCount == Accounts.Length)
                                DisplayFinish(string.Format("Login(s) Succeeded! | ({0}/{1})", Accounts.Length - LoginFails, Accounts.Length));
                        }), Program.Accounts[Account]);
                    }
                }
                #endregion
            }
            else
            {
                #region Account Login: Single
                string AN = AccountTxt.Text;
                AnimationDisplay = string.Format("Logging In% | {0}", AN);
                AnimationTmr.Start();
                if (AN.Contains("@"))
                {
                    Program.Emails[AN].BeginLogin(new AsyncCallback((iAr) =>
                    {
                        HSession HS = (HSession)iAr.AsyncState;
                        if (HS.EndLogin(iAr))
                        {
                            Program.Accounts[HS.PlayerName] = HS;
                            Invoke(new Action(() =>
                            {
                                AccountTxt.Items.Remove(HS.Email);
                                AccountTxt.Items.Add(HS.PlayerName);
                                AccountTxt.SelectedIndex = AccountTxt.Items.IndexOf(HS.PlayerName);
                            }));
                            DisplayFinish("Login Success! | " + AN);
                        }
                        else
                            DisplayFinish("Login Failed! | " + AN);
                    }), Program.Emails[AN]);
                }
                else
                {
                    Program.Accounts[AN].BeginLogin(new AsyncCallback((iAr) =>
                    {
                        DisplayFinish(string.Format("Login {0}! | {1}", (iAr.AsyncState as HSession).EndLogin(iAr) ? "Success" : "Failed", AN));
                    }), Program.Accounts[AN]);
                }
                #endregion
            }
        }

        private bool ConnectingBot;
        private int BotsLoaded, BotsExpected;
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (Program.Accounts.Count < 1 || ConnectingBot) return;
            BotsExpected = Program.Accounts.Count - Program.Connections.Count;
            if (BotsExpected == 0) return;
            AnimationDisplay = string.Format("Connecting% | (1/{0})", BotsExpected);
            AnimationTmr.Start();

            BotsLoaded = 0;
            ConnectingBot = true;
            UpdateAccountUI(false);
            UpdateConnectionFeats(false);

            Task.Factory.StartNew(() =>
            {
                HSession[] HSs = Program.Accounts.Values.Where(H => !Program.Connections.ContainsKey(H)).ToArray();
                foreach (HSession H in HSs)
                {
                    H.OnConnected += H_OnConnected;
                    H.DataToClient += H_DataToClient;
                    H.OnDisconnected += H_OnDisconnected;
                    H.Connect();
                }
            });
        }

        private void H_OnConnected(object sender, EventArgs e)
        {
            HSession H = (HSession)sender;
            Program.Connections[H] = new HKeyExchange(3, "90e0d43db75b5b8ffc8a77e31cc9758fa43fe69f14184bef64e61574beb18fac32520566f6483b246ddc3c991cb366bae975a6f6b733fd9570e8e72efc1e511ff6e2bcac49bf9237222d7c2bf306300d4dfc37113bcc84fa4401c9e4f2b4c41ade9654ef00bd592944838fae21a05ea59fecc961766740c82d84f4299dfb33dd");
            OnBotLoaded(H);

            H.SendToServer(4000, H.FlashClientRevision);
            H.SendToServer(1696);
        }
        private void H_OnDisconnected(object sender, EventArgs e)
        {
            if (Program.Connections.ContainsKey((HSession)sender))
            {
                Program.Connections.Remove((HSession)sender);
                Invoke(new Action(() => { Text = string.Format("Kendax ~ {0}[Connected]", Program.Connections.Count); }));
            }
        }
        private void H_DataToClient(object sender, DataToEventArgs e)
        {
            HSession HS = (HSession)sender;
            switch (e.Step)
            {
                case 1:
                {
                    Program.Connections[HS].DoHandshake(e.Packet.ReadString(), e.Packet.ReadString());
                    HS.SendToServer(1874, Program.Connections[HS].PublicKey);
                    break;
                }
                case 2:
                {
                    byte[] SharedKey = Program.Connections[HS].GetSharedKey(e.Packet.ReadString());
                    HS.ClientEncrypt = new HRC4(SharedKey);
                    HS.ServerDecrypt = new HRC4(SharedKey);

                    HS.ReceiveData = false;
                    HS.SendToServer(2417, 401, HS.FlashClientURL, HS.GameData.Variables);
                    HS.SendToServer(3619, HS.SSOTicket, -1);
                    break;
                }
            }
        }

        private void SendToAll(ushort Header, int Amount = 0, params object[] Chunks)
        {
            byte[] Data = HMessage.Construct(Header, HDestinations.Server, HProtocols.Modern, Chunks);
            SendToAll(Data, Amount);
        }
        private void SendToAll(byte[] Data, int Amount = 0)
        {
            if (Program.Connections.Count == 0) { PingTmr.Enabled = false; return; }

            HSession[] HSs = Program.Connections.Keys.ToArray();
            if (Amount == 0) Amount = Program.Connections.Count;

            for (int i = 0; i < HSs.Length; i++)
            {
                HSs[i].SendToServer(new HMessage(Data).ToBytes());
                if (i >= Amount - 1) break;
            }
        }
        private void SendToAll(HMessage Packet, int Amount = 0)
        {
            SendToAll(Packet.ToBytes(), Amount);
        }
        private void OnBotLoaded(HSession HS)
        {
            if (ConnectingBot)
            {
                AnimationDisplay = string.Format("Connecting% | ({0}/{1})", ++BotsLoaded, BotsExpected);
                if (BotsLoaded == BotsExpected)
                {
                    ConnectingBot = false;
                    foreach (HSession H in Program.Connections.Keys) if (!H.IsConnected) H.Disconnect();
                    NavAmountNud.Maximum = Program.Connections.Count;
                    DisplayFinish(string.Format("Connected! | ({0}/{1})", BotsLoaded, BotsExpected));
                }
                Invoke(new Action(() => { Text = string.Format("Kendax ~ {0}[Connected]", Program.Connections.Count); }));
            }
        }

        private void NavigateBtn_Click(object sender, EventArgs e)
        {
            SendToAll(HHeaders.Navigate, (int)NavAmountNud.Value, int.Parse(RoomIDTxt.Text), RoomPasswordTxt.Text, -1);
        }

        #region Processing Animation
        private int AnimationTick = 0;
        private string AnimationDisplay = string.Empty;
        string[] AnimationDots = new string[3] { ".", "..", "..." };
        private void AnimationTmr_Tick(object sender, EventArgs e)
        {
            StatusTxt.Text = AnimationDisplay.Replace("%", AnimationDots[AnimationTick]);
            AnimationTick += AnimationTick == 2 ? -2 : 1;
        }
        #endregion

        private byte[] PingData = new HMessage(HHeaders.Pong).ToBytes();
        private void AccountTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!LoggingIn && !ConnectingBot)
            {
                string AN = AccountTxt.Text;
                if (!AN.Contains("@"))
                {
                    UpdateAccountUI(false);
                    UpdateConnectionFeats(false);
                    AnimationDisplay = string.Format("Grabbing Avatar% | {0}", AN);
                    AnimationTmr.Start();

                    Task.Factory.StartNew(new Action(() =>
                    {
                        bool isLoggedIn = Program.Accounts[AN].IsLoggedIn;
                        bool isConnected = Program.Accounts[AN].IsConnected;
                        if (!isLoggedIn)
                        {
                            Invoke(new Action(() =>
                            {
                                AvatarPctbx.Image = Resources.Avatar;
                                AccountTxt.Items.Remove(Program.Accounts[AN].PlayerName);
                                AccountTxt.Items.Add(Program.Accounts[AN].Email);
                                AccountTxt.SelectedIndex = AccountTxt.Items.IndexOf(Program.Accounts[AN].Email);
                            }));

                            Program.Accounts.Remove(AN);
                            UpdateAccountUI(false);
                            UpdateConnectionFeats(true);
                            DisplayFinish(string.Format("You've been signed out! | {0}", AN), false);
                        }
                        else
                        {
                            ConnectedLbl.Invoke(new Action(() =>
                            {
                                ConnectedLbl.Text = isConnected.ToString();
                                ConnectedLbl.ForeColor = isConnected ? Color.DarkGreen : Color.DarkRed;
                            }));

                            Image Avatar = SKore.GetPlayerAvatar(AN, Program.Accounts[AN].Hotel);
                            AvatarPctbx.Invoke(new Action(() => { AvatarPctbx.Image = Avatar; }));
                            UpdateAccountUI(true);
                            UpdateConnectionFeats(true);
                            DisplayFinish(string.Format("Avatar Grabbed! | {0}", AN), false);
                        }
                    }));
                }
                else
                {
                    ConnectedLbl.Text = "False";
                    ConnectedLbl.ForeColor = Color.DarkRed;
                    AvatarPctbx.Image = Resources.Avatar;
                    UpdateAccountUI(false);
                    UpdateConnectionFeats(true);
                }
            }
        }
        private void PingTmr_Tick(object sender, EventArgs e)
        {
            SendToAll(PingData);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            HSession[] HSs = Program.Connections.Keys.ToArray();
            foreach (HSession HS in HSs)
                HS.Disconnect();
        }

        private Random LocationRandomizer;
        private void WalkingTmr_Tick(object sender, EventArgs e)
        {
            if (Program.Connections.Count == 0) { PingTmr.Enabled = false; return; }
            HSession[] HSs = Program.Connections.Keys.ToArray();

            foreach (HSession H in HSs)
            {
                int RandomX = LocationRandomizer.Next((int)WalkXMin.Value, (int)WalkXMax.Value + 1);
                int RandomY = LocationRandomizer.Next((int)WalkYMin.Value, (int)WalkYMax.Value + 1);
                H.SendToServer(HHeaders.Walk, RandomX, RandomY);
            }
        }

        private void WalkToBtn_Click(object sender, EventArgs e)
        {
            SendToAll(HHeaders.Walk, 0, (int)WalkXMin.Value, (int)WalkYMin.Value);
        }
        private void AutoWalkChckbx_CheckedChanged(object sender, EventArgs e)
        {
            WalkingTmr.Enabled = AutoWalkChckbx.Checked;
        }

        private void SetMottoBtn_Click(object sender, EventArgs e)
        {
            SendToAll(HHeaders.Motto, 0, MottoTxt.Text);
        }
        private void SetClothesBtn_Click(object sender, EventArgs e)
        {
            SendToAll(HHeaders.Clothes, 0, "M", ClothesTxt.Text);
        }
        private void FriendRequestBtn_Click(object sender, EventArgs e)
        {
            SendToAll(HHeaders.AddFriend, 0, TargetTxt.Text);
        }
    }
}