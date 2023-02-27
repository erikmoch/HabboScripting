// Token: 0x02000041 RID: 65
public partial class Started : global::System.Windows.Forms.Form
{
	// Token: 0x060001E4 RID: 484 RVA: 0x00003450 File Offset: 0x00001650
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x000160D0 File Offset: 0x000142D0
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.button2 = new global::System.Windows.Forms.Button();
		this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.button1 = new global::System.Windows.Forms.Button();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(148, 214);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(372, 62);
		this.label1.TabIndex = 27;
		this.label1.Text = "Congratulations!";
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(12, 282);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(650, 62);
		this.button2.TabIndex = 26;
		this.button2.Text = "Go to desktop";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		this.pictureBox2.Image = global::NovoFatum_R3.Properties.Resources.Bitmap_6;
		this.pictureBox2.Location = new global::System.Drawing.Point(203, 12);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new global::System.Drawing.Size(260, 199);
		this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 25;
		this.pictureBox2.TabStop = false;
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 24;
		this.button1.Text = "Go to main";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Started";
		this.Text = "Started";
		base.Load += new global::System.EventHandler(this.Started_Load);
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000161 RID: 353
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000162 RID: 354
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000163 RID: 355
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000164 RID: 356
	private global::System.Windows.Forms.PictureBox pictureBox2;

	// Token: 0x04000165 RID: 357
	private global::System.Windows.Forms.Button button1;
}
