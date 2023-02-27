// Token: 0x02000013 RID: 19
public partial class IntraChat_LOGIN : global::System.Windows.Forms.Form
{
	// Token: 0x06000086 RID: 134 RVA: 0x00002C64 File Offset: 0x00000E64
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000A744 File Offset: 0x00008944
	private void InitializeComponent()
	{
		this.button3 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.textBox2 = new global::System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(12, 350);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(650, 62);
		this.button3.TabIndex = 20;
		this.button3.Text = "Back";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.button2.BackColor = global::System.Drawing.Color.CornflowerBlue;
		this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.Color.White;
		this.button2.Location = new global::System.Drawing.Point(12, 272);
		this.button2.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(320, 65);
		this.button2.TabIndex = 21;
		this.button2.Text = "Login";
		this.button2.UseVisualStyleBackColor = false;
		this.button1.BackColor = global::System.Drawing.Color.SlateBlue;
		this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.Color.White;
		this.button1.Location = new global::System.Drawing.Point(342, 272);
		this.button1.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(320, 65);
		this.button1.TabIndex = 22;
		this.button1.Text = "Register";
		this.button1.UseVisualStyleBackColor = false;
		this.label1.AutoSize = true;
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(5, 22);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(136, 37);
		this.label1.TabIndex = 25;
		this.label1.Text = "Username";
		this.label2.AutoSize = true;
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(5, 143);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(129, 37);
		this.label2.TabIndex = 26;
		this.label2.Text = "Password";
		this.textBox1.BackColor = global::System.Drawing.Color.Silver;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.ForeColor = global::System.Drawing.Color.White;
		this.textBox1.Location = new global::System.Drawing.Point(12, 62);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(650, 43);
		this.textBox1.TabIndex = 27;
		this.textBox2.BackColor = global::System.Drawing.Color.Silver;
		this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox2.ForeColor = global::System.Drawing.Color.White;
		this.textBox2.Location = new global::System.Drawing.Point(12, 183);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new global::System.Drawing.Size(650, 43);
		this.textBox2.TabIndex = 28;
		this.textBox2.UseSystemPasswordChar = true;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button3);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "IntraChat_LOGIN";
		this.Text = "IntraChat";
		base.Load += new global::System.EventHandler(this.IntraChat_LOGIN_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000088 RID: 136
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000089 RID: 137
	private global::System.Windows.Forms.Button button3;

	// Token: 0x0400008A RID: 138
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400008B RID: 139
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400008C RID: 140
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400008D RID: 141
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400008E RID: 142
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x0400008F RID: 143
	private global::System.Windows.Forms.TextBox textBox2;
}
