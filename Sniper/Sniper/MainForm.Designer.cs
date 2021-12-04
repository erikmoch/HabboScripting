namespace Sniper
{
    partial class MainForm
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
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.tbSearchFurni = new MonoFlat.MonoFlat_TextBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.btnRemoveItem = new MonoFlat.MonoFlat_Button();
            this.btnExport = new MonoFlat.MonoFlat_Button();
            this.btnImport = new MonoFlat.MonoFlat_Button();
            this.monoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            this.lbPurchased = new System.Windows.Forms.ListBox();
            this.btnSaveItem = new MonoFlat.MonoFlat_Button();
            this.tbFurniMaxPrice = new MonoFlat.MonoFlat_TextBox();
            this.tbFurniType = new MonoFlat.MonoFlat_TextBox();
            this.tbFurniID = new MonoFlat.MonoFlat_TextBox();
            this.tbFurniName = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.cbInterceptItemInfo = new MonoFlat.MonoFlat_Toggle();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.cbBotOn = new MonoFlat.MonoFlat_Toggle();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbSearchFurni);
            this.monoFlat_ThemeContainer1.Controls.Add(this.cbItems);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnRemoveItem);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnExport);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnImport);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.lbPurchased);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnSaveItem);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbFurniMaxPrice);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbFurniType);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbFurniID);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbFurniName);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label4);
            this.monoFlat_ThemeContainer1.Controls.Add(this.cbInterceptItemInfo);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.cbBotOn);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.lbItems);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(568, 455);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Sniper";
            this.monoFlat_ThemeContainer1.Click += new System.EventHandler(this.MonoFlat_ThemeContainer1_Click);
            // 
            // tbSearchFurni
            // 
            this.tbSearchFurni.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchFurni.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSearchFurni.ForeColor = System.Drawing.Color.White;
            this.tbSearchFurni.Image = null;
            this.tbSearchFurni.Location = new System.Drawing.Point(182, 140);
            this.tbSearchFurni.MaxLength = 32767;
            this.tbSearchFurni.Multiline = false;
            this.tbSearchFurni.Name = "tbSearchFurni";
            this.tbSearchFurni.ReadOnly = false;
            this.tbSearchFurni.Size = new System.Drawing.Size(203, 41);
            this.tbSearchFurni.TabIndex = 23;
            this.tbSearchFurni.Text = "Search Furni";
            this.tbSearchFurni.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchFurni.UseSystemPasswordChar = false;
            this.tbSearchFurni.TextChanged += new System.EventHandler(this.TbSearchFurni_TextChanged);
            // 
            // cbItems
            // 
            this.cbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.cbItems.ForeColor = System.Drawing.Color.White;
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(182, 187);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(203, 23);
            this.cbItems.TabIndex = 22;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.CbItems_SelectedIndexChanged);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveItem.Image = null;
            this.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.Location = new System.Drawing.Point(182, 404);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(203, 41);
            this.btnRemoveItem.TabIndex = 21;
            this.btnRemoveItem.Text = "Remove Item from watch";
            this.btnRemoveItem.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExport.Image = null;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(391, 403);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(165, 41);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export Items";
            this.btnExport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnImport.Image = null;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(13, 404);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(164, 41);
            this.btnImport.TabIndex = 19;
            this.btnImport.Text = "Import Items";
            this.btnImport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // monoFlat_HeaderLabel2
            // 
            this.monoFlat_HeaderLabel2.AutoSize = true;
            this.monoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel2.Location = new System.Drawing.Point(405, 69);
            this.monoFlat_HeaderLabel2.Name = "monoFlat_HeaderLabel2";
            this.monoFlat_HeaderLabel2.Size = new System.Drawing.Size(125, 20);
            this.monoFlat_HeaderLabel2.TabIndex = 17;
            this.monoFlat_HeaderLabel2.Text = "Items Purchased";
            // 
            // lbPurchased
            // 
            this.lbPurchased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lbPurchased.ForeColor = System.Drawing.Color.White;
            this.lbPurchased.FormattingEnabled = true;
            this.lbPurchased.ItemHeight = 15;
            this.lbPurchased.Location = new System.Drawing.Point(391, 93);
            this.lbPurchased.Name = "lbPurchased";
            this.lbPurchased.Size = new System.Drawing.Size(164, 304);
            this.lbPurchased.TabIndex = 18;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveItem.Image = null;
            this.btnSaveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveItem.Location = new System.Drawing.Point(182, 357);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(203, 41);
            this.btnSaveItem.TabIndex = 16;
            this.btnSaveItem.Text = "Save Item to watch";
            this.btnSaveItem.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveItem.Click += new System.EventHandler(this.BtnSaveItem_Click);
            // 
            // tbFurniMaxPrice
            // 
            this.tbFurniMaxPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbFurniMaxPrice.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbFurniMaxPrice.ForeColor = System.Drawing.Color.White;
            this.tbFurniMaxPrice.Image = null;
            this.tbFurniMaxPrice.Location = new System.Drawing.Point(182, 310);
            this.tbFurniMaxPrice.MaxLength = 32767;
            this.tbFurniMaxPrice.Multiline = false;
            this.tbFurniMaxPrice.Name = "tbFurniMaxPrice";
            this.tbFurniMaxPrice.ReadOnly = false;
            this.tbFurniMaxPrice.Size = new System.Drawing.Size(203, 41);
            this.tbFurniMaxPrice.TabIndex = 15;
            this.tbFurniMaxPrice.Text = "Max Purchase Price";
            this.tbFurniMaxPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFurniMaxPrice.UseSystemPasswordChar = false;
            // 
            // tbFurniType
            // 
            this.tbFurniType.BackColor = System.Drawing.Color.Transparent;
            this.tbFurniType.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbFurniType.ForeColor = System.Drawing.Color.White;
            this.tbFurniType.Image = null;
            this.tbFurniType.Location = new System.Drawing.Point(182, 263);
            this.tbFurniType.MaxLength = 32767;
            this.tbFurniType.Multiline = false;
            this.tbFurniType.Name = "tbFurniType";
            this.tbFurniType.ReadOnly = true;
            this.tbFurniType.Size = new System.Drawing.Size(203, 41);
            this.tbFurniType.TabIndex = 14;
            this.tbFurniType.Text = "Furni Type";
            this.tbFurniType.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFurniType.UseSystemPasswordChar = false;
            // 
            // tbFurniID
            // 
            this.tbFurniID.BackColor = System.Drawing.Color.Transparent;
            this.tbFurniID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbFurniID.ForeColor = System.Drawing.Color.White;
            this.tbFurniID.Image = null;
            this.tbFurniID.Location = new System.Drawing.Point(375, 12);
            this.tbFurniID.MaxLength = 32767;
            this.tbFurniID.Multiline = false;
            this.tbFurniID.Name = "tbFurniID";
            this.tbFurniID.ReadOnly = true;
            this.tbFurniID.Size = new System.Drawing.Size(10, 41);
            this.tbFurniID.TabIndex = 13;
            this.tbFurniID.Text = "Furni ID";
            this.tbFurniID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFurniID.UseSystemPasswordChar = false;
            this.tbFurniID.Visible = false;
            // 
            // tbFurniName
            // 
            this.tbFurniName.BackColor = System.Drawing.Color.Transparent;
            this.tbFurniName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbFurniName.ForeColor = System.Drawing.Color.White;
            this.tbFurniName.Image = null;
            this.tbFurniName.Location = new System.Drawing.Point(182, 216);
            this.tbFurniName.MaxLength = 32767;
            this.tbFurniName.Multiline = false;
            this.tbFurniName.Name = "tbFurniName";
            this.tbFurniName.ReadOnly = true;
            this.tbFurniName.Size = new System.Drawing.Size(203, 41);
            this.tbFurniName.TabIndex = 12;
            this.tbFurniName.Text = "Furni Name";
            this.tbFurniName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFurniName.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label4.Location = new System.Drawing.Point(283, 80);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(81, 15);
            this.monoFlat_Label4.TabIndex = 11;
            this.monoFlat_Label4.Text = "Intercept Item";
            // 
            // cbInterceptItemInfo
            // 
            this.cbInterceptItemInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInterceptItemInfo.Location = new System.Drawing.Point(286, 99);
            this.cbInterceptItemInfo.Name = "cbInterceptItemInfo";
            this.cbInterceptItemInfo.Size = new System.Drawing.Size(76, 33);
            this.cbInterceptItemInfo.TabIndex = 10;
            this.cbInterceptItemInfo.Text = "monoFlat_Toggle2";
            this.cbInterceptItemInfo.Toggled = false;
            this.cbInterceptItemInfo.Type = MonoFlat.MonoFlat_Toggle._Type.OnOff;
            this.cbInterceptItemInfo.ToggledChanged += new MonoFlat.MonoFlat_Toggle.ToggledChangedEventHandler(this.CbInterceptItemInfo_ToggledChanged);
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(221, 80);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(44, 15);
            this.monoFlat_Label1.TabIndex = 5;
            this.monoFlat_Label1.Text = "Bot On";
            // 
            // cbBotOn
            // 
            this.cbBotOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBotOn.Location = new System.Drawing.Point(204, 99);
            this.cbBotOn.Name = "cbBotOn";
            this.cbBotOn.Size = new System.Drawing.Size(76, 33);
            this.cbBotOn.TabIndex = 4;
            this.cbBotOn.Text = "monoFlat_Toggle1";
            this.cbBotOn.Toggled = false;
            this.cbBotOn.Type = MonoFlat.MonoFlat_Toggle._Type.OnOff;
            this.cbBotOn.ToggledChanged += new MonoFlat.MonoFlat_Toggle.ToggledChangedEventHandler(this.CbBotOn_ToggledChanged);
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(39, 69);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(114, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 2;
            this.monoFlat_HeaderLabel1.Text = "Items to watch";
            // 
            // lbItems
            // 
            this.lbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lbItems.ForeColor = System.Drawing.Color.White;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 15;
            this.lbItems.Location = new System.Drawing.Point(12, 93);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(164, 304);
            this.lbItems.TabIndex = 3;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.LbItems_SelectedIndexChanged);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(456, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 0;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 455);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniper";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private System.Windows.Forms.ListBox lbItems;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Toggle cbBotOn;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private MonoFlat.MonoFlat_Toggle cbInterceptItemInfo;
        private MonoFlat.MonoFlat_TextBox tbFurniType;
        private MonoFlat.MonoFlat_TextBox tbFurniID;
        private MonoFlat.MonoFlat_TextBox tbFurniName;
        private MonoFlat.MonoFlat_Button btnSaveItem;
        private MonoFlat.MonoFlat_TextBox tbFurniMaxPrice;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel2;
        private System.Windows.Forms.ListBox lbPurchased;
        private MonoFlat.MonoFlat_Button btnExport;
        private MonoFlat.MonoFlat_Button btnImport;
        private MonoFlat.MonoFlat_Button btnRemoveItem;
        private MonoFlat.MonoFlat_TextBox tbSearchFurni;
        private System.Windows.Forms.ComboBox cbItems;
    }
}

