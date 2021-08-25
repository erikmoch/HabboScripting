namespace Tween_Bot_V3_Module
{
    partial class MainModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbTanjiRoom = new System.Windows.Forms.CheckBox();
            this.cbTanjiClothes = new System.Windows.Forms.CheckBox();
            this.cbTanjiWalk = new System.Windows.Forms.CheckBox();
            this.cbTanjiRespect = new System.Windows.Forms.CheckBox();
            this.cbTanjiScratch = new System.Windows.Forms.CheckBox();
            this.btnConnect = new Sulakore.Components.SKoreButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(248, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 37);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Tween_Bot_V3_Module.Properties.Resources.errorwhite;
            this.pictureBox2.Location = new System.Drawing.Point(284, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "by Tween";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TWEEN BOT V3";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatus.Location = new System.Drawing.Point(170, 133);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(156, 30);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Desconectado.";
            this.lblStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblStatus_MouseDown);
            this.lblStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblStatus_MouseMove);
            // 
            // cbTanjiRoom
            // 
            this.cbTanjiRoom.AutoSize = true;
            this.cbTanjiRoom.ForeColor = System.Drawing.Color.White;
            this.cbTanjiRoom.Location = new System.Drawing.Point(178, 122);
            this.cbTanjiRoom.Name = "cbTanjiRoom";
            this.cbTanjiRoom.Size = new System.Drawing.Size(89, 17);
            this.cbTanjiRoom.TabIndex = 9;
            this.cbTanjiRoom.Text = "Seguir quarto";
            this.cbTanjiRoom.UseVisualStyleBackColor = true;
            this.cbTanjiRoom.CheckedChanged += new System.EventHandler(this.cbTanjiRoom_CheckedChanged);
            // 
            // cbTanjiClothes
            // 
            this.cbTanjiClothes.AutoSize = true;
            this.cbTanjiClothes.ForeColor = System.Drawing.Color.White;
            this.cbTanjiClothes.Location = new System.Drawing.Point(178, 43);
            this.cbTanjiClothes.Name = "cbTanjiClothes";
            this.cbTanjiClothes.Size = new System.Drawing.Size(129, 17);
            this.cbTanjiClothes.TabIndex = 8;
            this.cbTanjiClothes.Text = "Copiar visual ao clicar";
            this.cbTanjiClothes.UseVisualStyleBackColor = true;
            this.cbTanjiClothes.CheckedChanged += new System.EventHandler(this.cbTanjiClothes_CheckedChanged);
            // 
            // cbTanjiWalk
            // 
            this.cbTanjiWalk.AutoSize = true;
            this.cbTanjiWalk.ForeColor = System.Drawing.Color.White;
            this.cbTanjiWalk.Location = new System.Drawing.Point(178, 102);
            this.cbTanjiWalk.Name = "cbTanjiWalk";
            this.cbTanjiWalk.Size = new System.Drawing.Size(92, 17);
            this.cbTanjiWalk.TabIndex = 7;
            this.cbTanjiWalk.Text = "Seguir passos";
            this.cbTanjiWalk.UseVisualStyleBackColor = true;
            this.cbTanjiWalk.CheckedChanged += new System.EventHandler(this.cbTanjiWalk_CheckedChanged);
            // 
            // cbTanjiRespect
            // 
            this.cbTanjiRespect.AutoSize = true;
            this.cbTanjiRespect.ForeColor = System.Drawing.Color.White;
            this.cbTanjiRespect.Location = new System.Drawing.Point(178, 62);
            this.cbTanjiRespect.Name = "cbTanjiRespect";
            this.cbTanjiRespect.Size = new System.Drawing.Size(114, 17);
            this.cbTanjiRespect.TabIndex = 5;
            this.cbTanjiRespect.Text = "Respeitar ao clicar";
            this.cbTanjiRespect.UseVisualStyleBackColor = true;
            this.cbTanjiRespect.CheckedChanged += new System.EventHandler(this.cbTanjiRespect_CheckedChanged);
            // 
            // cbTanjiScratch
            // 
            this.cbTanjiScratch.AutoSize = true;
            this.cbTanjiScratch.ForeColor = System.Drawing.Color.White;
            this.cbTanjiScratch.Location = new System.Drawing.Point(178, 82);
            this.cbTanjiScratch.Name = "cbTanjiScratch";
            this.cbTanjiScratch.Size = new System.Drawing.Size(110, 17);
            this.cbTanjiScratch.TabIndex = 6;
            this.cbTanjiScratch.Text = "Acariciar ao clicar";
            this.cbTanjiScratch.UseVisualStyleBackColor = true;
            this.cbTanjiScratch.CheckedChanged += new System.EventHandler(this.cbTanjiScratch_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Black;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(14, 134);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 27);
            this.btnConnect.Skin = System.Drawing.Color.Black;
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tween_Bot_V3_Module.Properties.Resources.tanji;
            this.pictureBox1.Location = new System.Drawing.Point(0, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // MainModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(324, 166);
            this.Controls.Add(this.cbTanjiRoom);
            this.Controls.Add(this.cbTanjiClothes);
            this.Controls.Add(this.cbTanjiWalk);
            this.Controls.Add(this.cbTanjiRespect);
            this.Controls.Add(this.cbTanjiScratch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tween Bot V3";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private Sulakore.Components.SKoreButton btnConnect;
        private System.Windows.Forms.CheckBox cbTanjiRoom;
        private System.Windows.Forms.CheckBox cbTanjiClothes;
        private System.Windows.Forms.CheckBox cbTanjiWalk;
        private System.Windows.Forms.CheckBox cbTanjiRespect;
        private System.Windows.Forms.CheckBox cbTanjiScratch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label btnMinimize;
    }
}

