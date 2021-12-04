namespace PhotoEditor
{
    partial class DrawPhoto
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
            this.bgw_combobox = new System.ComponentModel.BackgroundWorker();
            this.pan_drawing = new System.Windows.Forms.Panel();
            this.sKoreLabel1 = new Sulakore.Components.SKoreLabel();
            this.rad_paint = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new Sulakore.Components.SKoreButton();
            this.sKoreButton2 = new Sulakore.Components.SKoreButton();
            this.btn_insert_colorselect = new Sulakore.Components.SKoreButton();
            this.chk_mouseover = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lsv_image = new Sulakore.Components.SKoreListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cod_input = new System.Windows.Forms.ColorDialog();
            this.cod_input2 = new System.Windows.Forms.ColorDialog();
            this.sKoreLabel2 = new Sulakore.Components.SKoreLabel();
            this.chk_ignore = new System.Windows.Forms.CheckBox();
            this.nud_updatecolor = new System.Windows.Forms.NumericUpDown();
            this.sKoreButton1 = new Sulakore.Components.SKoreButton();
            this.sKoreButton3 = new Sulakore.Components.SKoreButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_x = new System.Windows.Forms.NumericUpDown();
            this.nud_y = new System.Windows.Forms.NumericUpDown();
            this.nud_z = new System.Windows.Forms.NumericUpDown();
            this.btn_insert = new Sulakore.Components.SKoreButton();
            this.btn_save = new Sulakore.Components.SKoreButton();
            this.btn_remove = new Sulakore.Components.SKoreButton();
            this.cbo_insert = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_updatecolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_z)).BeginInit();
            this.SuspendLayout();
            // 
            // bgw_combobox
            // 
            this.bgw_combobox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_combobox_DoWork);
            // 
            // pan_drawing
            // 
            this.pan_drawing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_drawing.Location = new System.Drawing.Point(8, 37);
            this.pan_drawing.Name = "pan_drawing";
            this.pan_drawing.Size = new System.Drawing.Size(320, 320);
            this.pan_drawing.TabIndex = 0;
            // 
            // sKoreLabel1
            // 
            this.sKoreLabel1.AnimationInterval = 0;
            this.sKoreLabel1.DisplayBoundary = true;
            this.sKoreLabel1.Location = new System.Drawing.Point(8, 365);
            this.sKoreLabel1.Name = "sKoreLabel1";
            this.sKoreLabel1.Size = new System.Drawing.Size(150, 20);
            this.sKoreLabel1.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreLabel1.TabIndex = 1;
            this.sKoreLabel1.Text = "Draw";
            // 
            // rad_paint
            // 
            this.rad_paint.AutoSize = true;
            this.rad_paint.Checked = true;
            this.rad_paint.Location = new System.Drawing.Point(13, 3);
            this.rad_paint.Name = "rad_paint";
            this.rad_paint.Size = new System.Drawing.Size(49, 17);
            this.rad_paint.TabIndex = 2;
            this.rad_paint.TabStop = true;
            this.rad_paint.Text = "Paint";
            this.rad_paint.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.sKoreButton2);
            this.panel1.Controls.Add(this.btn_insert_colorselect);
            this.panel1.Controls.Add(this.chk_mouseover);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rad_paint);
            this.panel1.Location = new System.Drawing.Point(7, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 75);
            this.panel1.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_clear.Location = new System.Drawing.Point(258, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(55, 20);
            this.btn_clear.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // sKoreButton2
            // 
            this.sKoreButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton2.Location = new System.Drawing.Point(202, 5);
            this.sKoreButton2.Name = "sKoreButton2";
            this.sKoreButton2.Size = new System.Drawing.Size(55, 20);
            this.sKoreButton2.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton2.TabIndex = 6;
            this.sKoreButton2.Text = "Fill";
            this.sKoreButton2.Click += new System.EventHandler(this.sKoreButton2_Click);
            // 
            // btn_insert_colorselect
            // 
            this.btn_insert_colorselect.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert_colorselect.Location = new System.Drawing.Point(146, 5);
            this.btn_insert_colorselect.Name = "btn_insert_colorselect";
            this.btn_insert_colorselect.Size = new System.Drawing.Size(55, 20);
            this.btn_insert_colorselect.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert_colorselect.TabIndex = 5;
            this.btn_insert_colorselect.Text = "Color";
            this.btn_insert_colorselect.Click += new System.EventHandler(this.btn_insert_colorselect_Click);
            // 
            // chk_mouseover
            // 
            this.chk_mouseover.AutoSize = true;
            this.chk_mouseover.Location = new System.Drawing.Point(13, 48);
            this.chk_mouseover.Name = "chk_mouseover";
            this.chk_mouseover.Size = new System.Drawing.Size(87, 17);
            this.chk_mouseover.TabIndex = 4;
            this.chk_mouseover.Text = "MouseHover";
            this.chk_mouseover.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Erease";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(332, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Picture Count:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_amount.Location = new System.Drawing.Point(405, 18);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_amount.TabIndex = 116;
            this.lbl_amount.Text = "0";
            // 
            // lsv_image
            // 
            this.lsv_image.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_image.FullRowSelect = true;
            this.lsv_image.GridLines = true;
            this.lsv_image.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsv_image.HideSelection = false;
            this.lsv_image.Location = new System.Drawing.Point(335, 34);
            this.lsv_image.MultiSelect = false;
            this.lsv_image.Name = "lsv_image";
            this.lsv_image.ShowItemToolTips = true;
            this.lsv_image.Size = new System.Drawing.Size(246, 402);
            this.lsv_image.TabIndex = 117;
            this.lsv_image.UseCompatibleStateImageBehavior = false;
            this.lsv_image.View = System.Windows.Forms.View.Details;
            this.lsv_image.SelectedIndexChanged += new System.EventHandler(this.lsv_image_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Row Index";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Column";
            this.columnHeader2.Width = 120;
            // 
            // sKoreLabel2
            // 
            this.sKoreLabel2.AnimationInterval = 0;
            this.sKoreLabel2.DisplayBoundary = true;
            this.sKoreLabel2.Location = new System.Drawing.Point(335, 442);
            this.sKoreLabel2.Name = "sKoreLabel2";
            this.sKoreLabel2.Size = new System.Drawing.Size(127, 20);
            this.sKoreLabel2.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreLabel2.TabIndex = 119;
            this.sKoreLabel2.Text = "Ignore Color";
            // 
            // chk_ignore
            // 
            this.chk_ignore.AutoSize = true;
            this.chk_ignore.Location = new System.Drawing.Point(492, 479);
            this.chk_ignore.Name = "chk_ignore";
            this.chk_ignore.Size = new System.Drawing.Size(83, 17);
            this.chk_ignore.TabIndex = 120;
            this.chk_ignore.Text = "Ignore Color";
            this.chk_ignore.UseVisualStyleBackColor = true;
            // 
            // nud_updatecolor
            // 
            this.nud_updatecolor.Location = new System.Drawing.Point(376, 478);
            this.nud_updatecolor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_updatecolor.Name = "nud_updatecolor";
            this.nud_updatecolor.Size = new System.Drawing.Size(113, 20);
            this.nud_updatecolor.TabIndex = 121;
            this.nud_updatecolor.ValueChanged += new System.EventHandler(this.nud_updatecolor_ValueChanged);
            // 
            // sKoreButton1
            // 
            this.sKoreButton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton1.Location = new System.Drawing.Point(335, 478);
            this.sKoreButton1.Name = "sKoreButton1";
            this.sKoreButton1.Size = new System.Drawing.Size(39, 20);
            this.sKoreButton1.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton1.TabIndex = 122;
            this.sKoreButton1.Text = "Color";
            this.sKoreButton1.Click += new System.EventHandler(this.sKoreButton1_Click);
            // 
            // sKoreButton3
            // 
            this.sKoreButton3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton3.Location = new System.Drawing.Point(340, 522);
            this.sKoreButton3.Name = "sKoreButton3";
            this.sKoreButton3.Size = new System.Drawing.Size(241, 20);
            this.sKoreButton3.Skin = System.Drawing.Color.DarkSeaGreen;
            this.sKoreButton3.TabIndex = 123;
            this.sKoreButton3.Text = "Load From Image";
            this.sKoreButton3.Click += new System.EventHandler(this.sKoreButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(332, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 1);
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Z:";
            // 
            // nud_x
            // 
            this.nud_x.Location = new System.Drawing.Point(30, 496);
            this.nud_x.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_x.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.nud_x.Name = "nud_x";
            this.nud_x.Size = new System.Drawing.Size(42, 20);
            this.nud_x.TabIndex = 128;
            // 
            // nud_y
            // 
            this.nud_y.Location = new System.Drawing.Point(95, 496);
            this.nud_y.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_y.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.nud_y.Name = "nud_y";
            this.nud_y.Size = new System.Drawing.Size(42, 20);
            this.nud_y.TabIndex = 129;
            // 
            // nud_z
            // 
            this.nud_z.DecimalPlaces = 13;
            this.nud_z.Location = new System.Drawing.Point(208, 498);
            this.nud_z.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_z.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.nud_z.Name = "nud_z";
            this.nud_z.Size = new System.Drawing.Size(120, 20);
            this.nud_z.TabIndex = 130;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert.Location = new System.Drawing.Point(7, 522);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(102, 20);
            this.btn_insert.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert.TabIndex = 131;
            this.btn_insert.Text = "Insert";
            this.btn_insert.Click += new System.EventHandler(this.sKoreButton4_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(114, 522);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 20);
            this.btn_save.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_save.TabIndex = 132;
            this.btn_save.Text = "Update";
            this.btn_save.Click += new System.EventHandler(this.sKoreButton5_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_remove.Enabled = false;
            this.btn_remove.Location = new System.Drawing.Point(219, 522);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(102, 20);
            this.btn_remove.Skin = System.Drawing.Color.DarkSeaGreen;
            this.btn_remove.TabIndex = 133;
            this.btn_remove.Text = "Remove";
            this.btn_remove.Click += new System.EventHandler(this.sKoreButton6_Click);
            // 
            // cbo_insert
            // 
            this.cbo_insert.FormattingEnabled = true;
            this.cbo_insert.Location = new System.Drawing.Point(8, 470);
            this.cbo_insert.Name = "cbo_insert";
            this.cbo_insert.Size = new System.Drawing.Size(320, 21);
            this.cbo_insert.TabIndex = 134;
            // 
            // DrawPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 550);
            this.Controls.Add(this.cbo_insert);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.nud_z);
            this.Controls.Add(this.nud_y);
            this.Controls.Add(this.nud_x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sKoreButton3);
            this.Controls.Add(this.sKoreButton1);
            this.Controls.Add(this.nud_updatecolor);
            this.Controls.Add(this.chk_ignore);
            this.Controls.Add(this.sKoreLabel2);
            this.Controls.Add(this.lsv_image);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sKoreLabel1);
            this.Controls.Add(this.pan_drawing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawPhoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawPhoto_FormClosing);
            this.Load += new System.EventHandler(this.DrawPhoto_Load);
            this.Shown += new System.EventHandler(this.DrawPhoto_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_updatecolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgw_combobox;
        private System.Windows.Forms.Panel pan_drawing;
        private Sulakore.Components.SKoreLabel sKoreLabel1;
        private System.Windows.Forms.RadioButton rad_paint;
        private System.Windows.Forms.Panel panel1;
        private Sulakore.Components.SKoreButton btn_clear;
        private Sulakore.Components.SKoreButton sKoreButton2;
        private Sulakore.Components.SKoreButton btn_insert_colorselect;
        private System.Windows.Forms.CheckBox chk_mouseover;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_amount;
        private Sulakore.Components.SKoreListView lsv_image;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColorDialog cod_input;
        private System.Windows.Forms.ColorDialog cod_input2;
        private Sulakore.Components.SKoreLabel sKoreLabel2;
        private System.Windows.Forms.CheckBox chk_ignore;
        private System.Windows.Forms.NumericUpDown nud_updatecolor;
        private Sulakore.Components.SKoreButton sKoreButton1;
        private Sulakore.Components.SKoreButton sKoreButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_x;
        private System.Windows.Forms.NumericUpDown nud_y;
        private System.Windows.Forms.NumericUpDown nud_z;
        private Sulakore.Components.SKoreButton btn_insert;
        private Sulakore.Components.SKoreButton btn_save;
        private Sulakore.Components.SKoreButton btn_remove;
        private System.Windows.Forms.ComboBox cbo_insert;
    }
}