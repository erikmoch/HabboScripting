using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axed
{
    public partial class FrmPackets : Form
    {
        public delegate void ADbg(string Text);
        public ADbg _ClientLog;
        public ADbg _ServerLog;
        private FrmMain Main;
        public FrmPackets(FrmMain Main)
        {
            _ClientLog = new ADbg(AddToClientLog);
            _ServerLog = new ADbg(AddToServerLog);
            this.Main = Main;
            InitializeComponent();
        }

        private void TxtLog_TextChanged(object sender, EventArgs e)
        {

        }

        internal void AddToClientLog(string TheText)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(_ClientLog, TheText); }
                else
                {
                    TheText = TheText.Replace("\r", "\r\n");
                    if (chkLogClient.Checked == true)
                        TxtLog.AppendText("Client -- " + TheText + "\r\n");
                }
            }
            catch
            {
            }
        }
        internal void AddToServerLog(string TheText)
        {
            try
            {
                if (this.InvokeRequired)
                { this.Invoke(_ServerLog, TheText); }
                else
                {
                    TheText = TheText.Replace("\r", "\r\n");
                    if (ChkLogServer.Checked == true)
                        TxtLog.AppendText("Server -- " + TheText + "\r\n");
                }
            }
            catch
            {
            }
        }
        internal void ClearLog()
        {
            TxtLog.Clear();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            ClearLog();
        }

        private void FrmPackets_Load(object sender, EventArgs e)
        {

        }

        private void ChkLogServer_Click(object sender, EventArgs e)
        {

        }

        private void cmdSendToClient_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToClient(txtSend.Text);
        }

        private void cmdSendToServer_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders(txtSend.Text);
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEncodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSend.Text = "@" + Jeax.Habbo.Encoding.B64.encode(txtSend.Text) + txtSend.Text;
        }

        private void cmdShout_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("@w" + Jeax.Habbo.Encoding.B64.encode(txtSend.Text) + txtSend.Text);
        }

        private void cmdSay_Click(object sender, EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("@t" + Jeax.Habbo.Encoding.B64.encode(txtSend.Text) + txtSend.Text);
        }
    }
}