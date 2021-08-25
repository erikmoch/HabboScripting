using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Axed
{
    public partial class frmBots : Form
    {
        bool WalkRnd;
        bool WarpRnd;
        public frmBots()
        {
            InitializeComponent();
        }
        internal delegate void _VoidMethod();
        private void cmdAddNewBot_Click(object sender, EventArgs e)
        {
            _VoidMethod delRP2 = new _VoidMethod(AddNewBot);
            IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
            cmdAddNewBot.Enabled = false;
        }
        private void AddNewBot()
        {
            BotClass.Bots.AddBot(txtUsername.Text, txtPassword.Text, txtHotel.Text, (FrmMain)this.MdiParent);
        }
        internal delegate void _DAddBot(int I, string N);
        internal void AddBot(int ID, string Name)
        {
            if (this.InvokeRequired)
            { this.Invoke(new _DAddBot(AddBot), ID, Name); }
            else
            {
                LVBots.Items.Add(ID.ToString(), ID.ToString(), 0);
                LVBots.Items[LVBots.Items.Count - 1].SubItems.Add(Name);
                cmdAddNewBot.Enabled = true;
                if (LVBots.Items.Count == 1)
                    LVBots.Items[0].Selected = true;
            }
        }
        internal delegate void _DRemBot(int I);
        internal void RemoveBot(int ID)
        {
            if (this.InvokeRequired)
            { this.Invoke(new _DRemBot(RemoveBot), ID); }
            else
            {
                if (LVBots.Items.ContainsKey(ID.ToString()))
                    LVBots.Items.RemoveByKey(ID.ToString());
            }
        }
        internal void BotError()
        {
            if (this.InvokeRequired)
            { this.Invoke(new _VoidMethod(BotError)); }
            else
            {
                cmdAddNewBot.Enabled = true;
            }
        }
        private void TakeStage(Panel PanelName)
        {
            WipeStage();
            this.Width = 11 + PanelName.Width;
            this.Height = 239 + PanelName.Height;
            PanelName.Dock = DockStyle.Bottom;
        }
        private void WipeStage()
        {
            pnlAddBots.Left = 9999;
            pnlAddBots.Dock = DockStyle.None;
            pnlRoomLoading.Left = 9999;
            pnlRoomLoading.Dock = DockStyle.None;
            pnlFunctions.Left = 9999;
            pnlFunctions.Dock = DockStyle.None;
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TakeStage(pnlAddBots);
        }

        private void frmBots_Load(object sender, EventArgs e)
        {
            TakeStage(pnlAddBots);
        }

        private void pnlAddBots_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdSendToRoom_Click(object sender, EventArgs e)
        {
            if (LVBots.SelectedItems.Count == 0)
                return;
            for (int x = 0; x < LVBots.SelectedItems.Count; x++)
            {
                if (chkPublicRoom.Checked == false)
                    BotClass.Bots.GetReference(int.Parse(LVBots.SelectedItems[x].Text)).LoadRoom((int)txtRoomID.Value);
                else
                    BotClass.Bots.GetReference(int.Parse(LVBots.SelectedItems[x].Text)).LoadPublicRoom((int)txtRoomID.Value, (int)txtRoomPart.Value);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TakeStage(pnlRoomLoading);
        }

        private void cmdWalkTo_Click(object sender, EventArgs e)
        {
            try
            {
                int TmpX = (int)txtXCord.Value;
                int TmpY = (int)txtYCord.Value;
                if (LVBots.SelectedItems.Count == 0)
                    return;
                for (int x = 0; x < LVBots.SelectedItems.Count; x++)
                {
                    try
                    {
                        BotClass.Bots.GetReference(int.Parse(LVBots.SelectedItems[x].Text)).MoveTo(TmpX, TmpY);
                        System.Threading.Thread.Sleep(60);
                        Application.DoEvents();
                        TmpX = TmpX + (int)txtAddtoX.Value;
                        TmpY = TmpY + (int)txtAddtoY.Value;
                        if (TmpY <= 0)
                        {
                            TmpY = 0;
                            TmpX = TmpX + (int)nmResetAtX.Value;
                            TmpY = TmpY + (int)nmResetAtY.Value;
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void cmdShout_Click(object sender, EventArgs e)
        {
            if (LVBots.SelectedItems.Count == 0)
                return;
            for (int x = 0; x < LVBots.SelectedItems.Count; x++)
            {
                BotClass.Bots.GetReference(int.Parse(LVBots.SelectedItems[x].Text)).Shout(txtFunctions.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LVBots.SelectedItems.Count == 0)
                return;
            for (int x = 0; x < LVBots.SelectedItems.Count; x++)
            {
                BotClass.Bots.GetReference(int.Parse(LVBots.SelectedItems[x].Text)).createMessage(txtFunctions.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LVBots.SelectedItems.Count == 0)
                return;
            for (int x = 0; x < LVBots.SelectedItems.Count; x++)
            {
                BotClass.Bots.GetReference(int.Parse(LVBots.SelectedItems[x].Text)).UpdateHabbo("Test", "M", "hd-190-1.ch-255-64.lg-285-85.sh-300-62.hr-165-42.ha-1015-62");
                Application.DoEvents();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TakeStage(pnlFunctions);
        }

        private delegate void LoadUsers(TextReader tw, int Count, string Hotel);
        private void cmdBotsFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                cmdBotsFromFile.Enabled = false;
                TextReader tw = new StreamReader(TxtFileName.Text);
                for (int x = 0; x < (int)nmSkipAccs.Value; x++)
                    tw.ReadLine();
                LoadUsers delRP2 = new LoadUsers(DoUsers);
                IAsyncResult tag2 = delRP2.BeginInvoke(tw, (int)nmAmAccounts.Value, txtHotel.Text, null, null);
            }
            catch
            {
                ReGetFromFile();
            }
        }
        private void ReGetFromFile()
        {
            if (this.InvokeRequired)
            { this.Invoke(new _VoidMethod(ReGetFromFile)); }
            else
            {
                cmdBotsFromFile.Enabled = true;
            }
        }
        private void DoUsers(TextReader tw, int Count, string Hotel)
        {
            try
            {
                for (int x = 0; x < Count; x++)
                {
                    string User = tw.ReadLine();
                    string Username = User.Substring(0, User.IndexOf(" "));
                    string Password = User.Substring(User.IndexOf(" - ") + 3);
                    if (Password.IndexOf(" ") != -1)
                        Password = Password.Substring(0, Password.IndexOf(" "));
                    if (BotClass.Bots.AddBot(Username, Password, Hotel, (FrmMain)this.MdiParent) == false)
                    {
                        x--;
                    }
                }
            }
            catch
            {
                ReGetFromFile();
            }
            finally
            {
                ReGetFromFile();
            }

        }

        private void cmdFindFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtFileName.Text = openFileDialog1.FileName;
            }
        }

        private void cmdDisconnectSelected_Click(object sender, EventArgs e)
        {
            cmdDisconnectSelected.Enabled = false;
            if (LVBots.SelectedItems.Count == 0)
                return;
            ListView LVTmp = new ListView();
            for (int x = 0; x < LVBots.SelectedItems.Count; x++)
            {
                LVTmp.Items.Add(LVBots.SelectedItems[x].Text);
            }
            for (int x = 0; x < LVTmp.Items.Count; x++)
            {
                BotClass.Bots.GetReference(int.Parse(LVTmp.Items[x].Text)).Disconnect();
            }
            cmdDisconnectSelected.Enabled = true;
        }

        private void cmdBotsMoveForward_Click(object sender, EventArgs e)
        {
            if (WalkRnd == false)
            {
                WalkRnd = true;
                _VoidMethod delRP2 = new _VoidMethod(RandomWalkLoop);
                IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
            }
            else
            {
                WalkRnd = false;
            }
        }
        private void RandomWalkLoop()
        {

            while (WalkRnd == true)
            {
                Random beep = new Random();
                for (int x = 0; x < LVBots.Items.Count; x++)
                {
                    try
                    {
                        BotClass.Bots.GetReference(int.Parse(LVBots.Items[x].Text)).MoveTo(beep.Next(0,70), beep.Next(0,70));
                    }
                    catch { }
                }
                System.Threading.Thread.Sleep(400);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WarpRnd == false)
            {
                WarpRnd = true;
                _VoidMethod delRP2 = new _VoidMethod(RandomWarpLoop);
                IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
            }
            else
            {
                WarpRnd = false;
            }
        }
        private void RandomWarpLoop()
        {

            while (WarpRnd == true)
            {
                for (int x = 0; x < LVBots.Items.Count; x++)
                {
                    try
                    {
                        BotClass.Bots.GetReference(int.Parse(LVBots.Items[x].Text)).WarpTo();
                    }
                    catch { }
                }
                System.Threading.Thread.Sleep(600);
            }
        }
    }
}