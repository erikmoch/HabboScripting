using Sulakore.Communication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tween_Bot_V3.Properties;

namespace Tween_Bot_V3
{
    public partial class Main : Form
    {
        public Dictionary<string, int> Proxies = new Dictionary<string, int>();
        public Dictionary<string, int> checkedProxies = new Dictionary<string, int>();
        public List<string> emails = new List<string>();
        public List<string> passwords = new List<string>();
        public int currentAccount;
        public bool isUsingProxy;
        private Intercept _intercept;
        private LoginFrm _login;
        private bool isFlooding;
        private int mouseX = 0;
        private int mouseY = 0;

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _login = new LoginFrm(this);
            _intercept = new Intercept(this, _login);
            if (!File.Exists("accounts.txt"))
                File.Create("accounts.txt").Dispose();
            if (!File.Exists("proxies.txt"))
                File.Create("proxies.txt").Dispose();
            //if (!File.Exists("Headers.ini"))
            //    File.Delete("Headers.ini");
            //using (var client = new WebClient())
            //{
            //    client.DownloadFile("http://tween.ueuo.com/Headers.ini", "Headers.ini");
            //}
            LoadAccounts();
            CheckProxies();
            #region Design shit
            panelConnection.BringToFront();
            panelActions1.Size = new Size(panelConnection.Width, panelConnection.Height);
            panelActions1.Top = panelConnection.Top;
            panelActions1.Left = panelConnection.Left;
            panelActions2.Size = new Size(panelConnection.Width, panelConnection.Height);
            panelActions2.Top = panelConnection.Top;
            panelActions2.Left = panelConnection.Left;
            panelManagement.Size = new Size(panelConnection.Width, panelConnection.Height);
            panelManagement.Top = panelConnection.Top;
            panelManagement.Left = panelConnection.Left;
            Size = new Size(435, 278);
            #endregion
        }

        private void LoadAccounts()
        {
            try
            {
                foreach (var line in File.ReadAllLines("accounts.txt"))
                {
                    emails.Add(line.Split(':')[0]);
                    passwords.Add(line.Split(':')[1]);
                }
            }
            catch { MessageBox.Show("Não foi possível carregar suas contas.", "Tween Bot V3"); }
            if (emails.Count > 0)
                btnLoginBot.Enabled = true;
            btnLoginBot.Text = $"Logar ({currentAccount}/{emails.Count})";
        }

        private async void CheckProxies()
        {
            try
            {
                foreach (var line in File.ReadAllLines("proxies.txt"))
                {
                    if (!Proxies.ContainsKey(line.Split(':')[0].Trim()))
                        Proxies.Add(line.Split(':')[0].Trim(), Convert.ToInt32(line.Split(':')[1].Trim()));
                }
            }
            catch { MessageBox.Show("Não foi possível carregar suas proxies.", "Tween Bot V3"); }
                var tasks = new List<Task>();
            foreach (var proxy in Proxies)
            {
                var task = CheckProxy(proxy.Key, proxy.Value);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks.ToArray());
            Proxies = checkedProxies;
        }

