// Token: 0x02000007 RID: 7
public partial class Advanced : global::System.Windows.Forms.Form
{
	// Token: 0x06000026 RID: 38 RVA: 0x000027C8 File Offset: 0x000009C8
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00004FE8 File Offset: 0x000031E8
	private void InitializeComponent()
	{
		this.button1 = new global::System.Windows.Forms.Button();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.textBox2 = new global::System.Windows.Forms.TextBox();
		this.label2 = new global::System.Windows.Forms.Label();
		this.textBox3 = new global::System.Windows.Forms.TextBox();
		this.label3 = new global::System.Windows.Forms.Label();
		this.textBox4 = new global::System.Windows.Forms.TextBox();
		this.label4 = new global::System.Windows.Forms.Label();
		this.button2 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(13, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(322, 62);
		this.button1.TabIndex = 26;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.textBox1.BackColor = global::System.Drawing.Color.Silver;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.ForeColor = global::System.Drawing.Color.White;
		this.textBox1.Location = new global::System.Drawing.Point(13, 49);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(650, 43);
		this.textBox1.TabIndex = 29;
		this.label1.AutoSize = true;
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(6, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(128, 37);
		this.label1.TabIndex = 28;
		this.label1.Text = "Client Url";
		this.textBox2.BackColor = global::System.Drawing.Color.Silver;
		this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox2.ForeColor = global::System.Drawing.Color.White;
		this.textBox2.Location = new global::System.Drawing.Point(13, 135);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new global::System.Drawing.Size(650, 43);
		this.textBox2.TabIndex = 31;
		this.label2.AutoSize = true;
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(6, 95);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(141, 37);
		this.label2.TabIndex = 30;
		this.label2.Text = "Banner Url";
		this.textBox3.BackColor = global::System.Drawing.Color.Silver;
		this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox3.ForeColor = global::System.Drawing.Color.White;
		this.textBox3.Location = new global::System.Drawing.Point(13, 221);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new global::System.Drawing.Size(322, 43);
		this.textBox3.TabIndex = 33;
		this.label3.AutoSize = true;
		this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label3.Location = new global::System.Drawing.Point(6, 181);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(173, 37);
		this.label3.TabIndex = 32;
		this.label3.Text = "RSA PubMod";
		this.textBox4.BackColor = global::System.Drawing.Color.Silver;
		this.textBox4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox4.ForeColor = global::System.Drawing.Color.White;
		this.textBox4.Location = new global::System.Drawing.Point(341, 221);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new global::System.Drawing.Size(322, 43);
		this.textBox4.TabIndex = 35;
		this.label4.AutoSize = true;
		this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label4.Location = new global::System.Drawing.Point(334, 181);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(159, 37);
		this.label4.TabIndex = 34;
		this.label4.Text = "RSA PubExp";
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(341, 350);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(322, 62);
		this.button2.TabIndex = 36;
		this.button2.Text = "Next";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Advanced";
		this.Text = "Advanced";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000024 RID: 36
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000025 RID: 37
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000026 RID: 38
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000027 RID: 39
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000028 RID: 40
	private global::System.Windows.Forms.TextBox textBox2;

	// Token: 0x04000029 RID: 41
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400002A RID: 42
	private global::System.Windows.Forms.TextBox textBox3;

	// Token: 0x0400002B RID: 43
	private global::System.Windows.Forms.Label label3;

	// Token: 0x0400002C RID: 44
	private global::System.Windows.Forms.TextBox textBox4;

	// Token: 0x0400002D RID: 45
	private global::System.Windows.Forms.Label label4;

	// Token: 0x0400002E RID: 46
	private global::System.Windows.Forms.Button button2;
}
