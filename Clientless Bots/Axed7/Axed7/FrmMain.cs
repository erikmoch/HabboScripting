using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Axed
{
    public partial class FrmMain : Form
    {
        FrmBrowser TheBrowser;
        internal FrmLogin LoginScreen = new FrmLogin();
        internal FrmPackets PacketScreen;
        internal FrmSandR SandR;
        internal FrmOtherBrowser UpHabbo = new FrmOtherBrowser();
        FrmPubScripts frmPubScripts = new FrmPubScripts();
        FrmAbout frmAbout = new FrmAbout();
        internal frmScripts frmScripts = new frmScripts();
        FrmTuts frmTutorials = new FrmTuts();
        internal frmBots frmBots = new frmBots();
        public FrmMain()
        {
            InitializeComponent();
        }

        internal void FrmMain_Load(object sender, EventArgs e)
        {
           
            this.Opacity = 0;
            Application.DoEvents();
            this.Show();
            TheBrowser = new FrmBrowser();
            TheBrowser.brHabbo.Navigate("www.ijeax.com/Welcome.html");
            TheBrowser.MdiParent = this;
            frmBots.MdiParent = this;
            TheBrowser.Show();
            LoginScreen.MdiParent = this;
            LoginScreen.Show();
            UpHabbo.MdiParent = this;
            PacketScreen = new FrmPackets(this);
            PacketScreen.MdiParent = this;
            frmScripts.MdiParent = this;
            SandR = new FrmSandR();
            SandR.MdiParent = this;
            frmAbout.MdiParent = this;
            frmPubScripts.MdiParent = this;
            frmTutorials.MdiParent = this;
            FadeIn(90);
        }
        private void FrmMain_Unload(object sender, EventArgs e)
        {
            FadeOut(90);
            Environment.Exit(0);
        }
        private void FadeIn(int SleepTime)
        {
            for (double x = 0; x < 1.0; x = x + 0.1)
            {
                this.Opacity = x;
                Application.DoEvents();
                System.Threading.Thread.Sleep(SleepTime);
            }
        }
        private void FadeOut(int SleepTime)
        {
            for (double x = 1.0; x > 0.0; x = x - 0.1)
            {
                this.Opacity = x;
                Application.DoEvents();
                System.Threading.Thread.Sleep(SleepTime);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Environment.Exit(2);
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uKHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginScreen == null)
            {
                LoginScreen = new FrmLogin();
                LoginScreen.MdiParent = this;
                LoginScreen.Show();
                return;
            }
            cmdConnect.Enabled = false;
            ClsLogin NewLogin = new ClsLogin(LoginScreen.txtUsername.Text, LoginScreen.txtPassword.Text, ".co.uk", TheBrowser,this,LoginScreen.txtJSESSIONID.Text);
            cmdDisconnect.Enabled = true;
            LoginScreen.Hide();
          
        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen.Show();
            LoginScreen.Focus();
        }

        private void packetLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketScreen.Show();
            PacketScreen.Focus();
        }

        private void wineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("AP24");
        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            TheBrowser.brHabbo.Navigate("www.ijeax.com/Welcome.html");
            cmdDisconnect.Enabled = false;
            cmdConnect.Enabled = true;
            //ConnectionManager.GReference(0).DropConnection();
        }

        private void antiAFKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (antiAFKToolStripMenuItem.Checked == true)
            {
                antiAFKToolStripMenuItem.Image = Resource1.bullet_done;
                AntiAFK();
            }
            else
            {
                antiAFKToolStripMenuItem.Image = Resource1.bullet_notdone;
            }
        }
        private delegate void RunSepThread();
        private void AAFK()
        {
            while (antiAFKToolStripMenuItem.Checked == true)
            {
                ConnectionManager.GReference(0).SendToServer("@@O@x@K Anti-Sleep");
                System.Threading.Thread.Sleep(60000 * 5);
            }
        }
        private void WalkonWater()
        {
            while (walkOnWaterToolStripMenuItem.Checked == true)
            {
                ConnectionManager.GReference(0).SendToServerAddHeaders("AXSwim");
                System.Threading.Thread.Sleep(500);
            }
        }
        private void AntiAFK()
        {
            RunSepThread delRP2 = new RunSepThread(AAFK);
            IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
        }

        private void packetManipulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SandR.Show();
            SandR.Focus();
        }

        private void walkOnWaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (walkOnWaterToolStripMenuItem.Checked == true)
            {
                RunSepThread delRP2 = new RunSepThread(WalkonWater);
                IAsyncResult tag2 = delRP2.BeginInvoke(null, null);
                walkOnWaterToolStripMenuItem.Image = Resource1.bullet_done;
            }
            else
                walkOnWaterToolStripMenuItem.Image = Resource1.bullet_notdone;

        }

        private void handToMouthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (handToMouthToolStripMenuItem.Checked == true)
            {
                ConnectionManager.GReference(0).SendToServerAddHeaders("AY23" + Convert.ToChar(9) + "99999999");
                handToMouthToolStripMenuItem.Image = Resource1.bullet_done;
            }
            else
            {
                ConnectionManager.GReference(0).SendToServerAddHeaders("AY23" + Convert.ToChar(9) + "1");
                handToMouthToolStripMenuItem.Image = Resource1.bullet_notdone;
            }
        }

        private void quickScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutAxed7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout.Show();
            frmAbout.Focus();
        }


        private void publicRoomScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPubScripts.Show();
            frmPubScripts.Focus();
        }

        private void scriptMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void disableTeleportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableTeleportingToolStripMenuItem.Checked == true)
            {
                ConnectionManager.GReference(0).DisableTeleporting = true;
                disableTeleportingToolStripMenuItem.Image = Resource1.bullet_done;
            }
            else
            {
                ConnectionManager.GReference(0).DisableTeleporting = false;
                disableTeleportingToolStripMenuItem.Image = Resource1.bullet_notdone;
            }
        }

        private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorials.Show();
            frmTutorials.Focus();
        }

        private void drinkIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fgldgfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpHabbo.Show();
            UpHabbo.Focus();
        }

        private void ScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScripts.Show();
        }

        private void botManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBots.Show();
        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void fiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }






    }
}