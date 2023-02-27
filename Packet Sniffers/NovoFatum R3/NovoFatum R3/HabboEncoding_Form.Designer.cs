// Token: 0x0200000D RID: 13
public partial class HabboEncoding_Form : global::System.Windows.Forms.Form
{
	// Token: 0x06000051 RID: 81 RVA: 0x000029CD File Offset: 0x00000BCD
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000772C File Offset: 0x0000592C
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.button1 = new global::System.Windows.Forms.Button();
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.groupBox2 = new global::System.Windows.Forms.GroupBox();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.textBox2 = new global::System.Windows.Forms.TextBox();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(376, 62);
		this.label1.TabIndex = 30;
		this.label1.Text = "Habbo Encoding";
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 29;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.groupBox1.Controls.Add(this.button2);
		this.groupBox1.Controls.Add(this.button3);
		this.groupBox1.Controls.Add(this.textBox1);
		this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.groupBox1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.groupBox1.Location = new global::System.Drawing.Point(11, 78);
		this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4);
		this.groupBox1.Size = new global::System.Drawing.Size(650, 111);
		this.groupBox1.TabIndex = 31;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Encode";
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(299, 33);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(169, 62);
		this.button2.TabIndex = 40;
		this.button2.Text = "Encode32";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(474, 33);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(169, 62);
		this.button3.TabIndex = 39;
		this.button3.Text = "Encode16";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.textBox1.BackColor = global::System.Drawing.Color.Silver;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.Location = new global::System.Drawing.Point(12, 43);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(273, 43);
		this.textBox1.TabIndex = 2;
		this.groupBox2.Controls.Add(this.button4);
		this.groupBox2.Controls.Add(this.button5);
		this.groupBox2.Controls.Add(this.textBox2);
		this.groupBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.groupBox2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.groupBox2.Location = new global::System.Drawing.Point(11, 197);
		this.groupBox2.Margin = new global::System.Windows.Forms.Padding(4);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Padding = new global::System.Windows.Forms.Padding(4);
		this.groupBox2.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
		this.groupBox2.Size = new global::System.Drawing.Size(650, 111);
		this.groupBox2.TabIndex = 32;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Decode";
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(12, 33);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(169, 62);
		this.button4.TabIndex = 40;
		this.button4.Text = "Decode32";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(187, 33);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(169, 62);
		this.button5.TabIndex = 39;
		this.button5.Text = "Decode16";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.textBox2.BackColor = global::System.Drawing.Color.Silver;
		this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox2.Location = new global::System.Drawing.Point(370, 43);
		this.textBox2.Name = "textBox2";
		this.textBox2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
		this.textBox2.Size = new global::System.Drawing.Size(273, 43);
		this.textBox2.TabIndex = 2;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "HabboEncoding_Form";
		this.Text = "HabboEncoding";
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400004E RID: 78
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x0400004F RID: 79
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000050 RID: 80
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000051 RID: 81
	private global::System.Windows.Forms.GroupBox groupBox1;

	// Token: 0x04000052 RID: 82
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000053 RID: 83
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000054 RID: 84
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000055 RID: 85
	private global::System.Windows.Forms.GroupBox groupBox2;

	// Token: 0x04000056 RID: 86
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000057 RID: 87
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000058 RID: 88
	private global::System.Windows.Forms.TextBox textBox2;
}
