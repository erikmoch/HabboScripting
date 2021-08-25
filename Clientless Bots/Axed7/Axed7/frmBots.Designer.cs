namespace Axed
{
    partial class frmBots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBots));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlUserList = new System.Windows.Forms.Panel();
            this.LVBots = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.pnlAddBots = new System.Windows.Forms.Panel();
            this.cmdDisconnectSelected = new System.Windows.Forms.Button();
            this.cmdFindFile = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.nmSkipAccs = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdBotsFromFile = new System.Windows.Forms.Button();
            this.nmAmAccounts = new System.Windows.Forms.NumericUpDown();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAddNewBot = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRoomLoading = new System.Windows.Forms.Panel();
            this.chkSetToRoomID = new System.Windows.Forms.CheckBox();
            this.chkAutoReload = new System.Windows.Forms.CheckBox();
            this.chkPublicRoom = new System.Windows.Forms.CheckBox();
            this.txtRoomPart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSendToRoom = new System.Windows.Forms.Button();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdBotsMoveForward = new System.Windows.Forms.Button();
            this.nmResetAtY = new System.Windows.Forms.NumericUpDown();
            this.nmResetAtX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.chkMoveToOnLoad = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdShout = new System.Windows.Forms.Button();
            this.txtFunctions = new System.Windows.Forms.TextBox();
            this.txtAddtoY = new System.Windows.Forms.NumericUpDown();
            this.txtAddtoX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYCord = new System.Windows.Forms.NumericUpDown();
            this.txtXCord = new System.Windows.Forms.NumericUpDown();
            this.cmdWalkTo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.pnlUserList.SuspendLayout();
            this.pnlAddBots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSkipAccs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmAccounts)).BeginInit();
            this.pnlRoomLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomID)).BeginInit();
            this.pnlFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmResetAtY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResetAtX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddtoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddtoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYCord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXCord)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 37);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 34);
            this.toolStripButton1.Text = "Bot Managment";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(88, 34);
            this.toolStripButton3.Text = "Room Functions";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 34);
            this.toolStripButton2.Text = "Bot Functions";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pnlUserList
            // 
            this.pnlUserList.Controls.Add(this.LVBots);
            this.pnlUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserList.Location = new System.Drawing.Point(0, 37);
            this.pnlUserList.Name = "pnlUserList";
            this.pnlUserList.Size = new System.Drawing.Size(741, 170);
            this.pnlUserList.TabIndex = 11;
            // 
            // LVBots
            // 
            this.LVBots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVBots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LVBots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVBots.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVBots.FullRowSelect = true;
            this.LVBots.GridLines = true;
            this.LVBots.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LVBots.HideSelection = false;
            this.LVBots.Location = new System.Drawing.Point(0, 0);
            this.LVBots.Name = "LVBots";
            this.LVBots.Size = new System.Drawing.Size(741, 170);
            this.LVBots.TabIndex = 20;
            this.LVBots.UseCompatibleStateImageBehavior = false;
            this.LVBots.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reference ID";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 168;
            // 
            // pnlAddBots
            // 
            this.pnlAddBots.Controls.Add(this.cmdDisconnectSelected);
            this.pnlAddBots.Controls.Add(this.cmdFindFile);
            this.pnlAddBots.Controls.Add(this.label11);
            this.pnlAddBots.Controls.Add(this.nmSkipAccs);
            this.pnlAddBots.Controls.Add(this.label10);
            this.pnlAddBots.Controls.Add(this.cmdBotsFromFile);
            this.pnlAddBots.Controls.Add(this.nmAmAccounts);
            this.pnlAddBots.Controls.Add(this.TxtFileName);
            this.pnlAddBots.Controls.Add(this.label9);
            this.pnlAddBots.Controls.Add(this.txtHotel);
            this.pnlAddBots.Controls.Add(this.label3);
            this.pnlAddBots.Controls.Add(this.cmdAddNewBot);
            this.pnlAddBots.Controls.Add(this.txtPassword);
            this.pnlAddBots.Controls.Add(this.txtUsername);
            this.pnlAddBots.Controls.Add(this.label2);
            this.pnlAddBots.Controls.Add(this.label1);
            this.pnlAddBots.Location = new System.Drawing.Point(359, 213);
            this.pnlAddBots.Name = "pnlAddBots";
            this.pnlAddBots.Size = new System.Drawing.Size(434, 274);
            this.pnlAddBots.TabIndex = 12;
            this.pnlAddBots.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddBots_Paint);
            // 
            // cmdDisconnectSelected
            // 
            this.cmdDisconnectSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDisconnectSelected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDisconnectSelected.Image = ((System.Drawing.Image)(resources.GetObject("cmdDisconnectSelected.Image")));
            this.cmdDisconnectSelected.Location = new System.Drawing.Point(15, 84);
            this.cmdDisconnectSelected.Name = "cmdDisconnectSelected";
            this.cmdDisconnectSelected.Size = new System.Drawing.Size(187, 38);
            this.cmdDisconnectSelected.TabIndex = 29;
            this.cmdDisconnectSelected.Text = "Remove Selected Bot(s)";
            this.cmdDisconnectSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDisconnectSelected.UseVisualStyleBackColor = true;
            this.cmdDisconnectSelected.Click += new System.EventHandler(this.cmdDisconnectSelected_Click);
            // 
            // cmdFindFile
            // 
            this.cmdFindFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFindFile.Image = ((System.Drawing.Image)(resources.GetObject("cmdFindFile.Image")));
            this.cmdFindFile.Location = new System.Drawing.Point(360, 134);
            this.cmdFindFile.Name = "cmdFindFile";
            this.cmdFindFile.Size = new System.Drawing.Size(64, 22);
            this.cmdFindFile.TabIndex = 28;
            this.cmdFindFile.UseVisualStyleBackColor = true;
            this.cmdFindFile.Click += new System.EventHandler(this.cmdFindFile_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Skip First * Accounts:";
            // 
            // nmSkipAccs
            // 
            this.nmSkipAccs.Location = new System.Drawing.Point(129, 188);
            this.nmSkipAccs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmSkipAccs.Name = "nmSkipAccs";
            this.nmSkipAccs.Size = new System.Drawing.Size(297, 20);
            this.nmSkipAccs.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Amount To Load:";
            // 
            // cmdBotsFromFile
            // 
            this.cmdBotsFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBotsFromFile.Image = ((System.Drawing.Image)(resources.GetObject("cmdBotsFromFile.Image")));
            this.cmdBotsFromFile.Location = new System.Drawing.Point(15, 224);
            this.cmdBotsFromFile.Name = "cmdBotsFromFile";
            this.cmdBotsFromFile.Size = new System.Drawing.Size(410, 39);
            this.cmdBotsFromFile.TabIndex = 24;
            this.cmdBotsFromFile.Text = "Load Bots From File";
            this.cmdBotsFromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBotsFromFile.UseVisualStyleBackColor = true;
            this.cmdBotsFromFile.Click += new System.EventHandler(this.cmdBotsFromFile_Click);
            // 
            // nmAmAccounts
            // 
            this.nmAmAccounts.Location = new System.Drawing.Point(107, 162);
            this.nmAmAccounts.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmAmAccounts.Name = "nmAmAccounts";
            this.nmAmAccounts.Size = new System.Drawing.Size(318, 20);
            this.nmAmAccounts.TabIndex = 23;
            this.nmAmAccounts.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TxtFileName
            // 
            this.TxtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFileName.Location = new System.Drawing.Point(98, 136);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(256, 20);
            this.TxtFileName.TabIndex = 22;
            this.TxtFileName.Text = "./All.Txt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Load From File:";
            // 
            // txtHotel
            // 
            this.txtHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotel.Location = new System.Drawing.Point(54, 57);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(371, 21);
            this.txtHotel.TabIndex = 20;
            this.txtHotel.Text = ".co.uk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hotel:";
            // 
            // cmdAddNewBot
            // 
            this.cmdAddNewBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddNewBot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddNewBot.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddNewBot.Image")));
            this.cmdAddNewBot.Location = new System.Drawing.Point(208, 84);
            this.cmdAddNewBot.Name = "cmdAddNewBot";
            this.cmdAddNewBot.Size = new System.Drawing.Size(216, 38);
            this.cmdAddNewBot.TabIndex = 18;
            this.cmdAddNewBot.Text = "Add New Bot";
            this.cmdAddNewBot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAddNewBot.UseVisualStyleBackColor = true;
            this.cmdAddNewBot.Click += new System.EventHandler(this.cmdAddNewBot_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(79, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(347, 21);
            this.txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(79, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(347, 21);
            this.txtUsername.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username:";
            // 
            // pnlRoomLoading
            // 
            this.pnlRoomLoading.Controls.Add(this.chkSetToRoomID);
            this.pnlRoomLoading.Controls.Add(this.chkAutoReload);
            this.pnlRoomLoading.Controls.Add(this.chkPublicRoom);
            this.pnlRoomLoading.Controls.Add(this.txtRoomPart);
            this.pnlRoomLoading.Controls.Add(this.label5);
            this.pnlRoomLoading.Controls.Add(this.txtRoomID);
            this.pnlRoomLoading.Controls.Add(this.label4);
            this.pnlRoomLoading.Controls.Add(this.cmdSendToRoom);
            this.pnlRoomLoading.Location = new System.Drawing.Point(26, 403);
            this.pnlRoomLoading.Name = "pnlRoomLoading";
            this.pnlRoomLoading.Size = new System.Drawing.Size(434, 140);
            this.pnlRoomLoading.TabIndex = 21;
            // 
            // chkSetToRoomID
            // 
            this.chkSetToRoomID.AutoSize = true;
            this.chkSetToRoomID.Checked = true;
            this.chkSetToRoomID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetToRoomID.Location = new System.Drawing.Point(15, 61);
            this.chkSetToRoomID.Name = "chkSetToRoomID";
            this.chkSetToRoomID.Size = new System.Drawing.Size(190, 17);
            this.chkSetToRoomID.TabIndex = 27;
            this.chkSetToRoomID.Text = "Auto Set To Last/Current Room ID";
            this.chkSetToRoomID.UseVisualStyleBackColor = true;
            // 
            // chkAutoReload
            // 
            this.chkAutoReload.AutoSize = true;
            this.chkAutoReload.Checked = true;
            this.chkAutoReload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoReload.Location = new System.Drawing.Point(208, 61);
            this.chkAutoReload.Name = "chkAutoReload";
            this.chkAutoReload.Size = new System.Drawing.Size(126, 17);
            this.chkAutoReload.TabIndex = 26;
            this.chkAutoReload.Text = "Auto Reload On Kick";
            this.chkAutoReload.UseVisualStyleBackColor = true;
            // 
            // chkPublicRoom
            // 
            this.chkPublicRoom.AutoSize = true;
            this.chkPublicRoom.Location = new System.Drawing.Point(340, 61);
            this.chkPublicRoom.Name = "chkPublicRoom";
            this.chkPublicRoom.Size = new System.Drawing.Size(86, 17);
            this.chkPublicRoom.TabIndex = 25;
            this.chkPublicRoom.Text = "Public Room";
            this.chkPublicRoom.UseVisualStyleBackColor = true;
            // 
            // txtRoomPart
            // 
            this.txtRoomPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomPart.Hexadecimal = true;
            this.txtRoomPart.Location = new System.Drawing.Point(70, 35);
            this.txtRoomPart.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtRoomPart.Name = "txtRoomPart";
            this.txtRoomPart.Size = new System.Drawing.Size(355, 20);
            this.txtRoomPart.TabIndex = 24;
            this.txtRoomPart.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Room Part:";
            // 
            // txtRoomID
            // 
            this.txtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomID.Location = new System.Drawing.Point(70, 8);
            this.txtRoomID.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtRoomID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(355, 20);
            this.txtRoomID.TabIndex = 22;
            this.txtRoomID.Value = new decimal(new int[] {
            20004848,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Room ID:";
            // 
            // cmdSendToRoom
            // 
            this.cmdSendToRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSendToRoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSendToRoom.Image = ((System.Drawing.Image)(resources.GetObject("cmdSendToRoom.Image")));
            this.cmdSendToRoom.Location = new System.Drawing.Point(15, 88);
            this.cmdSendToRoom.Name = "cmdSendToRoom";
            this.cmdSendToRoom.Size = new System.Drawing.Size(414, 40);
            this.cmdSendToRoom.TabIndex = 18;
            this.cmdSendToRoom.Text = "Send Selected Bot(s) To Room";
            this.cmdSendToRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSendToRoom.UseVisualStyleBackColor = true;
            this.cmdSendToRoom.Click += new System.EventHandler(this.cmdSendToRoom_Click);
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.Controls.Add(this.button3);
            this.pnlFunctions.Controls.Add(this.cmdBotsMoveForward);
            this.pnlFunctions.Controls.Add(this.nmResetAtY);
            this.pnlFunctions.Controls.Add(this.nmResetAtX);
            this.pnlFunctions.Controls.Add(this.label13);
            this.pnlFunctions.Controls.Add(this.chkMoveToOnLoad);
            this.pnlFunctions.Controls.Add(this.button2);
            this.pnlFunctions.Controls.Add(this.button1);
            this.pnlFunctions.Controls.Add(this.cmdShout);
            this.pnlFunctions.Controls.Add(this.txtFunctions);
            this.pnlFunctions.Controls.Add(this.txtAddtoY);
            this.pnlFunctions.Controls.Add(this.txtAddtoX);
            this.pnlFunctions.Controls.Add(this.label8);
            this.pnlFunctions.Controls.Add(this.txtYCord);
            this.pnlFunctions.Controls.Add(this.txtXCord);
            this.pnlFunctions.Controls.Add(this.cmdWalkTo);
            this.pnlFunctions.Controls.Add(this.label7);
            this.pnlFunctions.Controls.Add(this.label6);
            this.pnlFunctions.Location = new System.Drawing.Point(12, 216);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(581, 174);
            this.pnlFunctions.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(184, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Bot(s) Auto Loop Warp";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdBotsMoveForward
            // 
            this.cmdBotsMoveForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBotsMoveForward.Image = ((System.Drawing.Image)(resources.GetObject("cmdBotsMoveForward.Image")));
            this.cmdBotsMoveForward.Location = new System.Drawing.Point(17, 133);
            this.cmdBotsMoveForward.Name = "cmdBotsMoveForward";
            this.cmdBotsMoveForward.Size = new System.Drawing.Size(148, 29);
            this.cmdBotsMoveForward.TabIndex = 19;
            this.cmdBotsMoveForward.Text = "Bot(s) Loop Movement";
            this.cmdBotsMoveForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBotsMoveForward.UseVisualStyleBackColor = true;
            this.cmdBotsMoveForward.Click += new System.EventHandler(this.cmdBotsMoveForward_Click);
            // 
            // nmResetAtY
            // 
            this.nmResetAtY.Location = new System.Drawing.Point(500, 29);
            this.nmResetAtY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmResetAtY.Name = "nmResetAtY";
            this.nmResetAtY.Size = new System.Drawing.Size(68, 20);
            this.nmResetAtY.TabIndex = 18;
            // 
            // nmResetAtX
            // 
            this.nmResetAtX.Location = new System.Drawing.Point(426, 29);
            this.nmResetAtX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmResetAtX.Name = "nmResetAtX";
            this.nmResetAtX.Size = new System.Drawing.Size(68, 20);
            this.nmResetAtX.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(423, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "When Y = 0:";
            // 
            // chkMoveToOnLoad
            // 
            this.chkMoveToOnLoad.AutoSize = true;
            this.chkMoveToOnLoad.Location = new System.Drawing.Point(421, 52);
            this.chkMoveToOnLoad.Name = "chkMoveToOnLoad";
            this.chkMoveToOnLoad.Size = new System.Drawing.Size(147, 17);
            this.chkMoveToOnLoad.TabIndex = 14;
            this.chkMoveToOnLoad.Text = "Move To On Room_Load";
            this.chkMoveToOnLoad.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(171, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Figure Update";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(308, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Bot(s) Send Packet";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdShout
            // 
            this.cmdShout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShout.Image = ((System.Drawing.Image)(resources.GetObject("cmdShout.Image")));
            this.cmdShout.Location = new System.Drawing.Point(445, 133);
            this.cmdShout.Name = "cmdShout";
            this.cmdShout.Size = new System.Drawing.Size(124, 29);
            this.cmdShout.TabIndex = 11;
            this.cmdShout.Text = "Bot(s) Shout";
            this.cmdShout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdShout.UseVisualStyleBackColor = true;
            this.cmdShout.Click += new System.EventHandler(this.cmdShout_Click);
            // 
            // txtFunctions
            // 
            this.txtFunctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunctions.Location = new System.Drawing.Point(17, 101);
            this.txtFunctions.Multiline = true;
            this.txtFunctions.Name = "txtFunctions";
            this.txtFunctions.Size = new System.Drawing.Size(551, 30);
            this.txtFunctions.TabIndex = 10;
            this.txtFunctions.Text = "Jeax Rules!";
            // 
            // txtAddtoY
            // 
            this.txtAddtoY.Location = new System.Drawing.Point(347, 29);
            this.txtAddtoY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtAddtoY.Name = "txtAddtoY";
            this.txtAddtoY.Size = new System.Drawing.Size(68, 20);
            this.txtAddtoY.TabIndex = 9;
            // 
            // txtAddtoX
            // 
            this.txtAddtoX.Location = new System.Drawing.Point(273, 29);
            this.txtAddtoX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtAddtoX.Name = "txtAddtoX";
            this.txtAddtoX.Size = new System.Drawing.Size(68, 20);
            this.txtAddtoX.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Add to X/Y Per Movement";
            // 
            // txtYCord
            // 
            this.txtYCord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYCord.Location = new System.Drawing.Point(142, 31);
            this.txtYCord.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtYCord.Name = "txtYCord";
            this.txtYCord.Size = new System.Drawing.Size(119, 20);
            this.txtYCord.TabIndex = 6;
            this.txtYCord.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtXCord
            // 
            this.txtXCord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXCord.Location = new System.Drawing.Point(17, 30);
            this.txtXCord.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtXCord.Name = "txtXCord";
            this.txtXCord.Size = new System.Drawing.Size(119, 20);
            this.txtXCord.TabIndex = 5;
            this.txtXCord.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmdWalkTo
            // 
            this.cmdWalkTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdWalkTo.Image = ((System.Drawing.Image)(resources.GetObject("cmdWalkTo.Image")));
            this.cmdWalkTo.Location = new System.Drawing.Point(17, 69);
            this.cmdWalkTo.Name = "cmdWalkTo";
            this.cmdWalkTo.Size = new System.Drawing.Size(161, 26);
            this.cmdWalkTo.TabIndex = 4;
            this.cmdWalkTo.Text = "Send Bot(s) To Cord(s)";
            this.cmdWalkTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdWalkTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdWalkTo.UseVisualStyleBackColor = true;
            this.cmdWalkTo.Click += new System.EventHandler(this.cmdWalkTo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y Cord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X Cord";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Axed Userlists|*.aX|Text Files|*.txt|All Files|*.*";
            this.openFileDialog1.InitialDirectory = "./";
            // 
            // frmBots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 548);
            this.Controls.Add(this.pnlFunctions);
            this.Controls.Add(this.pnlRoomLoading);
            this.Controls.Add(this.pnlAddBots);
            this.Controls.Add(this.pnlUserList);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmBots";
            this.Text = "Bot Manager";
            this.Load += new System.EventHandler(this.frmBots_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBots_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlUserList.ResumeLayout(false);
            this.pnlAddBots.ResumeLayout(false);
            this.pnlAddBots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSkipAccs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmAccounts)).EndInit();
            this.pnlRoomLoading.ResumeLayout(false);
            this.pnlRoomLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomID)).EndInit();
            this.pnlFunctions.ResumeLayout(false);
            this.pnlFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmResetAtY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResetAtX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddtoY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddtoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYCord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXCord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void frmBots_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnlUserList;
        private System.Windows.Forms.ListView LVBots;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnlAddBots;
        private System.Windows.Forms.Button cmdAddNewBot;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel pnlRoomLoading;
        private System.Windows.Forms.Button cmdSendToRoom;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFunctions;
        private System.Windows.Forms.Button cmdWalkTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtAddtoX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtAddtoY;
        private System.Windows.Forms.Button cmdShout;
        private System.Windows.Forms.TextBox txtFunctions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmSkipAccs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdBotsFromFile;
        private System.Windows.Forms.NumericUpDown nmAmAccounts;
        private System.Windows.Forms.Button cmdFindFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdDisconnectSelected;
        internal System.Windows.Forms.CheckBox chkAutoReload;
        private System.Windows.Forms.NumericUpDown nmResetAtY;
        private System.Windows.Forms.NumericUpDown nmResetAtX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdBotsMoveForward;
        internal System.Windows.Forms.CheckBox chkMoveToOnLoad;
        internal System.Windows.Forms.NumericUpDown txtYCord;
        internal System.Windows.Forms.NumericUpDown txtXCord;
        internal System.Windows.Forms.CheckBox chkSetToRoomID;
        internal System.Windows.Forms.CheckBox chkPublicRoom;
        internal System.Windows.Forms.NumericUpDown txtRoomPart;
        internal System.Windows.Forms.NumericUpDown txtRoomID;
        private System.Windows.Forms.Button button3;

    }
}