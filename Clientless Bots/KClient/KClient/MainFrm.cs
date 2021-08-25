using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using KClient.Properties;
using Sulakore.Communication;

namespace KClient
{
    public partial class MainFrm : Form
    {
        private bool _mouseDown;
        private Point _lastLocation;

        public static string Token;

        private readonly Intercept _intercept;

        public bool CanGrabSSO;
        public Dictionary<string, int> Proxies;
        public bool IsUsingProxy;
        public int BotsPerProxy;
        private Dictionary<string, int> novasProxies = new Dictionary<string, int>();

        public MainFrm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _intercept = new Intercept(this);

            panelActions.Size = new Size(panelConnection.Width, panelConnection.Height);
            panelActions.Top = panelConnection.Top;
            panelActions.Left = panelConnection.Left;

            panelBotManager.Size = new Size(panelConnection.Width, panelConnection.Height);
            panelBotManager.Left= panelConnection.Left;
            panelBotManager.Top = panelConnection.Top;

            panelProxy.Left = panelConnection.Left;
            panelProxy.Top = panelConnection.Top;

            panelConnection.BringToFront();

            Headers.Load();
        }

        private async void CheckBotsCount()
        {
            while (true)
            {
                lbBotCount.Text = Handler.Bots.Count.ToString();
                await Task.Delay(500);
            }
        }

        #region  Controls

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.errorVermelho;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.errorBranco;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _intercept.Stop();
            Environment.Exit(0);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Crimson;

            btnActions.BackColor = Color.FromArgb(243, 63, 63);
            btnManagement.BackColor = Color.FromArgb(243, 63, 63);

            panelConnection.BringToFront();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Crimson;

            btnActions.BackColor = Color.FromArgb(243, 63, 63);
            btnConnection.BackColor = Color.FromArgb(243, 63, 63);

            panelBotManager.BringToFront();
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Crimson;

            btnConnection.BackColor = Color.FromArgb(243, 63, 63);
            btnManagement.BackColor = Color.FromArgb(243, 63, 63);

            panelActions.BringToFront();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point(
                (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

            Update();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        public void AppendText(string sso)
        {
            txtSSOList.Text = txtSSOList.Text == "" ? sso : txtSSOList.Text + "|" + sso;
        }

        #endregion

        #region panel Connection

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSSOList.Text)) return;

            _intercept.Stop();
            btnOpenGrab.BackColor = Color.FromArgb(243, 63, 63);
            btnOpenGrab.Text = @"Interceptar SSO";

            var str = txtSSOList.Text.Trim();

            if (IsUsingProxy)
            {
                LogInfo($"Checando {Proxies.Count} proxies.");

                var tasks = new List<Task>();

                foreach (var proxy in Proxies)
                {
                    var task = CheckProxy(proxy.Key, proxy.Value);
                    tasks.Add(task);
                }

                await Task.WhenAll(tasks.ToArray());

                Proxies = novasProxies; 
            }

            new Task(CheckBotsCount).Start();
            Handler.Start(str, this);

            txtSSOList.Clear();

