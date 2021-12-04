namespace PhotoEditor
{
    partial class NewPhoto
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
            this.sKoreButton1 = new Sulakore.Components.SKoreButton();
            this.sKoreLabel1 = new Sulakore.Components.SKoreLabel();
            this.nud_roomid = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_insert_updatecolor = new System.Windows.Forms.NumericUpDown();
            this.btn_insert_colorselect = new Sulakore.Components.SKoreButton();
            this.chk_transparent = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_custom_checksum = new System.Windows.Forms.NumericUpDown();
            this.nud_custom_timestamp = new System.Windows.Forms.NumericUpDown();
            this.nud_custom_status = new System.Windows.Forms.NumericUpDown();
            this.chk_custom_checksum = new System.Windows.Forms.CheckBox();
            this.chk_custom_timestamp = new System.Windows.Forms.CheckBox();
            this.chk_custom_status = new System.Windows.Forms.CheckBox();
            this.chk_zoom = new System.Windows.Forms.CheckBox();
            this.cod_input = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_roomid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_insert_updatecolor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_custom_checksum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_custom_timestamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_custom_status)).BeginInit();
            this.SuspendLayout();
            // 
            // sKoreButton1
            // 
            this.sKoreButton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton1.Location = new System.Drawing.Point(11, 167);
            this.sKoreButton1.Name = "sKoreButton1";
            this.sKoreButton1.Size = new System.Drawing.Size(208, 20);
            this.sKoreButton1.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton1.TabIndex = 0;
            this.sKoreButton1.Text = "Create Photo";
            this.sKoreButton1.Click += new System.EventHandler(this.sKoreButton1_Click);
            // 
            // sKoreLabel1
            // 
            this.sKoreLabel1.Location = new System.Drawing.Point(-11, 9);
            this.sKoreLabel1.Name = "sKoreLabel1";
            this.sKoreLabel1.Size = new System.Drawing.Size(112, 20);
            this.sKoreLabel1.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreLabel1.TabIndex = 1;
            this.sKoreLabel1.Text = "Room ID :";
            // 
            // nud_roomid
            // 
            this.nud_roomid.Location = new System.Drawing.Point(103, 10);
            this.nud_roomid.Name = "nud_roomid";
            this.nud_roomid.Size = new System.Drawing.Size(84, 20);
            this.nud_roomid.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_insert_updatecolor);
            this.groupBox1.Controls.Add(this.btn_insert_colorselect);
            this.groupBox1.Controls.Add(this.chk_transparent);
            this.groupBox1.Location = new System.Drawing.Point(11, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BackColor";
            // 
            // nud_insert_updatecolor
            // 
            this.nud_insert_updatecolor.BackColor = System.Drawing.SystemColors.Window;
            this.nud_insert_updatecolor.Location = new System.Drawing.Point(40, 18);
            this.nud_insert_updatecolor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_insert_updatecolor.Name = "nud_insert_updatecolor";
            this.nud_insert_updatecolor.Size = new System.Drawing.Size(76, 20);
            this.nud_insert_updatecolor.TabIndex = 2;
            // 
            // btn_insert_colorselect
            // 
            this.btn_insert_colorselect.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert_colorselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert_colorselect.Location = new System.Drawing.Point(7, 18);
            this.btn_insert_colorselect.Name = "btn_insert_colorselect";
            this.btn_insert_colorselect.Size = new System.Drawing.Size(30, 20);
            this.btn_insert_colorselect.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert_colorselect.TabIndex = 1;
            this.btn_insert_colorselect.Text = "S";
            this.btn_insert_colorselect.Click += new System.EventHandler(this.btn_insert_colorselect_Click);
            // 
            // chk_transparent
            // 
            this.chk_transparent.AutoSize = true;
            this.chk_transparent.Location = new System.Drawing.Point(120, 20);
            this.chk_transparent.Name = "chk_transparent";
            this.chk_transparent.Size = new System.Drawing.Size(83, 17);
            this.chk_transparent.TabIndex = 0;
            this.chk_transparent.Text = "Transparent";
            this.chk_transparent.UseVisualStyleBackColor = true;
            this.chk_transparent.CheckedChanged += new System.EventHandler(this.chk_transparent_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_custom_checksum);
            this.groupBox2.Controls.Add(this.nud_custom_timestamp);
            this.groupBox2.Controls.Add(this.nud_custom_status);
            this.groupBox2.Controls.Add(this.chk_custom_checksum);
            this.groupBox2.Controls.Add(this.chk_custom_timestamp);
            this.groupBox2.Controls.Add(this.chk_custom_status);
            this.groupBox2.Location = new System.Drawing.Point(11, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced";
            // 
            // nud_custom_checksum
            // 
            this.nud_custom_checksum.Location = new System.Drawing.Point(126, 52);
            this.nud_custom_checksum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_custom_checksum.Name = "nud_custom_checksum";
            this.nud_custom_checksum.Size = new System.Drawing.Size(76, 20);
            this.nud_custom_checksum.TabIndex = 5;
            // 
            // nud_custom_timestamp
            // 
            this.nud_custom_timestamp.Location = new System.Drawing.Point(127, 31);
            this.nud_custom_timestamp.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_custom_timestamp.Name = "nud_custom_timestamp";
            this.nud_custom_timestamp.Size = new System.Drawing.Size(76, 20);
            this.nud_custom_timestamp.TabIndex = 4;
            // 
            // nud_custom_status
            // 
            this.nud_custom_status.Location = new System.Drawing.Point(127, 9);
            this.nud_custom_status.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_custom_status.Name = "nud_custom_status";
            this.nud_custom_status.Size = new System.Drawing.Size(76, 20);
            this.nud_custom_status.TabIndex = 3;
            // 
            // chk_custom_checksum
            // 
            this.chk_custom_checksum.AutoSize = true;
            this.chk_custom_checksum.Location = new System.Drawing.Point(6, 55);
            this.chk_custom_checksum.Name = "chk_custom_checksum";
            this.chk_custom_checksum.Size = new System.Drawing.Size(119, 17);
            this.chk_custom_checksum.TabIndex = 2;
            this.chk_custom_checksum.Text = "Custom checksum :";
            this.chk_custom_checksum.UseVisualStyleBackColor = true;
            // 
            // chk_custom_timestamp
            // 
            this.chk_custom_timestamp.AutoSize = true;
            this.chk_custom_timestamp.Location = new System.Drawing.Point(6, 35);
            this.chk_custom_timestamp.Name = "chk_custom_timestamp";
            this.chk_custom_timestamp.Size = new System.Drawing.Size(117, 17);
            this.chk_custom_timestamp.TabIndex = 1;
            this.chk_custom_timestamp.Text = "Custom timestamp :";
            this.chk_custom_timestamp.UseVisualStyleBackColor = true;
            // 
            // chk_custom_status
            // 
            this.chk_custom_status.AutoSize = true;
            this.chk_custom_status.Location = new System.Drawing.Point(6, 16);
            this.chk_custom_status.Name = "chk_custom_status";
            this.chk_custom_status.Size = new System.Drawing.Size(98, 17);
            this.chk_custom_status.TabIndex = 0;
            this.chk_custom_status.Text = "Custom status :";
            this.chk_custom_status.UseVisualStyleBackColor = true;
            // 
            // chk_zoom
            // 
            this.chk_zoom.AutoSize = true;
            this.chk_zoom.Location = new System.Drawing.Point(190, 13);
            this.chk_zoom.Name = "chk_zoom";
            this.chk_zoom.Size = new System.Drawing.Size(33, 17);
            this.chk_zoom.TabIndex = 6;
            this.chk_zoom.Text = "Z";
            this.chk_zoom.UseVisualStyleBackColor = true;
            // 
            // NewPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(225, 191);
            this.Controls.Add(this.chk_zoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nud_roomid);
            this.Controls.Add(this.sKoreLabel1);
            this.Controls.Add(this.sKoreButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New photo";
            this.Activated += new System.EventHandler(this.NewPhoto_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPhoto_FormClosing);
            this.Load += new System.EventHandler(this.NewPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_roomid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_insert_updatecolor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_custom_checksum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_custom_timestamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_custom_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton sKoreButton1;
        private Sulakore.Components.SKoreLabel sKoreLabel1;
        private System.Windows.Forms.NumericUpDown nud_roomid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_insert_updatecolor;
        private Sulakore.Components.SKoreButton btn_insert_colorselect;
        private System.Windows.Forms.CheckBox chk_transparent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_custom_checksum;
        private System.Windows.Forms.NumericUpDown nud_custom_timestamp;
        private System.Windows.Forms.NumericUpDown nud_custom_status;
        private System.Windows.Forms.CheckBox chk_custom_checksum;
        private System.Windows.Forms.CheckBox chk_custom_timestamp;
        private System.Windows.Forms.CheckBox chk_custom_status;
        private System.Windows.Forms.CheckBox chk_zoom;
        private System.Windows.Forms.ColorDialog cod_input;
    }
}