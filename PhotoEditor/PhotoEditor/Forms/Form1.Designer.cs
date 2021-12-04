using System;
using ZTn.Json.JsonTreeView;

namespace PhotoEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txt_compressed = new Sulakore.Components.SKoreLabelBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sendtoserver = new Sulakore.Components.SKoreButton();
            this.sKoreButton4 = new Sulakore.Components.SKoreButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newHabboJsonPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habboJsonPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvisiblePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawInPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sKoreLabel1 = new Sulakore.Components.SKoreLabel();
            this.sKoreButton2 = new Sulakore.Components.SKoreButton();
            this.jsonValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sKoreButton1 = new Sulakore.Components.SKoreButton();
            this.sKoreButton3 = new Sulakore.Components.SKoreButton();
            this.sKoreButton5 = new Sulakore.Components.SKoreButton();
            this.jsonTreeView = new ZTn.Json.JsonTreeView.Views.JTokenTreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_compressed
            // 
            this.txt_compressed.BackColor = System.Drawing.SystemColors.Control;
            this.txt_compressed.Location = new System.Drawing.Point(0, 466);
            this.txt_compressed.Name = "txt_compressed";
            this.txt_compressed.Size = new System.Drawing.Size(509, 20);
            this.txt_compressed.Skin = System.Drawing.Color.DarkSeaGreen;
            this.txt_compressed.TabIndex = 1;
            this.txt_compressed.Text = "";
            this.txt_compressed.Title = "Packet";
            this.txt_compressed.Value = "";
            this.txt_compressed.ValueAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_compressed.ValueReadOnly = false;
            this.txt_compressed.TextChanged += new System.EventHandler(this.txt_compressed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(60, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Packet Length : ";
            // 
            // btn_sendtoserver
            // 
            this.btn_sendtoserver.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_sendtoserver.Location = new System.Drawing.Point(512, 466);
            this.btn_sendtoserver.Name = "btn_sendtoserver";
            this.btn_sendtoserver.Size = new System.Drawing.Size(83, 20);
            this.btn_sendtoserver.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_sendtoserver.TabIndex = 4;
            this.btn_sendtoserver.Text = "Send to Server";
            this.btn_sendtoserver.Click += new System.EventHandler(this.sKoreButton1_Click);
            // 
            // sKoreButton4
            // 
            this.sKoreButton4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton4.Location = new System.Drawing.Point(320, 37);
            this.sKoreButton4.Name = "sKoreButton4";
            this.sKoreButton4.Size = new System.Drawing.Size(72, 20);
            this.sKoreButton4.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton4.TabIndex = 7;
            this.sKoreButton4.Text = "Update";
            this.sKoreButton4.Click += new System.EventHandler(this.sKoreButton4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.photoToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newHabboJsonPhotoToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.photoToolStripMenuItem.Text = "Photo";
            // 
            // newHabboJsonPhotoToolStripMenuItem
            // 
            this.newHabboJsonPhotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habboJsonPhotoToolStripMenuItem,
            this.generateInvisiblePhotoToolStripMenuItem});
            this.newHabboJsonPhotoToolStripMenuItem.Name = "newHabboJsonPhotoToolStripMenuItem";
            this.newHabboJsonPhotoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newHabboJsonPhotoToolStripMenuItem.Text = "New";
            // 
            // habboJsonPhotoToolStripMenuItem
            // 
            this.habboJsonPhotoToolStripMenuItem.Name = "habboJsonPhotoToolStripMenuItem";
            this.habboJsonPhotoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.habboJsonPhotoToolStripMenuItem.Text = "Habbo Json Photo";
            this.habboJsonPhotoToolStripMenuItem.Click += new System.EventHandler(this.habboJsonPhotoToolStripMenuItem_Click);
            // 
            // generateInvisiblePhotoToolStripMenuItem
            // 
            this.generateInvisiblePhotoToolStripMenuItem.Name = "generateInvisiblePhotoToolStripMenuItem";
            this.generateInvisiblePhotoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.generateInvisiblePhotoToolStripMenuItem.Text = "Generate Invisible Photo";
            this.generateInvisiblePhotoToolStripMenuItem.Click += new System.EventHandler(this.generateInvisiblePhotoToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Close";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawInPhotoToolStripMenuItem,
            this.fixSpriteToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // drawInPhotoToolStripMenuItem
            // 
            this.drawInPhotoToolStripMenuItem.Name = "drawInPhotoToolStripMenuItem";
            this.drawInPhotoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.drawInPhotoToolStripMenuItem.Text = "Draw on Photo (10x10)";
            this.drawInPhotoToolStripMenuItem.Click += new System.EventHandler(this.drawInPhotoToolStripMenuItem_Click);
            // 
            // fixSpriteToolStripMenuItem
            // 
            this.fixSpriteToolStripMenuItem.Name = "fixSpriteToolStripMenuItem";
            this.fixSpriteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.fixSpriteToolStripMenuItem.Text = "Invert Sprite";
            this.fixSpriteToolStripMenuItem.Click += new System.EventHandler(this.fixSpriteToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwayOnTopToolStripMenuItem,
            this.thumbnailModeToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // alwayOnTopToolStripMenuItem
            // 
            this.alwayOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwayOnTopToolStripMenuItem.Name = "alwayOnTopToolStripMenuItem";
            this.alwayOnTopToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.alwayOnTopToolStripMenuItem.Text = "Alway on Top";
            this.alwayOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwayOnTopToolStripMenuItem_Click);
            // 
            // thumbnailModeToolStripMenuItem
            // 
            this.thumbnailModeToolStripMenuItem.CheckOnClick = true;
            this.thumbnailModeToolStripMenuItem.Name = "thumbnailModeToolStripMenuItem";
            this.thumbnailModeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.thumbnailModeToolStripMenuItem.Text = "Thumbnail Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(5, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 1);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(5, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // sKoreLabel1
            // 
            this.sKoreLabel1.AnimationInterval = 0;
            this.sKoreLabel1.DisplayBoundary = true;
            this.sKoreLabel1.Location = new System.Drawing.Point(164, 37);
            this.sKoreLabel1.Name = "sKoreLabel1";
            this.sKoreLabel1.Size = new System.Drawing.Size(150, 20);
            this.sKoreLabel1.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreLabel1.TabIndex = 11;
            this.sKoreLabel1.Text = "JSON Editor";
            // 
            // sKoreButton2
            // 
            this.sKoreButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton2.Location = new System.Drawing.Point(476, 37);
            this.sKoreButton2.Name = "sKoreButton2";
            this.sKoreButton2.Size = new System.Drawing.Size(72, 20);
            this.sKoreButton2.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton2.TabIndex = 12;
            this.sKoreButton2.Text = "Compress";
            this.sKoreButton2.Click += new System.EventHandler(this.sKoreButton2_Click);
            // 
            // jsonValueTextBox
            // 
            this.jsonValueTextBox.Location = new System.Drawing.Point(320, 60);
            this.jsonValueTextBox.MaxLength = 99999999;
            this.jsonValueTextBox.Multiline = true;
            this.jsonValueTextBox.Name = "jsonValueTextBox";
            this.jsonValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonValueTextBox.Size = new System.Drawing.Size(268, 385);
            this.jsonValueTextBox.TabIndex = 14;
            this.jsonValueTextBox.TextChanged += new System.EventHandler(this.jsonValueTextBox_TextChanged);
            this.jsonValueTextBox.Enter += new System.EventHandler(this.jsonValueTextBox_Enter);
            this.jsonValueTextBox.Leave += new System.EventHandler(this.jsonValueTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(141, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // sKoreButton1
            // 
            this.sKoreButton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton1.Location = new System.Drawing.Point(398, 37);
            this.sKoreButton1.Name = "sKoreButton1";
            this.sKoreButton1.Size = new System.Drawing.Size(72, 20);
            this.sKoreButton1.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton1.TabIndex = 16;
            this.sKoreButton1.Text = "Decompress";
            this.sKoreButton1.Click += new System.EventHandler(this.sKoreButton1_Click_1);
            // 
            // sKoreButton3
            // 
            this.sKoreButton3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton3.Location = new System.Drawing.Point(8, 37);
            this.sKoreButton3.Name = "sKoreButton3";
            this.sKoreButton3.Size = new System.Drawing.Size(70, 20);
            this.sKoreButton3.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton3.TabIndex = 18;
            this.sKoreButton3.Text = "Import";
            this.sKoreButton3.Click += new System.EventHandler(this.sKoreButton3_Click);
            // 
            // sKoreButton5
            // 
            this.sKoreButton5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton5.Location = new System.Drawing.Point(84, 37);
            this.sKoreButton5.Name = "sKoreButton5";
            this.sKoreButton5.Size = new System.Drawing.Size(70, 20);
            this.sKoreButton5.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton5.TabIndex = 19;
            this.sKoreButton5.Text = "Export";
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.AllowDrop = true;
            this.jsonTreeView.HideSelection = false;
            this.jsonTreeView.Location = new System.Drawing.Point(8, 60);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(306, 385);
            this.jsonTreeView.TabIndex = 0;
            this.jsonTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.jsonTreeView_AfterCollapse);
            this.jsonTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.jsonTreeView_AfterExpand);
            this.jsonTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.jsonTreeView_AfterSelect);
            this.jsonTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.jsonTreeView_NodeMouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 522);
            this.Controls.Add(this.sKoreButton5);
            this.Controls.Add(this.sKoreButton3);
            this.Controls.Add(this.sKoreButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jsonValueTextBox);
            this.Controls.Add(this.jsonTreeView);
            this.Controls.Add(this.sKoreButton2);
            this.Controls.Add(this.sKoreLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sKoreButton4);
            this.Controls.Add(this.btn_sendtoserver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_compressed);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.05F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-Earth - Photo Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Sulakore.Components.SKoreLabelBox txt_compressed;
        private System.Windows.Forms.Label label1;
        private Sulakore.Components.SKoreButton btn_sendtoserver;
        private Sulakore.Components.SKoreButton sKoreButton4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Sulakore.Components.SKoreLabel sKoreLabel1;
        private Sulakore.Components.SKoreButton sKoreButton2;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawInPhotoToolStripMenuItem;
        private ZTn.Json.JsonTreeView.Views.JTokenTreeView jsonTreeView;
        private System.Windows.Forms.ToolStripMenuItem newHabboJsonPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habboJsonPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvisiblePhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox jsonValueTextBox;
        private System.Windows.Forms.Label label3;
        private Sulakore.Components.SKoreButton sKoreButton1;
        private Sulakore.Components.SKoreButton sKoreButton3;
        private Sulakore.Components.SKoreButton sKoreButton5;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem alwayOnTopToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem thumbnailModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixSpriteToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

