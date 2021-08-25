namespace Kendax
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AccountsGrpbx = new System.Windows.Forms.GroupBox();
            this.StatusTxt = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.AccountTxt = new System.Windows.Forms.ComboBox();
            this.AvatarPctbx = new System.Windows.Forms.PictureBox();
            this.AllAccountsChckbx = new System.Windows.Forms.CheckBox();
            this.ConnectedLbl = new System.Windows.Forms.Label();
            this.AnimationTmr = new System.Windows.Forms.Timer(this.components);
            this.PingTmr = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RoomTab = new System.Windows.Forms.TabPage();
            this.ATNGrpbx = new System.Windows.Forms.GroupBox();
            this.NavAmountNud = new System.Windows.Forms.NumericUpDown();
            this.NavigationGrpbx = new System.Windows.Forms.GroupBox();
            this.NavigateBtn = new System.Windows.Forms.Button();
            this.RoomPasswordTxt = new System.Windows.Forms.TextBox();
            this.RoomIDTxt = new System.Windows.Forms.TextBox();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetMottoBtn = new System.Windows.Forms.Button();
            this.MottoTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetClothesBtn = new System.Windows.Forms.Button();
            this.ClothesTxt = new System.Windows.Forms.TextBox();
            this.WalkingGrpbx = new System.Windows.Forms.GroupBox();
            this.WalkToBtn = new System.Windows.Forms.Button();
            this.AutoWalkChckbx = new System.Windows.Forms.CheckBox();
            this.WalkYMax = new System.Windows.Forms.NumericUpDown();
            this.WalkYMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.WalkXMax = new System.Windows.Forms.NumericUpDown();
            this.WalkXMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.WalkingTmr = new System.Windows.Forms.Timer(this.components);
            this.TargetLbl = new System.Windows.Forms.Label();
            this.TargetTxt = new System.Windows.Forms.TextBox();
            this.FriendRequestBtn = new System.Windows.Forms.Button();
            this.AccountsGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPctbx)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.RoomTab.SuspendLayout();
            this.ATNGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavAmountNud)).BeginInit();
            this.NavigationGrpbx.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WalkingGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WalkYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkXMin)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsGrpbx
            // 
            this.AccountsGrpbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsGrpbx.Controls.Add(this.StatusTxt);
            this.AccountsGrpbx.Controls.Add(this.ConnectBtn);
            this.AccountsGrpbx.Controls.Add(this.LoginBtn);
            this.AccountsGrpbx.Controls.Add(this.AccountTxt);
            this.AccountsGrpbx.Controls.Add(this.AvatarPctbx);
            this.AccountsGrpbx.Controls.Add(this.AllAccountsChckbx);
            this.AccountsGrpbx.Controls.Add(this.ConnectedLbl);
            this.AccountsGrpbx.Location = new System.Drawing.Point(12, 12);
            this.AccountsGrpbx.Name = "AccountsGrpbx";
            this.AccountsGrpbx.Size = new System.Drawing.Size(380, 135);
            this.AccountsGrpbx.TabIndex = 0;
            this.AccountsGrpbx.TabStop = false;
            this.AccountsGrpbx.Text = "Account(s) - Total: 0 | Connected:";
            // 
            // StatusTxt
            // 
            this.StatusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTxt.Location = new System.Drawing.Point(76, 72);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(298, 57);
            this.StatusTxt.TabIndex = 5;
            this.StatusTxt.Text = "Standing By...";
            this.StatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Enabled = false;
            this.ConnectBtn.Location = new System.Drawing.Point(228, 46);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(146, 23);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Enabled = false;
            this.LoginBtn.Location = new System.Drawing.Point(76, 46);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(146, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login/Authenticate";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // AccountTxt
            // 
            this.AccountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountTxt.Enabled = false;
            this.AccountTxt.FormattingEnabled = true;
            this.AccountTxt.Location = new System.Drawing.Point(76, 19);
            this.AccountTxt.Name = "AccountTxt";
            this.AccountTxt.Size = new System.Drawing.Size(298, 21);
            this.AccountTxt.TabIndex = 1;
            this.AccountTxt.SelectedIndexChanged += new System.EventHandler(this.AccountTxt_SelectedIndexChanged);
            // 
            // AvatarPctbx
            // 
            this.AvatarPctbx.ErrorImage = null;
            this.AvatarPctbx.Image = global::Kendax.Properties.Resources.Avatar;
            this.AvatarPctbx.InitialImage = null;
            this.AvatarPctbx.Location = new System.Drawing.Point(6, 19);
            this.AvatarPctbx.Name = "AvatarPctbx";
            this.AvatarPctbx.Size = new System.Drawing.Size(64, 110);
            this.AvatarPctbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AvatarPctbx.TabIndex = 2;
            this.AvatarPctbx.TabStop = false;
            // 
            // AllAccountsChckbx
            // 
            this.AllAccountsChckbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllAccountsChckbx.AutoSize = true;
            this.AllAccountsChckbx.Enabled = false;
            this.AllAccountsChckbx.Location = new System.Drawing.Point(289, -1);
            this.AllAccountsChckbx.Name = "AllAccountsChckbx";
            this.AllAccountsChckbx.Size = new System.Drawing.Size(85, 17);
            this.AllAccountsChckbx.TabIndex = 1;
            this.AllAccountsChckbx.Text = "All Accounts";
            this.AllAccountsChckbx.UseVisualStyleBackColor = true;
            // 
            // ConnectedLbl
            // 
            this.ConnectedLbl.AutoSize = true;
            this.ConnectedLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.ConnectedLbl.Location = new System.Drawing.Point(167, 0);
            this.ConnectedLbl.Name = "ConnectedLbl";
            this.ConnectedLbl.Size = new System.Drawing.Size(32, 13);
            this.ConnectedLbl.TabIndex = 0;
            this.ConnectedLbl.Text = "False";
            // 
            // AnimationTmr
            // 
            this.AnimationTmr.Interval = 200;
            this.AnimationTmr.Tick += new System.EventHandler(this.AnimationTmr_Tick);
            // 
            // PingTmr
            // 
            this.PingTmr.Interval = 120000;
            this.PingTmr.Tick += new System.EventHandler(this.PingTmr_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.RoomTab);
            this.tabControl1.Controls.Add(this.PlayerTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 189);
            this.tabControl1.TabIndex = 1;
            // 
            // RoomTab
            // 
            this.RoomTab.Controls.Add(this.ATNGrpbx);
            this.RoomTab.Controls.Add(this.NavigationGrpbx);
            this.RoomTab.Location = new System.Drawing.Point(4, 22);
            this.RoomTab.Name = "RoomTab";
            this.RoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.RoomTab.Size = new System.Drawing.Size(372, 163);
            this.RoomTab.TabIndex = 0;
            this.RoomTab.Text = "Room Tools";
            this.RoomTab.UseVisualStyleBackColor = true;
            // 
            // ATNGrpbx
            // 
            this.ATNGrpbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ATNGrpbx.Controls.Add(this.NavAmountNud);
            this.ATNGrpbx.Location = new System.Drawing.Point(6, 112);
            this.ATNGrpbx.Name = "ATNGrpbx";
            this.ATNGrpbx.Size = new System.Drawing.Size(126, 45);
            this.ATNGrpbx.TabIndex = 1;
            this.ATNGrpbx.TabStop = false;
            this.ATNGrpbx.Text = "Amount To Navigate";
            // 
            // NavAmountNud
            // 
            this.NavAmountNud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavAmountNud.Location = new System.Drawing.Point(6, 19);
            this.NavAmountNud.Name = "NavAmountNud";
            this.NavAmountNud.Size = new System.Drawing.Size(114, 20);
            this.NavAmountNud.TabIndex = 0;
            this.NavAmountNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NavigationGrpbx
            // 
            this.NavigationGrpbx.Controls.Add(this.NavigateBtn);
            this.NavigationGrpbx.Controls.Add(this.RoomPasswordTxt);
            this.NavigationGrpbx.Controls.Add(this.RoomIDTxt);
            this.NavigationGrpbx.Location = new System.Drawing.Point(6, 6);
            this.NavigationGrpbx.Name = "NavigationGrpbx";
            this.NavigationGrpbx.Size = new System.Drawing.Size(126, 100);
            this.NavigationGrpbx.TabIndex = 0;
            this.NavigationGrpbx.TabStop = false;
            this.NavigationGrpbx.Text = "Navigation";
            // 
            // NavigateBtn
            // 
            this.NavigateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigateBtn.Location = new System.Drawing.Point(6, 71);
            this.NavigateBtn.Name = "NavigateBtn";
            this.NavigateBtn.Size = new System.Drawing.Size(114, 23);
            this.NavigateBtn.TabIndex = 6;
            this.NavigateBtn.Text = "Navigate";
            this.NavigateBtn.UseVisualStyleBackColor = true;
            this.NavigateBtn.Click += new System.EventHandler(this.NavigateBtn_Click);
            // 
            // RoomPasswordTxt
            // 
            this.RoomPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomPasswordTxt.Location = new System.Drawing.Point(6, 45);
            this.RoomPasswordTxt.Name = "RoomPasswordTxt";
            this.RoomPasswordTxt.Size = new System.Drawing.Size(114, 20);
            this.RoomPasswordTxt.TabIndex = 2;
            this.RoomPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomIDTxt
            // 
            this.RoomIDTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomIDTxt.Location = new System.Drawing.Point(6, 19);
            this.RoomIDTxt.Name = "RoomIDTxt";
            this.RoomIDTxt.Size = new System.Drawing.Size(114, 20);
            this.RoomIDTxt.TabIndex = 1;
            this.RoomIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Controls.Add(this.FriendRequestBtn);
            this.PlayerTab.Controls.Add(this.TargetTxt);
            this.PlayerTab.Controls.Add(this.TargetLbl);
            this.PlayerTab.Controls.Add(this.groupBox2);
            this.PlayerTab.Controls.Add(this.groupBox1);
            this.PlayerTab.Controls.Add(this.WalkingGrpbx);
            this.PlayerTab.Location = new System.Drawing.Point(4, 22);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerTab.Size = new System.Drawing.Size(372, 163);
            this.PlayerTab.TabIndex = 1;
            this.PlayerTab.Text = "Player Tools";
            this.PlayerTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetMottoBtn);
            this.groupBox2.Controls.Add(this.MottoTxt);
            this.groupBox2.Location = new System.Drawing.Point(224, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motto";
            // 
            // SetMottoBtn
            // 
            this.SetMottoBtn.Location = new System.Drawing.Point(99, 17);
            this.SetMottoBtn.Name = "SetMottoBtn";
            this.SetMottoBtn.Size = new System.Drawing.Size(37, 23);
            this.SetMottoBtn.TabIndex = 4;
            this.SetMottoBtn.Text = "Set";
            this.SetMottoBtn.UseVisualStyleBackColor = true;
            this.SetMottoBtn.Click += new System.EventHandler(this.SetMottoBtn_Click);
            // 
            // MottoTxt
            // 
            this.MottoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MottoTxt.Location = new System.Drawing.Point(6, 19);
            this.MottoTxt.Name = "MottoTxt";
            this.MottoTxt.Size = new System.Drawing.Size(87, 20);
            this.MottoTxt.TabIndex = 2;
            this.MottoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetClothesBtn);
            this.groupBox1.Controls.Add(this.ClothesTxt);
            this.groupBox1.Location = new System.Drawing.Point(6, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clothes";
            // 
            // SetClothesBtn
            // 
            this.SetClothesBtn.Location = new System.Drawing.Point(169, 17);
            this.SetClothesBtn.Name = "SetClothesBtn";
            this.SetClothesBtn.Size = new System.Drawing.Size(37, 23);
            this.SetClothesBtn.TabIndex = 5;
            this.SetClothesBtn.Text = "Set";
            this.SetClothesBtn.UseVisualStyleBackColor = true;
            this.SetClothesBtn.Click += new System.EventHandler(this.SetClothesBtn_Click);
            // 
            // ClothesTxt
            // 
            this.ClothesTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesTxt.Location = new System.Drawing.Point(6, 19);
            this.ClothesTxt.Name = "ClothesTxt";
            this.ClothesTxt.Size = new System.Drawing.Size(157, 20);
            this.ClothesTxt.TabIndex = 2;
            this.ClothesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WalkingGrpbx
            // 
            this.WalkingGrpbx.Controls.Add(this.WalkToBtn);
            this.WalkingGrpbx.Controls.Add(this.AutoWalkChckbx);
            this.WalkingGrpbx.Controls.Add(this.WalkYMax);
            this.WalkingGrpbx.Controls.Add(this.WalkYMin);
            this.WalkingGrpbx.Controls.Add(this.label2);
            this.WalkingGrpbx.Controls.Add(this.WalkXMax);
            this.WalkingGrpbx.Controls.Add(this.WalkXMin);
            this.WalkingGrpbx.Controls.Add(this.label1);
            this.WalkingGrpbx.Location = new System.Drawing.Point(6, 6);
            this.WalkingGrpbx.Name = "WalkingGrpbx";
            this.WalkingGrpbx.Size = new System.Drawing.Size(172, 100);
            this.WalkingGrpbx.TabIndex = 0;
            this.WalkingGrpbx.TabStop = false;
            this.WalkingGrpbx.Text = "Walking";
            // 
            // WalkToBtn
            // 
            this.WalkToBtn.Location = new System.Drawing.Point(6, 71);
            this.WalkToBtn.Name = "WalkToBtn";
            this.WalkToBtn.Size = new System.Drawing.Size(160, 23);
            this.WalkToBtn.TabIndex = 1;
            this.WalkToBtn.Text = "Walk To ( X - Y )";
            this.WalkToBtn.UseVisualStyleBackColor = true;
            this.WalkToBtn.Click += new System.EventHandler(this.WalkToBtn_Click);
            // 
            // AutoWalkChckbx
            // 
            this.AutoWalkChckbx.AutoSize = true;
            this.AutoWalkChckbx.BackColor = System.Drawing.Color.White;
            this.AutoWalkChckbx.Location = new System.Drawing.Point(90, 0);
            this.AutoWalkChckbx.Name = "AutoWalkChckbx";
            this.AutoWalkChckbx.Size = new System.Drawing.Size(76, 17);
            this.AutoWalkChckbx.TabIndex = 1;
            this.AutoWalkChckbx.Text = "Auto Walk";
            this.AutoWalkChckbx.UseVisualStyleBackColor = false;
            this.AutoWalkChckbx.CheckedChanged += new System.EventHandler(this.AutoWalkChckbx_CheckedChanged);
            // 
            // WalkYMax
            // 
            this.WalkYMax.Location = new System.Drawing.Point(119, 45);
            this.WalkYMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WalkYMax.Name = "WalkYMax";
            this.WalkYMax.Size = new System.Drawing.Size(47, 20);
            this.WalkYMax.TabIndex = 3;
            this.WalkYMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WalkYMax.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});
            // 
            // WalkYMin
            // 
            this.WalkYMin.Location = new System.Drawing.Point(66, 45);
            this.WalkYMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WalkYMin.Name = "WalkYMin";
            this.WalkYMin.Size = new System.Drawing.Size(47, 20);
            this.WalkYMin.TabIndex = 2;
            this.WalkYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WalkYMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y - Range:";
            // 
            // WalkXMax
            // 
            this.WalkXMax.Location = new System.Drawing.Point(119, 19);
            this.WalkXMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WalkXMax.Name = "WalkXMax";
            this.WalkXMax.Size = new System.Drawing.Size(47, 20);
            this.WalkXMax.TabIndex = 1;
            this.WalkXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WalkXMax.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});
            // 
            // WalkXMin
            // 
            this.WalkXMin.Location = new System.Drawing.Point(66, 19);
            this.WalkXMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WalkXMin.Name = "WalkXMin";
            this.WalkXMin.Size = new System.Drawing.Size(47, 20);
            this.WalkXMin.TabIndex = 0;
            this.WalkXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WalkXMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X - Range:";
            // 
            // WalkingTmr
            // 
            this.WalkingTmr.Interval = 250;
            this.WalkingTmr.Tick += new System.EventHandler(this.WalkingTmr_Tick);
            // 
            // TargetLbl
            // 
            this.TargetLbl.AutoSize = true;
            this.TargetLbl.Location = new System.Drawing.Point(184, 6);
            this.TargetLbl.Name = "TargetLbl";
            this.TargetLbl.Size = new System.Drawing.Size(38, 13);
            this.TargetLbl.TabIndex = 5;
            this.TargetLbl.Text = "Target";
            // 
            // TargetTxt
            // 
            this.TargetTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetTxt.Location = new System.Drawing.Point(187, 22);
            this.TargetTxt.Name = "TargetTxt";
            this.TargetTxt.Size = new System.Drawing.Size(179, 20);
            this.TargetTxt.TabIndex = 5;
            this.TargetTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FriendRequestBtn
            // 
            this.FriendRequestBtn.Location = new System.Drawing.Point(271, 48);
            this.FriendRequestBtn.Name = "FriendRequestBtn";
            this.FriendRequestBtn.Size = new System.Drawing.Size(95, 23);
            this.FriendRequestBtn.TabIndex = 6;
            this.FriendRequestBtn.Text = "Friend Request";
            this.FriendRequestBtn.UseVisualStyleBackColor = true;
            this.FriendRequestBtn.Click += new System.EventHandler(this.FriendRequestBtn_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 354);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AccountsGrpbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kendax ~ 0[Connected]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.AccountsGrpbx.ResumeLayout(false);
            this.AccountsGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPctbx)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.RoomTab.ResumeLayout(false);
            this.ATNGrpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavAmountNud)).EndInit();
            this.NavigationGrpbx.ResumeLayout(false);
            this.NavigationGrpbx.PerformLayout();
            this.PlayerTab.ResumeLayout(false);
            this.PlayerTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WalkingGrpbx.ResumeLayout(false);
            this.WalkingGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WalkYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkXMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountsGrpbx;
        private System.Windows.Forms.Label ConnectedLbl;
        private System.Windows.Forms.CheckBox AllAccountsChckbx;
        private System.Windows.Forms.PictureBox AvatarPctbx;
        private System.Windows.Forms.ComboBox AccountTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label StatusTxt;
        private System.Windows.Forms.Timer AnimationTmr;
        private System.Windows.Forms.Timer PingTmr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RoomTab;
        private System.Windows.Forms.TabPage PlayerTab;
        private System.Windows.Forms.GroupBox NavigationGrpbx;
        private System.Windows.Forms.Button NavigateBtn;
        private System.Windows.Forms.TextBox RoomPasswordTxt;
        private System.Windows.Forms.TextBox RoomIDTxt;
        private System.Windows.Forms.GroupBox ATNGrpbx;
        private System.Windows.Forms.NumericUpDown NavAmountNud;
        private System.Windows.Forms.Timer WalkingTmr;
        private System.Windows.Forms.GroupBox WalkingGrpbx;
        private System.Windows.Forms.Button WalkToBtn;
        private System.Windows.Forms.CheckBox AutoWalkChckbx;
        private System.Windows.Forms.NumericUpDown WalkYMax;
        private System.Windows.Forms.NumericUpDown WalkYMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WalkXMax;
        private System.Windows.Forms.NumericUpDown WalkXMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SetMottoBtn;
        private System.Windows.Forms.TextBox MottoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetClothesBtn;
        private System.Windows.Forms.TextBox ClothesTxt;
        private System.Windows.Forms.TextBox TargetTxt;
        private System.Windows.Forms.Label TargetLbl;
        private System.Windows.Forms.Button FriendRequestBtn;
    }
}