        public async Task CheckProxy(string server, int port)
        {
            var h = new HNode { SOCKS5EndPoint = new IPEndPoint(IPAddress.Parse(server), port) };
            await h.ConnectAsync("game-br.habbo.com", 30000);
            if (h.IsConnected)
            {
                //LogSuccess("[PROXY] " + server);
                checkedProxies.Add(server, port);
                Proxies = checkedProxies;
                isUsingProxy = true;
                lblProxy.Text = $"/ Proxies disponíveis: {Proxies.Count}";
            }
            else
            {
                //LogError("[PROXY] " + server);
                Proxies = checkedProxies;
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string[] ssos = txtSSO.Text.Split('\n');
            txtSSO.Clear();
            foreach (var sso in ssos)
            {
                BotHandler.Start(sso, this);
                await Task.Delay(1000);
            }
        }

        private void btnLoginBot_Click(object sender, EventArgs e)
        {
            if (!_intercept.HasInstalledCertificate())
                _intercept.InstallCertificate();
            if (currentAccount >= emails.Count)
            {
                MessageBox.Show("Você não tem contas restantes para logar.", "Tween Bot V3");
            }
            else
            {
                btnLoginBot.Text = $"Logar ({currentAccount + 1}/{emails.Count})";
                btnLoginBot.Enabled = false;
                _login.Show();
                _login.Auth(emails[currentAccount], passwords[currentAccount]);
            }
        }

        private void btnIntercept_Click(object sender, EventArgs e)
        {
            if (!_intercept.HasInstalledCertificate())
                _intercept.InstallCertificate();

            if (btnIntercept.Text == "Interceptar Login")
            {
                _intercept.Start();
                btnIntercept.Skin = Color.Black;
                btnIntercept.Text = "Interceptando Login";
            }
            else
            {
                _intercept.Stop();
                btnIntercept.Skin = Color.FromArgb(35, 35, 35);
                btnIntercept.Text = "Interceptar Login";
            }
        }

        public void TanjiClothes(string figureId)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.ChangeClothes(figureId));
            else
                BotHandler.SendToAllBots(b => b.ChangeClothes(figureId));
        }

        public void TanjiRespect(int id)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Respect(id));
            else
                BotHandler.SendToAllBots(b => b.Respect(id));
        }

        public void TanjiScratch(int id)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Scratch(id));
            else
                BotHandler.SendToAllBots(b => b.Scratch(id));
        }

        public void TanjiWalk(int x, int y)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.WalkTo(x, y));
            else
                BotHandler.SendToAllBots(b => b.WalkTo(x, y));
        }

        public void TanjiRoom(int id)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.LoadRoom(id));
            else
                BotHandler.SendToAllBots(b => b.LoadRoom(id));
        }

        public void FillRespect(int id)
        {
            txtRespect.Text = id.ToString();
        }

        public void FillPet(int id)
        {
            txtScratch.Text = id.ToString();
        }

        public void FillWalk(int x, int y)
        {
            txtPosX.Text = x.ToString();
            txtPosY.Text = y.ToString();
        }

        public void FillRoom(int id)
        {
            txtRoom.Text = id.ToString();
        }

        public void FillGroup(int id)
        {
            txtGroup.Text = id.ToString();
        }

        #region Bot Manager
        public void AddBot(int id)
        {
            try
            {
                var item = new ListViewItem
                {
                    Text = @"BOT " + id,
                    Tag = id
                };
                skoreBotList.Items.Add(item);
            }
            catch { }
        }

        public void RemoveBotFromLists(int id)
        {
            try
            {
                foreach (ListViewItem item in skoreBotList.Items)
                {
                    if ((int)item.Tag != id) continue;
                    skoreBotList.Items.Remove(item);
                    return;
                }

                foreach (ListViewItem item in skoreUsingBots.Items)
                {
                    if ((int)item.Tag != id) continue;
                    skoreUsingBots.Items.Remove(item);
                    break;
                }
            }
            catch { }
        }

        private void btnAddBot_Click(object sender, EventArgs e)
        {
            try
            {
                if (skoreBotList.SelectedItems.Count is 0) return;
                foreach (ListViewItem item in skoreBotList.SelectedItems)
                {
                    skoreBotList.Items.Remove(item);
                    skoreUsingBots.Items.Add(item);
                }
            }
            catch { }
        }

        private void btnRemoveBot_Click(object sender, EventArgs e)
        {
            try
            {
                if (skoreUsingBots.SelectedItems.Count is 0) return;
                foreach (ListViewItem item in skoreUsingBots.SelectedItems)
                {
                    skoreUsingBots.Items.Remove(item);
                    skoreBotList.Items.Add(item);
                }
            }
            catch { }
        }

        private void btnClearUsingBots_Click(object sender, EventArgs e)
        {
            try
            {
                if (skoreUsingBots.Items.Count is 0) return;
                foreach (ListViewItem item in skoreUsingBots.Items)
                {
                    skoreUsingBots.Items.Remove(item);
                    skoreBotList.Items.Add(item);
                }
            }
            catch { }
        }

        private void btnManagerRename_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in skoreUsingBots.SelectedItems)
                selectedItem.Text = "BOT " + txtManagerRename.Text;
        }

        private List<int> GetUsingBots()
        {
            var ids = new List<int>();
            foreach (ListViewItem item in skoreUsingBots.Items)
                ids.Add((int)item.Tag);

            return ids;
        }
        #endregion

        #region log
        public void Log(string msg, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new LogDelegate(Log), msg, color);
            }
            else
            {
                txtLog.SelectionStart = txtLog.TextLength;
                txtLog.SelectionLength = 0;
                txtLog.SelectionColor = color;
                txtLog.AppendText(txtLog.TextLength > 0 ? "\n" + msg : msg);
                txtLog.SelectionColor = txtLog.ForeColor;
            }
        }

        public void LogInfo(string msg)
        {
            Log($"[{GetTimestamp(DateTime.Now)}] {msg}", Color.DodgerBlue);
        }

        public void LogError(string msg)
        {
            Log($"[{GetTimestamp(DateTime.Now)}] {msg}", Color.Crimson);
        }

        public void LogWarning(string msg)
        {
            Log($"[{GetTimestamp(DateTime.Now)}] {msg}", Color.Yellow);
        }

        public void LogSuccess(string msg)
        {
            Log($"[{GetTimestamp(DateTime.Now)}] {msg}", Color.LimeGreen);
        }

        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }

        private delegate void LogDelegate(string msg, Color color);

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
        #endregion

        #region Design shit
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.errorred;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.errorwhite;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _intercept.Stop();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Crimson;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.White;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            panelConnection.BringToFront();
            btnConnection.BackColor = Color.FromArgb(32, 32, 32);
            btnActions1.BackColor = Color.FromArgb(41, 41, 41);
            btnActions2.BackColor = Color.FromArgb(41, 41, 41);
            btnManagement.BackColor = Color.FromArgb(41, 41, 41);
        }

        private void btnActions1_Click(object sender, EventArgs e)
        {
            panelActions1.BringToFront();
            btnActions1.BackColor = Color.FromArgb(32, 32, 32);
            btnConnection.BackColor = Color.FromArgb(41, 41, 41);
            btnActions2.BackColor = Color.FromArgb(41, 41, 41);
            btnManagement.BackColor = Color.FromArgb(41, 41, 41);
        }

        private void btnActions2_Click(object sender, EventArgs e)
        {
            panelActions2.BringToFront();
            btnActions2.BackColor = Color.FromArgb(32, 32, 32);
            btnConnection.BackColor = Color.FromArgb(41, 41, 41);
            btnActions1.BackColor = Color.FromArgb(41, 41, 41);
            btnManagement.BackColor = Color.FromArgb(41, 41, 41);
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            panelManagement.BringToFront();
            btnManagement.BackColor = Color.FromArgb(32, 32, 32);
            btnActions1.BackColor = Color.FromArgb(41, 41, 41);
            btnActions2.BackColor = Color.FromArgb(41, 41, 41);
            btnConnection.BackColor = Color.FromArgb(41, 41, 41);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void lblBotsOn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mouseX = Left - MousePosition.X;
            mouseY = Top - MousePosition.Y;
        }

        private void lblBotsOn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Left = mouseX + MousePosition.X;
            Top = mouseY + MousePosition.Y;
        }

        private void txtRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRespect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtScratch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPosX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPosY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFloodDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            _intercept.Stop();
            Application.Exit();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
            {
                if (cbRoomPass.Checked)
                {
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.LoadRoomPass(Convert.ToInt32(txtRoom.Text), txtRoomPass.Text));
                }
                else
                {
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.LoadRoom(Convert.ToInt32(txtRoom.Text)));
                }
            }
            else
            {
                if (cbRoomPass.Checked)
                {
                    BotHandler.SendToAllBots(b => b.LoadRoomPass(Convert.ToInt32(txtRoom.Text), txtRoomPass.Text));
                }
                else
                {
                    BotHandler.SendToAllBots(b => b.LoadRoom(Convert.ToInt32(txtRoom.Text)));
                }
            }
        }

        private void btnLeaveRoom_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.LeaveRoom());
            else
                BotHandler.SendToAllBots(b => b.LeaveRoom());
        }

        private void btnLikeRoom_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.LikeRoom());
            else
                BotHandler.SendToAllBots(b => b.LikeRoom());
        }

        private void btnClothes_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.ChangeClothes(txtClothes.Text));
            else
                BotHandler.SendToAllBots(b => b.ChangeClothes(txtClothes.Text));
        }

        private void btnSit_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Sit(true));
            else
                BotHandler.SendToAllBots(b => b.Sit(true));
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Sit(false));
            else
                BotHandler.SendToAllBots(b => b.Sit(false));
        }

        private void btnRespect_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Respect(Convert.ToInt32(txtRespect.Text)));
            else
                BotHandler.SendToAllBots(b => b.Respect(Convert.ToInt32(txtRespect.Text)));
        }

        private void btnScratch_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Scratch(Convert.ToInt32(txtScratch.Text)));
            else
                BotHandler.SendToAllBots(b => b.Scratch(Convert.ToInt32(txtScratch.Text)));
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Sign(Convert.ToInt32(txtSign.Text)));
            else
                BotHandler.SendToAllBots(b => b.Sign(Convert.ToInt32(txtSign.Text)));
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Shout(txtTalk.Text));
            else
                BotHandler.SendToAllBots(b => b.Shout(txtTalk.Text));
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.JoinGroup(Convert.ToInt32(txtGroup.Text)));
            else
                BotHandler.SendToAllBots(b => b.JoinGroup(Convert.ToInt32(txtGroup.Text)));
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.FriendRequest(txtFriend.Text));
            else
                BotHandler.SendToAllBots(b => b.FriendRequest(txtFriend.Text));
        }

        private void btnMotto_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.ChangeMotto(txtMotto.Text));
            else
                BotHandler.SendToAllBots(b => b.ChangeMotto(txtMotto.Text));
        }

        private void btnRandomClothesM_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomClothesM());
            else
                BotHandler.SendToAllBots(b => b.RandomClothesM());
        }

        private void btnRandomClothesF_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomClothesF());
            else
                BotHandler.SendToAllBots(b => b.RandomClothesF());
        }

        private void btnDance_Click(object sender, EventArgs e)
        {
            if (btnDance.Text == "Dançar")
            {
                btnDance.Text = "Parar Dança";
                btnDance.Skin = Color.Black;
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Dance(true));
                else
                    BotHandler.SendToAllBots(b => b.Dance(true));
            }
            else
            {
                btnDance.Text = "Dançar";
                btnDance.Skin = Color.FromArgb(35, 35, 35);
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Dance(false));
                else
                    BotHandler.SendToAllBots(b => b.Dance(false));
            }
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Wave());
            else
                BotHandler.SendToAllBots(b => b.Wave());
        }

        private void btnIdle_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.Idle());
            else
                BotHandler.SendToAllBots(b => b.Idle());
        }

        private void btnThumbsUp_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.ThumbsUp());
            else
                BotHandler.SendToAllBots(b => b.ThumbsUp());
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.WalkTo(Convert.ToInt32(txtPosX.Text), Convert.ToInt32(txtPosY.Text)));
            else
                BotHandler.SendToAllBots(b => b.WalkTo(Convert.ToInt32(txtPosX.Text), Convert.ToInt32(txtPosY.Text)));
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.LookTo(Convert.ToInt32(txtPosX.Text), Convert.ToInt32(txtPosY.Text)));
            else
                BotHandler.SendToAllBots(b => b.LookTo(Convert.ToInt32(txtPosX.Text), Convert.ToInt32(txtPosY.Text)));
        }

        private void btnWalkAround_Click(object sender, EventArgs e)
        {
            if (btnWalkAround.Text == "Andar Aleatóriamente")
            {
                btnWalkAround.Text = "Parar de Andar";
                btnWalkAround.Skin = Color.Black;
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.WalkAround(true));
                else
                    BotHandler.SendToAllBots(b => b.WalkAround(true));
            }
            else
            {
                btnWalkAround.Text = "Andar Aleatóriamente";
                btnWalkAround.Skin = Color.FromArgb(35, 35, 35);
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.WalkAround(false));
                else
                    BotHandler.SendToAllBots(b => b.WalkAround(false));
            }
        }

        private async void btnFlood_Click(object sender, EventArgs e)
        {
            if (btnFlood.Text == "Começar")
            {
                btnFlood.Text = "Parar";
                btnFlood.Skin = Color.Black;
                isFlooding = true;
                if (skoreUsingBots.Items.Count > 0)
                {
                    var usingBots = BotHandler.Bots.Select(bot => bot).Where(bot => GetUsingBots().Contains(bot.Id));
                    while (isFlooding)
                    {
                        try
                        {
                            foreach (var bot in usingBots)
                            {
                                bot.Shout(txtTalk.Text);
                                await Task.Delay(int.Parse(txtFloodDelay.Text));
                            }
                        }
                        catch { return; }
                    }
                }
                else
                {
                    while (isFlooding)
                    {
                        try
                        {
                            foreach (var bot in BotHandler.Bots)
                            {
                                bot.Shout(txtTalk.Text);
                                await Task.Delay(int.Parse(txtFloodDelay.Text));
                            }
                        }
                        catch { return; }
                    }
                }
            }
            else
            {
                btnFlood.Text = "Começar";
                btnFlood.Skin = Color.FromArgb(35, 35, 35);
                isFlooding = false;
            }
        }

        private void btnRandomActions_Click(object sender, EventArgs e)
        {
            if (btnRandomActions.Text == "Ações Aleatórias")
            {
                btnRandomActions.Text = "Parar Ações";
                btnRandomActions.Skin = Color.Black;
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomActions(true));
                else
                    BotHandler.SendToAllBots(b => b.RandomActions(true));
            }
            else
            {
                btnRandomActions.Text = "Ações Aleatórias";
                btnRandomActions.Skin = Color.FromArgb(35, 35, 35);
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomActions(false));
                else
                    BotHandler.SendToAllBots(b => b.RandomActions(false));
            }
        }

        private void btnRandomRotation_Click(object sender, EventArgs e)
        {
            if (btnRandomRotation.Text == "Rotação Aleatória")
            {
                btnRandomRotation.Text = "Parar Rotação";
                btnRandomRotation.Skin = Color.Black;
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomRotate(true));
                else
                    BotHandler.SendToAllBots(b => b.RandomRotate(true));
            }
            else
            {
                btnRandomRotation.Text = "Rotação Aleatória";
                btnRandomRotation.Skin = Color.FromArgb(35, 35, 35);
                if (skoreUsingBots.Items.Count > 0)
                    BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomRotate(false));
                else
                    BotHandler.SendToAllBots(b => b.RandomRotate(false));
            }
        }

        private void cbRandomBubbles_CheckedChanged(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.RandomBubbles(cbRandomBubbles.Checked));
            else
                BotHandler.SendToAllBots(b => b.RandomBubbles(cbRandomBubbles.Checked));
        }

        private void cbAntiBobba_CheckedChanged(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.AntiBobba(cbAntiBobba.Checked));
            else
                BotHandler.SendToAllBots(b => b.AntiBobba(cbAntiBobba.Checked));
        }

        private void cbAntiAfk_CheckedChanged(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
                BotHandler.SendToAllUsingBots(GetUsingBots(), b => b.AFK(cbAntiAfk.Checked));
            else
                BotHandler.SendToAllBots(b => b.AFK(cbAntiAfk.Checked));
        }

        private void skoreBotList_SelectedIndexChanged(object sender, EventArgs e)
        {
            managercount1.Text = $"Select: {skoreBotList.SelectedItems.Count} | Count: {skoreBotList.Items.Count}";
        }

        private void skoreUsingBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            managercount2.Text = $"Select: {skoreUsingBots.SelectedItems.Count} | Count: {skoreUsingBots.Items.Count}";
        }
    }
}
