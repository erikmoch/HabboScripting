// Token: 0x02000008 RID: 8
public partial class Auto : global::System.Windows.Forms.Form
{
	// Token: 0x0600002E RID: 46 RVA: 0x00002809 File Offset: 0x00000A09
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00005840 File Offset: 0x00003A40
	private void InitializeComponent()
	{
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(340, 350);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(322, 62);
		this.button2.TabIndex = 11;
		this.button2.Text = "Next";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(13, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(322, 62);
		this.button1.TabIndex = 10;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(143, 62);
		this.label1.TabIndex = 25;
		this.label1.Text = "Login";
		this.label1.Click += new global::System.EventHandler(this.label1_Click);
		this.pictureBox2.Image = global::NovoFatum_R3.Properties.Resources.Bitmap_4;
		this.pictureBox2.Location = new global::System.Drawing.Point(586, 258);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new global::System.Drawing.Size(76, 86);
		this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox2.TabIndex = 26;
		this.pictureBox2.TabStop = false;
		this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
		this.pictureBox1.Image = global::NovoFatum_R3.Properties.Resources.Bitmap_0;
		this.pictureBox1.Location = new global::System.Drawing.Point(13, 87);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new global::System.Drawing.Size(566, 257);
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.pictureBox1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.ForeColor = global::System.Drawing.Color.White;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Auto";
		this.Text = "Next";
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000030 RID: 48
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000031 RID: 49
	private global::System.Windows.Forms.PictureBox pictureBox1;

	// Token: 0x04000032 RID: 50
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000033 RID: 51
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000034 RID: 52
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000035 RID: 53
	private global::System.Windows.Forms.PictureBox pictureBox2;
}
