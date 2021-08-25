namespace Axed
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.uKHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.cmdDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiAFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkOnWaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handToMouthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableTeleportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkIDToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.decodeB64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.packetManipulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAxed7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fgldgfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.quickScriptsToolStripMenuItem,
            this.packetManipulationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(895, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdConnect,
            this.cmdDisconnect,
            this.loginFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fileToolStripMenuItem.Text = " &File";
            // 
            // cmdConnect
            // 
            this.cmdConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdConnect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uKHotelToolStripMenuItem,
            this.customToolStripMenuItem});
            this.cmdConnect.Image = ((System.Drawing.Image)(resources.GetObject("cmdConnect.Image")));
            this.cmdConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(152, 22);
            this.cmdConnect.Text = "&Connect";
            // 
            // uKHotelToolStripMenuItem
            // 
            this.uKHotelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uKHotelToolStripMenuItem.Image")));
            this.uKHotelToolStripMenuItem.Name = "uKHotelToolStripMenuItem";
            this.uKHotelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uKHotelToolStripMenuItem.Text = "&UK Hotel";
            this.uKHotelToolStripMenuItem.Click += new System.EventHandler(this.uKHotelToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiToolStripMenuItem});
            this.customToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customToolStripMenuItem.Image")));
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.fiToolStripMenuItem.Text = ".com";
            this.fiToolStripMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiToolStripMenuItem_KeyPress);
            this.fiToolStripMenuItem.Click += new System.EventHandler(this.fiToolStripMenuItem_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Enabled = false;
            this.cmdDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("cmdDisconnect.Image")));
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(152, 22);
            this.cmdDisconnect.Text = "&Disconnect";
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginFormToolStripMenuItem.Image")));
            this.loginFormToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginFormToolStripMenuItem.Text = "&Login Form";
            this.loginFormToolStripMenuItem.Click += new System.EventHandler(this.loginFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packetLogToolStripMenuItem,
            this.ScriptsToolStripMenuItem,
            this.botManagerToolStripMenuItem});
            this.windowsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("windowsToolStripMenuItem.Image")));
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // packetLogToolStripMenuItem
            // 
            this.packetLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("packetLogToolStripMenuItem.Image")));
            this.packetLogToolStripMenuItem.Name = "packetLogToolStripMenuItem";
            this.packetLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.packetLogToolStripMenuItem.Text = "&Packet Log";
            this.packetLogToolStripMenuItem.Click += new System.EventHandler(this.packetLogToolStripMenuItem_Click);
            // 
            // ScriptsToolStripMenuItem
            // 
            this.ScriptsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ScriptsToolStripMenuItem.Image")));
            this.ScriptsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScriptsToolStripMenuItem.Name = "ScriptsToolStripMenuItem";
            this.ScriptsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ScriptsToolStripMenuItem.Text = "&Scripts";
            this.ScriptsToolStripMenuItem.Click += new System.EventHandler(this.ScriptsToolStripMenuItem_Click);
            // 
            // botManagerToolStripMenuItem
            // 
            this.botManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("botManagerToolStripMenuItem.Image")));
            this.botManagerToolStripMenuItem.Name = "botManagerToolStripMenuItem";
            this.botManagerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.botManagerToolStripMenuItem.Text = "Bot Manager";
            this.botManagerToolStripMenuItem.Click += new System.EventHandler(this.botManagerToolStripMenuItem_Click);
            // 
            // quickScriptsToolStripMenuItem
            // 
            this.quickScriptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiAFKToolStripMenuItem,
            this.walkOnWaterToolStripMenuItem,
            this.handToMouthToolStripMenuItem,
            this.disableTeleportingToolStripMenuItem,
            this.getDrinkToolStripMenuItem,
            this.decodeToolStripMenuItem,
            this.decodeB64ToolStripMenuItem});
            this.quickScriptsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quickScriptsToolStripMenuItem.Image")));
            this.quickScriptsToolStripMenuItem.Name = "quickScriptsToolStripMenuItem";
            this.quickScriptsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quickScriptsToolStripMenuItem.Text = "&Quick Scripts";
            this.quickScriptsToolStripMenuItem.Click += new System.EventHandler(this.quickScriptsToolStripMenuItem_Click);
            // 
            // antiAFKToolStripMenuItem
            // 
            this.antiAFKToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.antiAFKToolStripMenuItem.CheckOnClick = true;
            this.antiAFKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("antiAFKToolStripMenuItem.Image")));
            this.antiAFKToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.antiAFKToolStripMenuItem.Name = "antiAFKToolStripMenuItem";
            this.antiAFKToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.antiAFKToolStripMenuItem.Text = "Anti-AFK";
            this.antiAFKToolStripMenuItem.Click += new System.EventHandler(this.antiAFKToolStripMenuItem_Click);
            // 
            // walkOnWaterToolStripMenuItem
            // 
            this.walkOnWaterToolStripMenuItem.CheckOnClick = true;
            this.walkOnWaterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("walkOnWaterToolStripMenuItem.Image")));
            this.walkOnWaterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.walkOnWaterToolStripMenuItem.Name = "walkOnWaterToolStripMenuItem";
            this.walkOnWaterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.walkOnWaterToolStripMenuItem.Text = "Walk on Water";
            this.walkOnWaterToolStripMenuItem.Click += new System.EventHandler(this.walkOnWaterToolStripMenuItem_Click);
            // 
            // handToMouthToolStripMenuItem
            // 
            this.handToMouthToolStripMenuItem.CheckOnClick = true;
            this.handToMouthToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("handToMouthToolStripMenuItem.Image")));
            this.handToMouthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.handToMouthToolStripMenuItem.Name = "handToMouthToolStripMenuItem";
            this.handToMouthToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.handToMouthToolStripMenuItem.Text = "Hand to mouth";
            this.handToMouthToolStripMenuItem.Click += new System.EventHandler(this.handToMouthToolStripMenuItem_Click);
            // 
            // disableTeleportingToolStripMenuItem
            // 
            this.disableTeleportingToolStripMenuItem.CheckOnClick = true;
            this.disableTeleportingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disableTeleportingToolStripMenuItem.Image")));
            this.disableTeleportingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.disableTeleportingToolStripMenuItem.Name = "disableTeleportingToolStripMenuItem";
            this.disableTeleportingToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.disableTeleportingToolStripMenuItem.Text = "Disable &Teleporting";
            this.disableTeleportingToolStripMenuItem.Click += new System.EventHandler(this.disableTeleportingToolStripMenuItem_Click);
            // 
            // getDrinkToolStripMenuItem
            // 
            this.getDrinkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkIDToolStripMenuItem});
            this.getDrinkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("getDrinkToolStripMenuItem.Image")));
            this.getDrinkToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.getDrinkToolStripMenuItem.Name = "getDrinkToolStripMenuItem";
            this.getDrinkToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.getDrinkToolStripMenuItem.Text = "Get &Drink";
            // 
            // drinkIDToolStripMenuItem
            // 
            this.drinkIDToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.drinkIDToolStripMenuItem.Name = "drinkIDToolStripMenuItem";
            this.drinkIDToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.drinkIDToolStripMenuItem.Text = "10";
            this.drinkIDToolStripMenuItem.TextChanged += new System.EventHandler(this.drinkIDToolStripMenuItem_TextChanged);
            this.drinkIDToolStripMenuItem.Click += new System.EventHandler(this.drinkIDToolStripMenuItem_Click);
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem});
            this.decodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decodeToolStripMenuItem.Image")));
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.decodeToolStripMenuItem.Text = "Decode VL64";
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.hToolStripMenuItem.Text = "H";
            this.hToolStripMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hToolStripMenuItem_KeyPress);
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // decodeB64ToolStripMenuItem
            // 
            this.decodeB64ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.decodeB64ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decodeB64ToolStripMenuItem.Image")));
            this.decodeB64ToolStripMenuItem.Name = "decodeB64ToolStripMenuItem";
            this.decodeB64ToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.decodeB64ToolStripMenuItem.Text = "Decode B64";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 20);
            this.toolStripMenuItem2.Text = "@@";
            this.toolStripMenuItem2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripMenuItem2_KeyPress);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // packetManipulationToolStripMenuItem
            // 
            this.packetManipulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchReplaceToolStripMenuItem});
            this.packetManipulationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("packetManipulationToolStripMenuItem.Image")));
            this.packetManipulationToolStripMenuItem.Name = "packetManipulationToolStripMenuItem";
            this.packetManipulationToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.packetManipulationToolStripMenuItem.Text = "&Manipulation";
            this.packetManipulationToolStripMenuItem.Click += new System.EventHandler(this.packetManipulationToolStripMenuItem_Click);
            // 
            // searchReplaceToolStripMenuItem
            // 
            this.searchReplaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchReplaceToolStripMenuItem.Image")));
            this.searchReplaceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchReplaceToolStripMenuItem.Name = "searchReplaceToolStripMenuItem";
            this.searchReplaceToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.searchReplaceToolStripMenuItem.Text = "&Packet Editor";
            this.searchReplaceToolStripMenuItem.Click += new System.EventHandler(this.searchReplaceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAxed7ToolStripMenuItem,
            this.tutorialsToolStripMenuItem,
            this.fgldgfToolStripMenuItem});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutAxed7ToolStripMenuItem
            // 
            this.aboutAxed7ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutAxed7ToolStripMenuItem.Image")));
            this.aboutAxed7ToolStripMenuItem.Name = "aboutAxed7ToolStripMenuItem";
            this.aboutAxed7ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutAxed7ToolStripMenuItem.Text = "&About Axed 7";
            this.aboutAxed7ToolStripMenuItem.Click += new System.EventHandler(this.aboutAxed7ToolStripMenuItem_Click);
            // 
            // tutorialsToolStripMenuItem
            // 
            this.tutorialsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tutorialsToolStripMenuItem.Image")));
            this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
            this.tutorialsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tutorialsToolStripMenuItem.Text = "&Tutorials";
            this.tutorialsToolStripMenuItem.Click += new System.EventHandler(this.tutorialsToolStripMenuItem_Click);
            // 
            // fgldgfToolStripMenuItem
            // 
            this.fgldgfToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fgldgfToolStripMenuItem.Image")));
            this.fgldgfToolStripMenuItem.Name = "fgldgfToolStripMenuItem";
            this.fgldgfToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fgldgfToolStripMenuItem.Text = "&Update my Look";
            this.fgldgfToolStripMenuItem.Click += new System.EventHandler(this.fgldgfToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status -";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 17);
            this.lblStatus.Text = "Null";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 685);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Axed 7 - Jesus christ how many more?!?!";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void toolStripMenuItem2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                System.Windows.Forms.MessageBox.Show(Jeax.Habbo.Encoding.B64.decode(toolStripMenuItem2.Text).ToString());
            }
        }

        void hToolStripMenuItem_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
                       if (e.KeyChar == '\r')
            {
                System.Windows.Forms.MessageBox.Show(Jeax.Habbo.Encoding.VL64.decode(hToolStripMenuItem.Text).ToString());
            }
        }

        void FrmMain_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        void fiToolStripMenuItem_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cmdConnect.Enabled = false;
                ClsLogin NewLogin = new ClsLogin(LoginScreen.txtUsername.Text, LoginScreen.txtPassword.Text, fiToolStripMenuItem.Text, TheBrowser, this, LoginScreen.txtJSESSIONID.Text);
                cmdDisconnect.Enabled = true;
                LoginScreen.Hide();
            }
        }

        void drinkIDToolStripMenuItem_TextChanged(object sender, System.EventArgs e)
        {
            ConnectionManager.GReference(0).SendToServerAddHeaders("AP" + drinkIDToolStripMenuItem.Text);
        }



        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem loginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiAFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetManipulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkOnWaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handToMouthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAxed7ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem cmdConnect;
        internal System.Windows.Forms.ToolStripMenuItem cmdDisconnect;
        private System.Windows.Forms.ToolStripMenuItem disableTeleportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox drinkIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox fiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fgldgfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeB64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripMenuItem2;

    }
}

