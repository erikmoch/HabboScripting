// Token: 0x02000010 RID: 16
public partial class NormalMode : global::System.Windows.Forms.Form
{
	// Token: 0x0600006D RID: 109 RVA: 0x00002AF4 File Offset: 0x00000CF4
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00009570 File Offset: 0x00007770
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.button2 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(315, 62);
		this.label1.TabIndex = 28;
		this.label1.Text = "Normal mode";
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 27;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(12, 278);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(320, 62);
		this.button3.TabIndex = 30;
		this.button3.Text = "Send to Client";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.textBox1.BackColor = global::System.Drawing.Color.Silver;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.ForeColor = global::System.Drawing.Color.White;
		this.textBox1.Location = new global::System.Drawing.Point(12, 77);
		this.textBox1.Multiline = true;
		this.textBox1.Name = "textBox1";
		this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
		this.textBox1.Size = new global::System.Drawing.Size(650, 195);
		this.textBox1.TabIndex = 31;
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(342, 278);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(320, 62);
		this.button2.TabIndex = 32;
		this.button2.Text = "Send to Server";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "NormalMode";
		this.Text = "NormalMode";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000073 RID: 115
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000074 RID: 116
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000075 RID: 117
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000076 RID: 118
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000077 RID: 119
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000078 RID: 120
	private global::System.Windows.Forms.Button button2;
}
