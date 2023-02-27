// Token: 0x02000019 RID: 25
public partial class NovoFatum : global::System.Windows.Forms.Form
{
	// Token: 0x060000CA RID: 202 RVA: 0x00002DFF File Offset: 0x00000FFF
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
	private void InitializeComponent()
	{
		this.button1 = new global::System.Windows.Forms.Button();
		this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.label4 = new global::System.Windows.Forms.Label();
		this.label5 = new global::System.Windows.Forms.Label();
		this.label6 = new global::System.Windows.Forms.Label();
		this.label7 = new global::System.Windows.Forms.Label();
		this.label8 = new global::System.Windows.Forms.Label();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 1;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		this.pictureBox2.Image = global::NovoFatum_R3.Properties.Resources.Bitmap_6;
		this.pictureBox2.Location = new global::System.Drawing.Point(262, 104);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new global::System.Drawing.Size(138, 116);
		this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 4;
		this.pictureBox2.TabStop = false;
		this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(95, 285);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(459, 62);
		this.label1.TabIndex = 23;
		this.label1.Text = "NovoFatum eXtreme";
		this.label1.Click += new global::System.EventHandler(this.label1_Click);
		this.label2.AutoSize = true;
		this.label2.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(12, 134);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(182, 62);
		this.label2.TabIndex = 24;
		this.label2.Text = "ShenkX";
		this.label2.Click += new global::System.EventHandler(this.label2_Click);
		this.label3.AutoSize = true;
		this.label3.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label3.Location = new global::System.Drawing.Point(49, 223);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(145, 62);
		this.label3.TabIndex = 25;
		this.label3.Text = "LittleJ";
		this.label3.Click += new global::System.EventHandler(this.label3_Click);
		this.label4.AutoSize = true;
		this.label4.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label4.Location = new global::System.Drawing.Point(27, 39);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(254, 62);
		this.label4.TabIndex = 26;
		this.label4.Text = "HabboDEV";
		this.label4.Click += new global::System.EventHandler(this.label4_Click);
		this.label5.AutoSize = true;
		this.label5.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label5.Location = new global::System.Drawing.Point(406, 158);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(282, 62);
		this.label5.TabIndex = 27;
		this.label5.Text = "KekoMundo";
		this.label5.Click += new global::System.EventHandler(this.label5_Click);
		this.label6.AutoSize = true;
		this.label6.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label6.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label6.Location = new global::System.Drawing.Point(381, 9);
		this.label6.Name = "label6";
		this.label6.Size = new global::System.Drawing.Size(201, 62);
		this.label6.TabIndex = 28;
		this.label6.Text = "Darkbox";
		this.label6.Click += new global::System.EventHandler(this.label6_Click);
		this.label7.AutoSize = true;
		this.label7.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label7.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label7.Location = new global::System.Drawing.Point(341, 223);
		this.label7.Name = "label7";
		this.label7.Size = new global::System.Drawing.Size(338, 62);
		this.label7.TabIndex = 29;
		this.label7.Text = "Team Scripting";
		this.label7.Click += new global::System.EventHandler(this.label7_Click);
		this.label8.AutoSize = true;
		this.label8.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label8.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label8.Location = new global::System.Drawing.Point(408, 81);
		this.label8.Name = "label8";
		this.label8.Size = new global::System.Drawing.Size(273, 62);
		this.label8.TabIndex = 30;
		this.label8.Text = "Exploits Clic";
		this.label8.Click += new global::System.EventHandler(this.label8_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "NovoFatum";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "NovoFatum";
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040000BB RID: 187
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x040000BC RID: 188
	private global::System.Windows.Forms.Button button1;

	// Token: 0x040000BD RID: 189
	private global::System.Windows.Forms.PictureBox pictureBox2;

	// Token: 0x040000BE RID: 190
	private global::System.Windows.Forms.Label label1;

	// Token: 0x040000BF RID: 191
	private global::System.Windows.Forms.Label label2;

	// Token: 0x040000C0 RID: 192
	private global::System.Windows.Forms.Label label3;

	// Token: 0x040000C1 RID: 193
	private global::System.Windows.Forms.Label label4;

	// Token: 0x040000C2 RID: 194
	private global::System.Windows.Forms.Label label5;

	// Token: 0x040000C3 RID: 195
	private global::System.Windows.Forms.Label label6;

	// Token: 0x040000C4 RID: 196
	private global::System.Windows.Forms.Label label7;

	// Token: 0x040000C5 RID: 197
	private global::System.Windows.Forms.Label label8;
}
