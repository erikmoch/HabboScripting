namespace KClient
{
    partial class MainFrm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBotCount = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.ckbProxy = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnOpenGrab = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSSOList = new System.Windows.Forms.TextBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnScratch = new System.Windows.Forms.Button();
            this.txtPetId = new System.Windows.Forms.TextBox();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDance = new System.Windows.Forms.Button();
            this.btnSit = new System.Windows.Forms.Button();
            this.btnChangeClothes = new System.Windows.Forms.Button();
            this.txtFigureString = new System.Windows.Forms.TextBox();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnWalk = new System.Windows.Forms.Button();
            this.txtTalk = new System.Windows.Forms.TextBox();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtXpos = new System.Windows.Forms.TextBox();
            this.btnWalkAround = new System.Windows.Forms.Button();
            this.btnRespectUser = new System.Windows.Forms.Button();
            this.txtRespectUserId = new System.Windows.Forms.TextBox();
            this.btnEnterRoom = new System.Windows.Forms.Button();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnActions = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.panelBotManager = new System.Windows.Forms.Panel();
            this.skoreUsingBots = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skoreBotList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearUsingBots = new System.Windows.Forms.Button();
            this.btnRemoveBot = new System.Windows.Forms.Button();
            this.btnAddBot = new System.Windows.Forms.Button();
            this.panelProxy = new System.Windows.Forms.Panel();
            this.txtProxyList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericProxyQuant = new System.Windows.Forms.NumericUpDown();
            this.btnSaveProxies = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelConnection.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelBotManager.SuspendLayout();
            this.panelProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericProxyQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbBotCount);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 59);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alcubierre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conectados";
            // 
            // lbBotCount
            // 
            this.lbBotCount.AutoSize = true;
            this.lbBotCount.Font = new System.Drawing.Font("Alcubierre", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBotCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbBotCount.Location = new System.Drawing.Point(31, 3);
            this.lbBotCount.Name = "lbBotCount";
            this.lbBotCount.Size = new System.Drawing.Size(34, 38);
            this.lbBotCount.TabIndex = 2;
            this.lbBotCount.Text = "0";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Alcubierre", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbTitle.Location = new System.Drawing.Point(178, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(194, 38);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "BONNIE BOTS";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KClient.Properties.Resources.errorBranco;
            this.pictureBox1.Location = new System.Drawing.Point(502, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.Crimson;
            this.btnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.ForeColor = System.Drawing.Color.White;
            this.btnConnection.Location = new System.Drawing.Point(6, 65);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(94, 34);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.Text = "Conexão";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // panelConnection
            // 
            this.panelConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelConnection.Controls.Add(this.ckbProxy);
            this.panelConnection.Controls.Add(this.richTextBox1);
            this.panelConnection.Controls.Add(this.checkBox1);
            this.panelConnection.Controls.Add(this.btnOpenGrab);
            this.panelConnection.Controls.Add(this.btnConnect);
            this.panelConnection.Controls.Add(this.txtSSOList);
            this.panelConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelConnection.Location = new System.Drawing.Point(0, 105);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(551, 277);
            this.panelConnection.TabIndex = 2;
            // 
            // ckbProxy
            // 
            this.ckbProxy.AutoSize = true;
            this.ckbProxy.ForeColor = System.Drawing.Color.White;
            this.ckbProxy.Location = new System.Drawing.Point(106, 249);
            this.ckbProxy.Name = "ckbProxy";
            this.ckbProxy.Size = new System.Drawing.Size(77, 17);
            this.ckbProxy.TabIndex = 7;
            this.ckbProxy.Text = "Usar Proxy";
            this.ckbProxy.UseVisualStyleBackColor = true;
            this.ckbProxy.CheckedChanged += new System.EventHandler(this.ckbProxy_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(24, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(502, 178);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(24, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "TopMost";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnOpenGrab
            // 
            this.btnOpenGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnOpenGrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenGrab.FlatAppearance.BorderSize = 0;
            this.btnOpenGrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGrab.ForeColor = System.Drawing.Color.White;
            this.btnOpenGrab.Location = new System.Drawing.Point(269, 21);
            this.btnOpenGrab.Name = "btnOpenGrab";
            this.btnOpenGrab.Size = new System.Drawing.Size(94, 28);
            this.btnOpenGrab.TabIndex = 4;
            this.btnOpenGrab.Text = "Interceptar SSO";
            this.btnOpenGrab.UseVisualStyleBackColor = false;
            this.btnOpenGrab.Click += new System.EventHandler(this.btnOpenGrab_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(169, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 28);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSSOList
            // 
            this.txtSSOList.Enabled = false;
            this.txtSSOList.Location = new System.Drawing.Point(133, 115);
            this.txtSSOList.Multiline = true;
            this.txtSSOList.Name = "txtSSOList";
            this.txtSSOList.Size = new System.Drawing.Size(327, 40);
            this.txtSSOList.TabIndex = 0;
            this.txtSSOList.Visible = false;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelActions.Controls.Add(this.btnScratch);
            this.panelActions.Controls.Add(this.txtPetId);
            this.panelActions.Controls.Add(this.btnStand);
            this.panelActions.Controls.Add(this.btnDance);
            this.panelActions.Controls.Add(this.btnSit);
            this.panelActions.Controls.Add(this.btnChangeClothes);
            this.panelActions.Controls.Add(this.txtFigureString);
            this.panelActions.Controls.Add(this.btnTalk);
            this.panelActions.Controls.Add(this.btnWalk);
            this.panelActions.Controls.Add(this.txtTalk);
            this.panelActions.Controls.Add(this.txtYPos);
            this.panelActions.Controls.Add(this.txtXpos);
            this.panelActions.Controls.Add(this.btnWalkAround);
            this.panelActions.Controls.Add(this.btnRespectUser);
            this.panelActions.Controls.Add(this.txtRespectUserId);
            this.panelActions.Controls.Add(this.btnEnterRoom);
            this.panelActions.Controls.Add(this.txtRoomId);
            this.panelActions.Location = new System.Drawing.Point(0, 461);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(551, 71);
            this.panelActions.TabIndex = 4;
            // 
            // btnScratch
            // 
            this.btnScratch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnScratch.FlatAppearance.BorderSize = 0;
            this.btnScratch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScratch.ForeColor = System.Drawing.Color.White;
            this.btnScratch.Location = new System.Drawing.Point(244, 38);
            this.btnScratch.Name = "btnScratch";
            this.btnScratch.Size = new System.Drawing.Size(106, 28);
            this.btnScratch.TabIndex = 20;
            this.btnScratch.Text = "Acariciar";
            this.btnScratch.UseVisualStyleBackColor = false;
            this.btnScratch.Click += new System.EventHandler(this.btnScratch_Click);
            // 
            // txtPetId
            // 
            this.txtPetId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtPetId.ForeColor = System.Drawing.Color.White;
            this.txtPetId.Location = new System.Drawing.Point(244, 15);
            this.txtPetId.Name = "txtPetId";
            this.txtPetId.Size = new System.Drawing.Size(106, 20);
            this.txtPetId.TabIndex = 19;
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.ForeColor = System.Drawing.Color.White;
            this.btnStand.Location = new System.Drawing.Point(452, 43);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(91, 23);
            this.btnStand.TabIndex = 18;
            this.btnStand.Text = "Levantar";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDance
            // 
            this.btnDance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDance.FlatAppearance.BorderSize = 0;
            this.btnDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDance.ForeColor = System.Drawing.Color.White;
            this.btnDance.Location = new System.Drawing.Point(20, 72);
            this.btnDance.Name = "btnDance";
            this.btnDance.Size = new System.Drawing.Size(106, 29);
            this.btnDance.TabIndex = 17;
            this.btnDance.Text = "Dançar";
            this.btnDance.UseVisualStyleBackColor = false;
            this.btnDance.Click += new System.EventHandler(this.btnDance_Click);
            // 
            // btnSit
            // 
            this.btnSit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSit.FlatAppearance.BorderSize = 0;
            this.btnSit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit.ForeColor = System.Drawing.Color.White;
            this.btnSit.Location = new System.Drawing.Point(452, 15);
            this.btnSit.Name = "btnSit";
            this.btnSit.Size = new System.Drawing.Size(91, 23);
            this.btnSit.TabIndex = 16;
            this.btnSit.Text = "Sentar";
            this.btnSit.UseVisualStyleBackColor = false;
            this.btnSit.Click += new System.EventHandler(this.btnSit_Click);
            // 
            // btnChangeClothes
            // 
            this.btnChangeClothes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnChangeClothes.FlatAppearance.BorderSize = 0;
            this.btnChangeClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeClothes.ForeColor = System.Drawing.Color.White;
            this.btnChangeClothes.Location = new System.Drawing.Point(233, 171);
            this.btnChangeClothes.Name = "btnChangeClothes";
            this.btnChangeClothes.Size = new System.Drawing.Size(106, 28);
            this.btnChangeClothes.TabIndex = 15;
            this.btnChangeClothes.Text = "Trocar Roupa";
            this.btnChangeClothes.UseVisualStyleBackColor = false;
            this.btnChangeClothes.Click += new System.EventHandler(this.btnChangeClothes_Click);
            // 
            // txtFigureString
            // 
            this.txtFigureString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtFigureString.ForeColor = System.Drawing.Color.White;
            this.txtFigureString.Location = new System.Drawing.Point(66, 145);
            this.txtFigureString.Name = "txtFigureString";
            this.txtFigureString.Size = new System.Drawing.Size(418, 20);
            this.txtFigureString.TabIndex = 14;
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnTalk.FlatAppearance.BorderSize = 0;
            this.btnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalk.ForeColor = System.Drawing.Color.White;
            this.btnTalk.Location = new System.Drawing.Point(233, 231);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(106, 28);
            this.btnTalk.TabIndex = 13;
            this.btnTalk.Text = "Falar";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnWalk
            // 
            this.btnWalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnWalk.FlatAppearance.BorderSize = 0;
            this.btnWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWalk.ForeColor = System.Drawing.Color.White;
            this.btnWalk.Location = new System.Drawing.Point(356, 38);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(90, 28);
            this.btnWalk.TabIndex = 11;
            this.btnWalk.Text = "Andar";
            this.btnWalk.UseVisualStyleBackColor = false;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // txtTalk
            // 
            this.txtTalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtTalk.ForeColor = System.Drawing.Color.White;
            this.txtTalk.Location = new System.Drawing.Point(66, 205);
            this.txtTalk.Name = "txtTalk";
            this.txtTalk.Size = new System.Drawing.Size(418, 20);
            this.txtTalk.TabIndex = 12;
            // 
            // txtYPos
            // 
            this.txtYPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtYPos.ForeColor = System.Drawing.Color.White;
            this.txtYPos.Location = new System.Drawing.Point(404, 15);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(42, 20);
            this.txtYPos.TabIndex = 10;
            // 
            // txtXpos
            // 
            this.txtXpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtXpos.ForeColor = System.Drawing.Color.White;
            this.txtXpos.Location = new System.Drawing.Point(356, 15);
            this.txtXpos.Name = "txtXpos";
            this.txtXpos.Size = new System.Drawing.Size(42, 20);
            this.txtXpos.TabIndex = 9;
            // 
            // btnWalkAround
            // 
            this.btnWalkAround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnWalkAround.FlatAppearance.BorderSize = 0;
            this.btnWalkAround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWalkAround.ForeColor = System.Drawing.Color.White;
            this.btnWalkAround.Location = new System.Drawing.Point(132, 72);
            this.btnWalkAround.Name = "btnWalkAround";
            this.btnWalkAround.Size = new System.Drawing.Size(106, 29);
            this.btnWalkAround.TabIndex = 8;
            this.btnWalkAround.Text = "Andar Aut.";
            this.btnWalkAround.UseVisualStyleBackColor = false;
            this.btnWalkAround.Click += new System.EventHandler(this.btnWalkAround_Click);
            // 
            // btnRespectUser
            // 
            this.btnRespectUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnRespectUser.FlatAppearance.BorderSize = 0;
            this.btnRespectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespectUser.ForeColor = System.Drawing.Color.White;
            this.btnRespectUser.Location = new System.Drawing.Point(132, 38);
            this.btnRespectUser.Name = "btnRespectUser";
            this.btnRespectUser.Size = new System.Drawing.Size(106, 28);
            this.btnRespectUser.TabIndex = 7;
            this.btnRespectUser.Text = "Respeitar";
            this.btnRespectUser.UseVisualStyleBackColor = false;
            this.btnRespectUser.Click += new System.EventHandler(this.btnRespectUser_Click);
            // 
            // txtRespectUserId
            // 
            this.txtRespectUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtRespectUserId.ForeColor = System.Drawing.Color.White;
            this.txtRespectUserId.Location = new System.Drawing.Point(132, 15);
            this.txtRespectUserId.Name = "txtRespectUserId";
            this.txtRespectUserId.Size = new System.Drawing.Size(106, 20);
            this.txtRespectUserId.TabIndex = 6;
            // 
            // btnEnterRoom
            // 
            this.btnEnterRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEnterRoom.FlatAppearance.BorderSize = 0;
            this.btnEnterRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterRoom.ForeColor = System.Drawing.Color.White;
            this.btnEnterRoom.Location = new System.Drawing.Point(20, 38);
            this.btnEnterRoom.Name = "btnEnterRoom";
            this.btnEnterRoom.Size = new System.Drawing.Size(106, 28);
            this.btnEnterRoom.TabIndex = 5;
            this.btnEnterRoom.Text = "Entrar no Quarto";
            this.btnEnterRoom.UseVisualStyleBackColor = false;
            this.btnEnterRoom.Click += new System.EventHandler(this.btnEnterRoom_Click);
            // 
            // txtRoomId
            // 
            this.txtRoomId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtRoomId.ForeColor = System.Drawing.Color.White;
            this.txtRoomId.Location = new System.Drawing.Point(20, 15);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(106, 20);
            this.txtRoomId.TabIndex = 0;
            // 
            // btnActions
            // 
            this.btnActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnActions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActions.Enabled = false;
            this.btnActions.FlatAppearance.BorderSize = 0;
            this.btnActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActions.ForeColor = System.Drawing.Color.White;
            this.btnActions.Location = new System.Drawing.Point(106, 65);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(94, 34);
            this.btnActions.TabIndex = 3;
            this.btnActions.Text = "Ações";
            this.btnActions.UseVisualStyleBackColor = false;
            this.btnActions.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.Enabled = false;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Location = new System.Drawing.Point(206, 65);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(94, 34);
            this.btnManagement.TabIndex = 6;
            this.btnManagement.Text = "Bot Manager";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // panelBotManager
            // 
            this.panelBotManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelBotManager.Controls.Add(this.skoreUsingBots);
            this.panelBotManager.Controls.Add(this.skoreBotList);
            this.panelBotManager.Controls.Add(this.btnClearUsingBots);
            this.panelBotManager.Controls.Add(this.btnRemoveBot);
            this.panelBotManager.Controls.Add(this.btnAddBot);
            this.panelBotManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelBotManager.Location = new System.Drawing.Point(0, 538);
            this.panelBotManager.Name = "panelBotManager";
            this.panelBotManager.Size = new System.Drawing.Size(551, 56);
            this.panelBotManager.TabIndex = 7;
            // 
            // skoreUsingBots
            // 
            this.skoreUsingBots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.skoreUsingBots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skoreUsingBots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.skoreUsingBots.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skoreUsingBots.ForeColor = System.Drawing.Color.White;
            this.skoreUsingBots.Location = new System.Drawing.Point(335, 18);
            this.skoreUsingBots.Name = "skoreUsingBots";
            this.skoreUsingBots.Size = new System.Drawing.Size(194, 245);
            this.skoreUsingBots.TabIndex = 24;
            this.skoreUsingBots.UseCompatibleStateImageBehavior = false;
            this.skoreUsingBots.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Específicos";
            this.columnHeader1.Width = 194;
            // 
            // skoreBotList
            // 
            this.skoreBotList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.skoreBotList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skoreBotList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.skoreBotList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skoreBotList.ForeColor = System.Drawing.Color.White;
            this.skoreBotList.Location = new System.Drawing.Point(20, 18);
            this.skoreBotList.Name = "skoreBotList";
            this.skoreBotList.Size = new System.Drawing.Size(194, 245);
            this.skoreBotList.TabIndex = 7;
            this.skoreBotList.UseCompatibleStateImageBehavior = false;
            this.skoreBotList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bots";
            this.columnHeader3.Width = 194;
            // 
            // btnClearUsingBots
            // 
            this.btnClearUsingBots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnClearUsingBots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearUsingBots.FlatAppearance.BorderSize = 0;
            this.btnClearUsingBots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUsingBots.ForeColor = System.Drawing.Color.White;
            this.btnClearUsingBots.Location = new System.Drawing.Point(225, 100);
            this.btnClearUsingBots.Name = "btnClearUsingBots";
            this.btnClearUsingBots.Size = new System.Drawing.Size(99, 41);
            this.btnClearUsingBots.TabIndex = 23;
            this.btnClearUsingBots.Text = "Limpar específicos";
            this.btnClearUsingBots.UseVisualStyleBackColor = false;
            this.btnClearUsingBots.Click += new System.EventHandler(this.btnClearUsingBots_Click);
            // 
            // btnRemoveBot
            // 
            this.btnRemoveBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnRemoveBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveBot.FlatAppearance.BorderSize = 0;
            this.btnRemoveBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBot.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBot.Location = new System.Drawing.Point(225, 59);
            this.btnRemoveBot.Name = "btnRemoveBot";
            this.btnRemoveBot.Size = new System.Drawing.Size(99, 28);
            this.btnRemoveBot.TabIndex = 22;
            this.btnRemoveBot.Text = "Remover Bot(s) <";
            this.btnRemoveBot.UseVisualStyleBackColor = false;
            this.btnRemoveBot.Click += new System.EventHandler(this.btnRemoveBot_Click);
            // 
            // btnAddBot
            // 
            this.btnAddBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBot.FlatAppearance.BorderSize = 0;
            this.btnAddBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBot.ForeColor = System.Drawing.Color.White;
            this.btnAddBot.Location = new System.Drawing.Point(225, 18);
            this.btnAddBot.Name = "btnAddBot";
            this.btnAddBot.Size = new System.Drawing.Size(99, 28);
            this.btnAddBot.TabIndex = 21;
            this.btnAddBot.Text = "> Adicionar Bot(s)";
            this.btnAddBot.UseVisualStyleBackColor = false;
            this.btnAddBot.Click += new System.EventHandler(this.btnAddBot_Click);
            // 
            // panelProxy
            // 
            this.panelProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelProxy.Controls.Add(this.txtProxyList);
            this.panelProxy.Controls.Add(this.label3);
            this.panelProxy.Controls.Add(this.numericProxyQuant);
            this.panelProxy.Controls.Add(this.btnSaveProxies);
            this.panelProxy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelProxy.Location = new System.Drawing.Point(557, 105);
            this.panelProxy.Name = "panelProxy";
            this.panelProxy.Size = new System.Drawing.Size(551, 238);
            this.panelProxy.TabIndex = 7;
            // 
            // txtProxyList
            // 
            this.txtProxyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.txtProxyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProxyList.ForeColor = System.Drawing.Color.White;
            this.txtProxyList.Location = new System.Drawing.Point(20, 29);
            this.txtProxyList.Multiline = true;
            this.txtProxyList.Name = "txtProxyList";
            this.txtProxyList.Size = new System.Drawing.Size(511, 134);
            this.txtProxyList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(338, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade máxima de conexões por proxy";
            // 
            // numericProxyQuant
            // 
            this.numericProxyQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.numericProxyQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericProxyQuant.ForeColor = System.Drawing.Color.White;
            this.numericProxyQuant.Location = new System.Drawing.Point(483, 194);
            this.numericProxyQuant.Name = "numericProxyQuant";
            this.numericProxyQuant.Size = new System.Drawing.Size(61, 20);
            this.numericProxyQuant.TabIndex = 8;
            this.numericProxyQuant.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnSaveProxies
            // 
            this.btnSaveProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSaveProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProxies.FlatAppearance.BorderSize = 0;
            this.btnSaveProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProxies.ForeColor = System.Drawing.Color.White;
            this.btnSaveProxies.Location = new System.Drawing.Point(221, 180);
            this.btnSaveProxies.Name = "btnSaveProxies";
            this.btnSaveProxies.Size = new System.Drawing.Size(94, 28);
            this.btnSaveProxies.TabIndex = 4;
            this.btnSaveProxies.Text = "Salvar proxies";
            this.btnSaveProxies.UseVisualStyleBackColor = false;
            this.btnSaveProxies.Click += new System.EventHandler(this.btnSaveProxies_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(306, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Header Updater";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(551, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelProxy);
            this.Controls.Add(this.panelBotManager);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.btnActions);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonnie Bots";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelBotManager.ResumeLayout(false);
            this.panelProxy.ResumeLayout(false);
            this.panelProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericProxyQuant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSSOList;
        private System.Windows.Forms.Button btnOpenGrab;
        private System.Windows.Forms.Button btnActions;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Button btnEnterRoom;
        private System.Windows.Forms.Button btnRespectUser;
        private System.Windows.Forms.TextBox txtRespectUserId;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.TextBox txtTalk;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtXpos;
        private System.Windows.Forms.Button btnWalkAround;
        private System.Windows.Forms.Button btnDance;
        private System.Windows.Forms.Button btnSit;
        private System.Windows.Forms.Button btnChangeClothes;
        private System.Windows.Forms.TextBox txtFigureString;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnScratch;
        private System.Windows.Forms.TextBox txtPetId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBotCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Panel panelBotManager;
        private System.Windows.Forms.Button btnAddBot;
        private System.Windows.Forms.Button btnRemoveBot;
        private System.Windows.Forms.Button btnClearUsingBots;
        private System.Windows.Forms.ListView skoreBotList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView skoreUsingBots;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox ckbProxy;
        private System.Windows.Forms.Panel panelProxy;
        private System.Windows.Forms.Button btnSaveProxies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericProxyQuant;
        private System.Windows.Forms.TextBox txtProxyList;
        private System.Windows.Forms.Button button1;
    }
}

