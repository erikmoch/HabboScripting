// Token: 0x02000040 RID: 64
public partial class Search : global::System.Windows.Forms.Form
{
	// Token: 0x060001DE RID: 478 RVA: 0x00003416 File Offset: 0x00001616
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00015860 File Offset: 0x00013A60
	private void InitializeComponent()
	{
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.button7 = new global::System.Windows.Forms.Button();
		this.button6 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.panel1.AutoScroll = true;
		this.panel1.Controls.Add(this.button7);
		this.panel1.Controls.Add(this.button6);
		this.panel1.Controls.Add(this.button5);
		this.panel1.Controls.Add(this.button4);
		this.panel1.Controls.Add(this.button3);
		this.panel1.Location = new global::System.Drawing.Point(12, 80);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(650, 264);
		this.panel1.TabIndex = 29;
		this.button7.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button7.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button7.Location = new global::System.Drawing.Point(0, 236);
		this.button7.Name = "button7";
		this.button7.Size = new global::System.Drawing.Size(630, 62);
		this.button7.TabIndex = 11;
		this.button7.Text = "eXtreme App";
		this.button7.UseVisualStyleBackColor = false;
		this.button6.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button6.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button6.Location = new global::System.Drawing.Point(0, 177);
		this.button6.Name = "button6";
		this.button6.Size = new global::System.Drawing.Size(630, 62);
		this.button6.TabIndex = 10;
		this.button6.Text = "eXtreme App";
		this.button6.UseVisualStyleBackColor = false;
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(0, 118);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(630, 62);
		this.button5.TabIndex = 9;
		this.button5.Text = "Client DEV";
		this.button5.UseVisualStyleBackColor = false;
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(0, 59);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(630, 62);
		this.button4.TabIndex = 8;
		this.button4.Text = "Windows Tool";
		this.button4.UseVisualStyleBackColor = false;
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(0, 0);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(630, 62);
		this.button3.TabIndex = 7;
		this.button3.Text = "NF3";
		this.button3.UseVisualStyleBackColor = false;
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(535, 12);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(127, 62);
		this.button2.TabIndex = 27;
		this.button2.Text = "Search";
		this.button2.UseVisualStyleBackColor = false;
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 26;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 30f);
		this.textBox1.ForeColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
		this.textBox1.Location = new global::System.Drawing.Point(12, 13);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(517, 61);
		this.textBox1.TabIndex = 30;
		this.textBox1.Text = "What do you want to search?";
		this.textBox1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Search";
		this.Text = "Search";
		this.panel1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000157 RID: 343
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000158 RID: 344
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000159 RID: 345
	private global::System.Windows.Forms.Button button7;

	// Token: 0x0400015A RID: 346
	private global::System.Windows.Forms.Button button6;

	// Token: 0x0400015B RID: 347
	private global::System.Windows.Forms.Button button5;

	// Token: 0x0400015C RID: 348
	private global::System.Windows.Forms.Button button4;

	// Token: 0x0400015D RID: 349
	private global::System.Windows.Forms.Button button3;

	// Token: 0x0400015E RID: 350
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400015F RID: 351
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000160 RID: 352
	private global::System.Windows.Forms.TextBox textBox1;
}