            if (IsUsingProxy) LogInfo($"{Proxies.Count()} Proxies carregadas.");
            LogInfo("Bot Handler Iniciado.");
            btnActions.Enabled = true;
            btnManagement.Enabled = true;
        }

        private async Task CheckProxy(string server, int port)
        {
            var h = new HNode { SOCKS5EndPoint = new IPEndPoint(IPAddress.Parse(server), port) };
            await h.ConnectAsync(Dns.GetHostAddresses("habbo.com.br")[0], 80);
            if (h.IsConnected)
            {
                novasProxies.Add(server, port);
                LogSucess($"[{server}:{port}] => Sucesso");
            }
            else
            {
                LogError($"[{server}:{port}] => Falha");
            }
        }

        private void btnOpenGrab_Click(object sender, EventArgs e)
        {
            if (btnOpenGrab.Text == @"Interceptar SSO")
            {
                if (!_intercept.HasInstalledCertificate())
                    _intercept.InstallCertificate();

                _intercept.Start();
                btnOpenGrab.BackColor = Color.Crimson;
                btnOpenGrab.Text = @"Interceptando";
                LogInfo("SSO Handler iniciado.");
            }
            else
            {
                _intercept.Stop();
                btnOpenGrab.BackColor = Color.FromArgb(243, 63, 63);
                btnOpenGrab.Text = @"Interceptar SSO";
            }
        }

        #endregion

        #region panel Ações

        private void btnEnterRoom_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRoomId.Text, out var roomId)) return;
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.LoadRoom(roomId));
                return;
            }
            Handler.SendToAllBots(bot => bot.LoadRoom(roomId));
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtXpos.Text, out var x) || !int.TryParse(txtYPos.Text, out var y)) return;
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.WalkTo(x, y));
                return;
            }
            Handler.SendToAllBots(bot => bot.WalkTo(x, y));
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.Shout(txtTalk.Text));
                return;
            }
            Handler.SendToAllBots(bot => bot.Shout(txtTalk.Text));
        }

        private void btnWalkAround_Click(object sender, EventArgs e)
        {
            if (btnWalkAround.Text == @"Andar Aut.")
            {
                btnWalkAround.BackColor = Color.Crimson;
                btnWalkAround.Text = @"Parar de andar";
                if (skoreUsingBots.Items.Count > 0)
                {
                    Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.WalkAround(true));
                    return;
                }
                Handler.SendToAllBots(b => b.WalkAround(true));
            }

            else
            {
                btnWalkAround.Text = @"Andar Aut.";
                btnWalkAround.BackColor = Color.FromArgb(243, 63, 63);

                if (skoreUsingBots.Items.Count > 0)
                {
                    Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.WalkAround(false));
                    return;
                }
                Handler.SendToAllBots(b => b.WalkAround(false));
            }
        }

        private void btnRespectUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRespectUserId.Text, out var userId)) return;
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.Respect(userId));
                return;
            }
            Handler.SendToAllBots(bot => bot.Respect(userId));
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.Sit(false));
                return;
            }
            Handler.SendToAllBots(bot => bot.Sit(false));
        }

        private void btnSit_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), bot => bot.Sit(true));
                return;
            }

            Handler.SendToAllBots(bot => bot.Sit(true));
        }

        private void btnScratch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPetId.Text, out var petId)) return;
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), b => b.Scratch(petId));
                return;
            }
            Handler.SendToAllBots(bot => bot.Scratch(petId));
        }

         private void btnDance_Click(object sender, EventArgs e)
         {
            if (btnDance.Text is "Dançar")
            {
                btnDance.BackColor = Color.Crimson;
                btnDance.Text = @"Parar de dançar";
                if (skoreUsingBots.Items.Count > 0)
                {
                    Handler.SendToAllUsingBots(GetUsingBots(), b => b.Dance(true));
                    return;
                }
                Handler.SendToAllBots(bot => bot.Dance(true));}
            else
            {
                btnDance.Text = @"Dançar";
                btnDance.BackColor = Color.FromArgb(243, 63, 63);

                if (skoreUsingBots.Items.Count > 0)
                {
                    Handler.SendToAllUsingBots(GetUsingBots(), b => b.Dance(false));
                    return;
                }
                Handler.SendToAllBots(bot => bot.Dance(false));
            }
         }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void btnChangeClothes_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count > 0)
            {
                Handler.SendToAllUsingBots(GetUsingBots(), b => b.ChangeClothes(txtFigureString.Text));
                return;
            }
            Handler.SendToAllBots(bot => bot.ChangeClothes(txtFigureString.Text));
        }

        private List<int> GetUsingBots()
        {
            var ids = new List<int>();
            foreach (ListViewItem item in skoreUsingBots.Items)
                ids.Add((int)item.Tag);

            return ids;
        }

        #endregion

        private string GetHwid()
        {
            var dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            return dsk["VolumeSerialNumber"].ToString();
        }

        #region log
        public void Log(string msg, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new LogDelegate(Log), msg, color);
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionColor = color;
                richTextBox1.AppendText(richTextBox1.TextLength > 0 ? "\n" + msg : msg);
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
            }
        }

        public void LogInfo(string msg)
        {
            Log(msg, Color.White);
        }

        public void LogError(string msg)
        {
            Log(msg, Color.Red);
        }

        public void LogWarning(string msg)
        {
            Log(msg, Color.Yellow);
        }

        public void LogSucess(string msg)
        {
            Log(msg, Color.LimeGreen);
        }

        private delegate void LogDelegate(string msg, Color color);

        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region panel Ajuda

        private void btnTamperMonkey_Click(object sender, EventArgs e)
        {
            Process.Start(
                "https://chrome.google.com/webstore/detail/tampermonkey/dhdgffkkebhmkfjojejmpbldmpobfkfo?hl=pt-BR");
        }

        private void btnLogador_Click(object sender, EventArgs e)
        {
            Process.Start("http://bonniebots.pw/logador/bonniesso.user.js");
        }

        #endregion

        #region  minimize

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(243, 63, 63);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        #endregion

        #region label titulo move

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void lbTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point(
                (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

            Update();
        }

        private void lbTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        #endregion

        #region Bot Manager

        public void AddBot(int id)
        {
            var item = new ListViewItem
            {
                Text = @"BOT " + id,
                Tag = id
            };
            skoreBotList.Items.Add(item);
        }

        public void RemoveBotFromLists(int id)
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

        private void btnAddBot_Click(object sender, EventArgs e)
        {
            if (skoreBotList.SelectedItems.Count is 0) return;
            foreach (ListViewItem item in skoreBotList.SelectedItems)
            {
                skoreBotList.Items.Remove(item);
                skoreUsingBots.Items.Add(item);
            }
        }

        private void btnRemoveBot_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.SelectedItems.Count is 0) return;
            foreach (ListViewItem item in skoreUsingBots.SelectedItems)
            {
                skoreUsingBots.Items.Remove(item);
                skoreBotList.Items.Add(item);
            }
        }

        private void btnClearUsingBots_Click(object sender, EventArgs e)
        {
            if (skoreUsingBots.Items.Count is 0) return;
            foreach (ListViewItem item in skoreUsingBots.Items)
            {
                skoreUsingBots.Items.Remove(item);
                skoreBotList.Items.Add(item);
            }
        }

        #endregion

        private void ckbProxy_CheckedChanged(object sender, EventArgs e)
        {
            IsUsingProxy = ckbProxy.Checked;
            if(ckbProxy.Checked)
                panelProxy.BringToFront();
            else
                panelConnection.BringToFront();
        }

        private void btnSaveProxies_Click(object sender, EventArgs e)
        {
            panelConnection.BringToFront();
            if (string.IsNullOrWhiteSpace(txtProxyList.Text)) return;
            Proxies = new Dictionary<string, int>();
            BotsPerProxy = (int) numericProxyQuant.Value;

            var lines = txtProxyList.Text.Split('\n');
            foreach (var line in lines)
                if(!Proxies.ContainsKey(line.Split(':')[0].Trim()))
                    Proxies.Add(line.Split(':')[0].Trim(), Convert.ToInt32(line.Split(':')[1].Trim()));
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) // header updater
        {
            var result = MessageBox.Show("Tanji precisa estar aberto para atualizar as headers corretamente. Deseja continuar?\n-------\n" +
                                         "Tanji needs to be open to update the headers correctly. Do you wish to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Process.Start("HeadersUpdater\\HeadersUpdater.exe");
        }
    }
}
