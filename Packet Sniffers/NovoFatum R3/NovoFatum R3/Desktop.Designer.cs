// Token: 0x0200000A RID: 10
public partial class Desktop : global::System.Windows.Forms.Form
{
	// Token: 0x06000040 RID: 64 RVA: 0x000028CC File Offset: 0x00000ACC
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000065A0 File Offset: 0x000047A0
	private void InitializeComponent()
	{
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.button6 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.panel1.AutoScroll = true;
		this.panel1.Controls.Add(this.button6);
		this.panel1.Controls.Add(this.button5);
		this.panel1.Controls.Add(this.button4);
		this.panel1.Controls.Add(this.button2);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new global::System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(674, 360);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
		this.button6.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button6.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button6.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button6.ForeColor = global::System.Drawing.Color.White;
		this.button6.Location = new global::System.Drawing.Point(451, 19);
		this.button6.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button6.Name = "button6";
		this.button6.Size = new global::System.Drawing.Size(211, 154);
		this.button6.TabIndex = 22;
		this.button6.Text = "Tamper";
		this.button6.UseVisualStyleBackColor = false;
		this.button6.Click += new global::System.EventHandler(this.button6_Click);
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
		this.button5.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button5.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.Color.White;
		this.button5.Location = new global::System.Drawing.Point(232, 183);
		this.button5.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(211, 154);
		this.button5.TabIndex = 21;
		this.button5.Text = "Chat";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button4.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.Color.White;
		this.button4.Location = new global::System.Drawing.Point(232, 19);
		this.button4.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(211, 154);
		this.button4.TabIndex = 20;
		this.button4.Text = "Injections";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.button2.BackColor = global::System.Drawing.Color.CornflowerBlue;
		this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.Color.White;
		this.button2.Location = new global::System.Drawing.Point(12, 183);
		this.button2.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(211, 154);
		this.button2.TabIndex = 18;
		this.button2.Text = "Packetlogger";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackColor = global::System.Drawing.Color.MediumPurple;
		this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.Color.White;
		this.button1.Location = new global::System.Drawing.Point(12, 19);
		this.button1.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(211, 154);
		this.button1.TabIndex = 17;
		this.button1.Text = "Connection";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(12, 361);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(650, 51);
		this.button3.TabIndex = 19;
		this.button3.Text = "Back";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.button3);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.ForeColor = global::System.Drawing.Color.Black;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Desktop";
		this.Text = "Desktop";
		base.Load += new global::System.EventHandler(this.Desktop_Load);
		this.panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x0400003B RID: 59
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x0400003C RID: 60
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x0400003D RID: 61
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400003E RID: 62
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400003F RID: 63
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000040 RID: 64
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000041 RID: 65
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000042 RID: 66
	private global::System.Windows.Forms.Button button6;
}
