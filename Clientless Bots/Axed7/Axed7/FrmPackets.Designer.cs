namespace Axed
{
    partial class FrmPackets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackets));
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.chkLogClient = new System.Windows.Forms.ToolStripButton();
            this.ChkLogServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSendToClient = new System.Windows.Forms.ToolStripButton();
            this.cmdSendToServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdShout = new System.Windows.Forms.ToolStripButton();
            this.cmdSay = new System.Windows.Forms.ToolStripButton();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLog
            // 
            this.TxtLog.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLog.Location = new System.Drawing.Point(0, 0);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLog.Size = new System.Drawing.Size(516, 242);
            this.TxtLog.TabIndex = 0;
            this.TxtLog.WordWrap = false;
            this.TxtLog.TextChanged += new System.EventHandler(this.TxtLog_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkLogClient,
            this.ChkLogServer,
            this.toolStripSeparator1,
            this.cmdSendToClient,
            this.cmdSendToServer,
            this.toolStripSeparator3,
            this.cmdClear,
            this.toolStripSeparator2,
            this.cmdShout,
            this.cmdSay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 323);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(520, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // chkLogClient
            // 
            this.chkLogClient.BackColor = System.Drawing.SystemColors.Control;
            this.chkLogClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkLogClient.CheckOnClick = true;
            this.chkLogClient.Image = ((System.Drawing.Image)(resources.GetObject("chkLogClient.Image")));
            this.chkLogClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkLogClient.Name = "chkLogClient";
            this.chkLogClient.Size = new System.Drawing.Size(53, 22);
            this.chkLogClient.Text = "Clien&t";
            // 
            // ChkLogServer
            // 
            this.ChkLogServer.CheckOnClick = true;
            this.ChkLogServer.Image = ((System.Drawing.Image)(resources.GetObject("ChkLogServer.Image")));
            this.ChkLogServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChkLogServer.Name = "ChkLogServer";
            this.ChkLogServer.Size = new System.Drawing.Size(60, 22);
            this.ChkLogServer.Text = "&Server";
            this.ChkLogServer.Click += new System.EventHandler(this.ChkLogServer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdSendToClient
            // 
            this.cmdSendToClient.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdSendToClient.Image = ((System.Drawing.Image)(resources.GetObject("cmdSendToClient.Image")));
            this.cmdSendToClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSendToClient.Name = "cmdSendToClient";
            this.cmdSendToClient.Size = new System.Drawing.Size(93, 22);
            this.cmdSendToClient.Text = "S&end to Client";
            this.cmdSendToClient.Click += new System.EventHandler(this.cmdSendToClient_Click);
            // 
            // cmdSendToServer
            // 
            this.cmdSendToServer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdSendToServer.Image = ((System.Drawing.Image)(resources.GetObject("cmdSendToServer.Image")));
            this.cmdSendToServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSendToServer.Name = "cmdSendToServer";
            this.cmdSendToServer.Size = new System.Drawing.Size(100, 22);
            this.cmdSendToServer.Text = "Send to Ser&ver";
            this.cmdSendToServer.Click += new System.EventHandler(this.cmdSendToServer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdClear
            // 
            this.cmdClear.Image = ((System.Drawing.Image)(resources.GetObject("cmdClear.Image")));
            this.cmdClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(52, 22);
            this.cmdClear.Text = "&Clear";
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdShout
            // 
            this.cmdShout.Image = ((System.Drawing.Image)(resources.GetObject("cmdShout.Image")));
            this.cmdShout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdShout.Name = "cmdShout";
            this.cmdShout.Size = new System.Drawing.Size(55, 22);
            this.cmdShout.Text = "Shout";
            this.cmdShout.ToolTipText = "Shout The Text";
            this.cmdShout.Click += new System.EventHandler(this.cmdShout_Click);
            // 
            // cmdSay
            // 
            this.cmdSay.Image = ((System.Drawing.Image)(resources.GetObject("cmdSay.Image")));
            this.cmdSay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSay.Name = "cmdSay";
            this.cmdSay.Size = new System.Drawing.Size(46, 22);
            this.cmdSay.Text = "Say";
            this.cmdSay.ToolTipText = "Say To Room";
            this.cmdSay.Click += new System.EventHandler(this.cmdSay_Click);
            // 
            // txtSend
            // 
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSend.Location = new System.Drawing.Point(0, 248);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(520, 75);
            this.txtSend.TabIndex = 2;
            this.txtSend.WordWrap = false;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // FrmPackets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 348);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TxtLog);
            this.Name = "FrmPackets";
            this.Text = "Packet Log";
            this.Load += new System.EventHandler(this.FrmPackets_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPackets_FormClosing);
            this.Resize += new System.EventHandler(this.FrmPackets_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void FrmPackets_Resize(object sender, System.EventArgs e)
        {
            TxtLog.Height = this.Height - 73;
            TxtLog.Width = this.Width - 7;
        }

        void FrmPackets_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion

        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton chkLogClient;
        private System.Windows.Forms.ToolStripButton ChkLogServer;
        private System.Windows.Forms.ToolStripButton cmdClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdSendToClient;
        private System.Windows.Forms.ToolStripButton cmdSendToServer;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cmdShout;
        private System.Windows.Forms.ToolStripButton cmdSay;
    }
}