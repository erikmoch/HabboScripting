using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using PacketLogger.Classes;

namespace PacketLogger
{
    public partial class wndMain : Form
    {
        // 'Thread-Safe' Delegates
        internal delegate void AddLog(string log);
        internal AddLog _ClientLog;
        internal AddLog _ServerLog;

        internal wndLogin loginForm;

        Thread _CloneThread = new Thread(new ThreadStart(LoopClone));

        public wndMain()
        {
            InitializeComponent();
            this._ClientLog = new AddLog(AddClientLog);
            this._ServerLog = new AddLog(AddServerLog);
        }

        internal void AddClientLog(string log)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(_ClientLog, log);
                }
                else
                {
                    this.txtClientPackets.AppendText(log + "\r\n");
                }
            }
            catch { }
        }

        internal void AddServerLog(string log)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(_ServerLog, log);
                }
                else
                {
                    this.txtServerPackets.AppendText(log + "\r\n");
                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit
            Environment.Exit(0);
        }

        private void cmdClearClient_Click(object sender, EventArgs e)
        {
            txtClientPackets.Text = "";
        }

        private void cmdServerClear_Click(object sender, EventArgs e)
        {
            txtServerPackets.Text = "";
        }

        private void cmdSendToServer_Click(object sender, EventArgs e)
        {
            if (this.chkLoopData.Checked == true)
            {
                if (this.cmdSendToServer.Text == "Send To Server")
                {
                    this.txtData.Enabled = false;
                    this.cmdSendToClient.Enabled = false;
                    this.chkLoopData.Enabled = false;
                    this.cmdSendToServer.Text = "Stop!";
                    this.tmrLoopData.Start();
                }
                else
                {
                    this.txtData.Enabled = true;
                    this.cmdSendToClient.Enabled = true;
                    this.chkLoopData.Enabled = true;
                    this.cmdSendToServer.Text = "Send To Server";
                    this.tmrLoopData.Stop();
                }
            }
            else
            {
                // Just send data normally...
                socketManage.getSocket(0).SendServerHeaders(txtData.Text);
            }
        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new wndLogin(this);
            loginForm.Show();
        }

        private void tmrLoopData_Tick(object sender, EventArgs e)
        {
            socketManage.getSocket(0).SendServerHeaders(txtData.Text);
            Thread.Sleep(20);
        }

        private void cmdSendToClient_Click(object sender, EventArgs e)
        {
            socketManage.getSocket(0).SendClient(txtData.Text);
        }

        private void onTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.onTopToolStripMenuItem.Checked == false)
            {
                this.onTopToolStripMenuItem.Checked = true;
                this.TopMost = true;
            }
            else
            {
                this.onTopToolStripMenuItem.Checked = false;
                this.TopMost = false;
            }
        }

        private void wndMain_Load(object sender, EventArgs e)
        {
            if (this.onTopToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }
        }

        private void wndMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.notifyIcon1.Icon = this.Icon;
                this.notifyIcon1.BalloonTipText = "I'm still here! ;-)\r\nDouble Click to Maximize";
                this.notifyIcon1.BalloonTipTitle = "Minimized To Tray";
                this.notifyIcon1.ShowBalloonTip(500);
                this.notifyIcon1.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.notifyIcon1.Visible = false;
                this.Show();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.TopLevel = true;
            this.Show();
        }

        private void loopCloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loopCloneToolStripMenuItem.Text.ToLower() == "loop clone")
            {
                // Turn on timer
                loopClone1.Start();
                loopCloneToolStripMenuItem.Text = "Stop";
            }
            else
            {
                // Turn off timer
                loopClone1.Stop();
                loopClone2.Stop();
                loopCloneToolStripMenuItem.Text = "Loop Clone";
            }
        }

        private static void LoopClone()
        {
            bool whichState = false;

            if (whichState == false)
            {
                // Enter the room
                socketManage.getSocket(0).SendServerHeaders("AK@R@@");
                whichState = true;
                Thread.Sleep(600);
            }
            else if (whichState == true)
            {
                //socketManage.getSocket(0).SendServerHeaders("AK@R@Z");
                
                whichState = false;
                Thread.Sleep(600);
            }
        }

        private void loopClone1_Tick(object sender, EventArgs e)
        {
            // Send enter room?
            socketManage.getSocket(0).SendServerHeaders("@BAYn{A");
            loopClone2.Start();
            loopClone1.Stop();
        }

        private void loopClone2_Tick(object sender, EventArgs e)
        {
            // Send leave room?
            //socketManage.getSocket(0).SendServerHeaders("AK@R@Z");
            socketManage.getSocket(0).SendServerHeaders("@BAYn{H");
            loopClone1.Start();
            loopClone2.Stop();
        }
    }
}
