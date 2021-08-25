namespace PacketLogger
{
    partial class wndMain
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdServerClear = new System.Windows.Forms.Button();
            this.chkServerPause = new System.Windows.Forms.CheckBox();
            this.txtServerPackets = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkClientPause = new System.Windows.Forms.CheckBox();
            this.cmdClearClient = new System.Windows.Forms.Button();
            this.txtClientPackets = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkLoopData = new System.Windows.Forms.CheckBox();
            this.cmdSendToClient = new System.Windows.Forms.Button();
            this.cmdSendToServer = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.tmrLoopData = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.loopClone1 = new System.Windows.Forms.Timer(this.components);
            this.loopClone2 = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.tmpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(621, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFormToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loginFormToolStripMenuItem.Text = "Login Form";
            this.loginFormToolStripMenuItem.Click += new System.EventHandler(this.loginFormToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onTopToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // onTopToolStripMenuItem
            // 
            this.onTopToolStripMenuItem.Name = "onTopToolStripMenuItem";
            this.onTopToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.onTopToolStripMenuItem.Text = "On-Top";
            this.onTopToolStripMenuItem.Click += new System.EventHandler(this.onTopToolStripMenuItem_Click);
            // 
            // tmpToolStripMenuItem
            // 
            this.tmpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loopCloneToolStripMenuItem});
            this.tmpToolStripMenuItem.Name = "tmpToolStripMenuItem";
            this.tmpToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.tmpToolStripMenuItem.Text = "Tmp";
            // 
            // loopCloneToolStripMenuItem
            // 
            this.loopCloneToolStripMenuItem.Name = "loopCloneToolStripMenuItem";
            this.loopCloneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loopCloneToolStripMenuItem.Text = "Loop Clone";
            this.loopCloneToolStripMenuItem.Click += new System.EventHandler(this.loopCloneToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdServerClear);
            this.groupBox1.Controls.Add(this.chkServerPause);
            this.groupBox1.Controls.Add(this.txtServerPackets);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Packets";
            // 
            // cmdServerClear
            // 
            this.cmdServerClear.Location = new System.Drawing.Point(188, 311);
            this.cmdServerClear.Name = "cmdServerClear";
            this.cmdServerClear.Size = new System.Drawing.Size(104, 23);
            this.cmdServerClear.TabIndex = 2;
            this.cmdServerClear.Text = "Clear";
            this.cmdServerClear.UseVisualStyleBackColor = true;
            this.cmdServerClear.Click += new System.EventHandler(this.cmdServerClear_Click);
            // 
            // chkServerPause
            // 
            this.chkServerPause.AutoSize = true;
            this.chkServerPause.Location = new System.Drawing.Point(6, 316);
            this.chkServerPause.Name = "chkServerPause";
            this.chkServerPause.Size = new System.Drawing.Size(54, 15);
            this.chkServerPause.TabIndex = 1;
            this.chkServerPause.Text = "Pause";
            this.chkServerPause.UseVisualStyleBackColor = true;
            // 
            // txtServerPackets
            // 
            this.txtServerPackets.BackColor = System.Drawing.Color.White;
            this.txtServerPackets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPackets.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerPackets.Location = new System.Drawing.Point(6, 17);
            this.txtServerPackets.Multiline = true;
            this.txtServerPackets.Name = "txtServerPackets";
            this.txtServerPackets.ReadOnly = true;
            this.txtServerPackets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerPackets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerPackets.Size = new System.Drawing.Size(286, 293);
            this.txtServerPackets.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkClientPause);
            this.groupBox2.Controls.Add(this.cmdClearClient);
            this.groupBox2.Controls.Add(this.txtClientPackets);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(316, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Packets";
            // 
            // chkClientPause
            // 
            this.chkClientPause.AutoSize = true;
            this.chkClientPause.Location = new System.Drawing.Point(6, 316);
            this.chkClientPause.Name = "chkClientPause";
            this.chkClientPause.Size = new System.Drawing.Size(54, 15);
            this.chkClientPause.TabIndex = 2;
            this.chkClientPause.Text = "Pause";
            this.chkClientPause.UseVisualStyleBackColor = true;
            // 
            // cmdClearClient
            // 
            this.cmdClearClient.Location = new System.Drawing.Point(188, 311);
            this.cmdClearClient.Name = "cmdClearClient";
            this.cmdClearClient.Size = new System.Drawing.Size(104, 23);
            this.cmdClearClient.TabIndex = 1;
            this.cmdClearClient.Text = "Clear";
            this.cmdClearClient.UseVisualStyleBackColor = true;
            this.cmdClearClient.Click += new System.EventHandler(this.cmdClearClient_Click);
            // 
            // txtClientPackets
            // 
            this.txtClientPackets.BackColor = System.Drawing.Color.White;
            this.txtClientPackets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientPackets.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPackets.Location = new System.Drawing.Point(6, 17);
            this.txtClientPackets.Multiline = true;
            this.txtClientPackets.Name = "txtClientPackets";
            this.txtClientPackets.ReadOnly = true;
            this.txtClientPackets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClientPackets.Size = new System.Drawing.Size(286, 293);
            this.txtClientPackets.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLoopData);
            this.groupBox3.Controls.Add(this.cmdSendToClient);
            this.groupBox3.Controls.Add(this.cmdSendToServer);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // chkLoopData
            // 
            this.chkLoopData.AutoSize = true;
            this.chkLoopData.Location = new System.Drawing.Point(6, 76);
            this.chkLoopData.Name = "chkLoopData";
            this.chkLoopData.Size = new System.Drawing.Size(74, 15);
            this.chkLoopData.TabIndex = 3;
            this.chkLoopData.Text = "Loop Data";
            this.chkLoopData.UseVisualStyleBackColor = true;
            // 
            // cmdSendToClient
            // 
            this.cmdSendToClient.Location = new System.Drawing.Point(381, 71);
            this.cmdSendToClient.Name = "cmdSendToClient";
            this.cmdSendToClient.Size = new System.Drawing.Size(105, 23);
            this.cmdSendToClient.TabIndex = 2;
            this.cmdSendToClient.Text = "Send To Client";
            this.cmdSendToClient.UseVisualStyleBackColor = true;
            this.cmdSendToClient.Click += new System.EventHandler(this.cmdSendToClient_Click);
            // 
            // cmdSendToServer
            // 
            this.cmdSendToServer.Location = new System.Drawing.Point(492, 71);
            this.cmdSendToServer.Name = "cmdSendToServer";
            this.cmdSendToServer.Size = new System.Drawing.Size(104, 23);
            this.cmdSendToServer.TabIndex = 1;
            this.cmdSendToServer.Text = "Send To Server";
            this.cmdSendToServer.UseVisualStyleBackColor = true;
            this.cmdSendToServer.Click += new System.EventHandler(this.cmdSendToServer_Click);
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(6, 17);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(590, 51);
            this.txtData.TabIndex = 0;
            // 
            // tmrLoopData
            // 
            this.tmrLoopData.Interval = 600;
            this.tmrLoopData.Tick += new System.EventHandler(this.tmrLoopData_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // loopClone1
            // 
            this.loopClone1.Interval = 600;
            this.loopClone1.Tick += new System.EventHandler(this.loopClone1_Tick);
            // 
            // loopClone2
            // 
            this.loopClone2.Interval = 600;
            this.loopClone2.Tick += new System.EventHandler(this.loopClone2_Tick);
            // 
            // wndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "wndMain";
            this.Text = "Encryption Client  ::  http://script-o-matic.net";
            this.Load += new System.EventHandler(this.wndMain_Load);
            this.Resize += new System.EventHandler(this.wndMain_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onTopToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdServerClear;
        internal System.Windows.Forms.TextBox txtServerPackets;
        private System.Windows.Forms.Button cmdClearClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkLoopData;
        private System.Windows.Forms.Button cmdSendToClient;
        private System.Windows.Forms.Button cmdSendToServer;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Timer tmrLoopData;
        internal System.Windows.Forms.CheckBox chkServerPause;
        internal System.Windows.Forms.CheckBox chkClientPause;
        internal System.Windows.Forms.TextBox txtClientPackets;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem tmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopCloneToolStripMenuItem;
        private System.Windows.Forms.Timer loopClone1;
        private System.Windows.Forms.Timer loopClone2;
    }
}

