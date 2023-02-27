// Token: 0x02000004 RID: 4
public partial class Categories : global::System.Windows.Forms.Form
{
	// Token: 0x06000012 RID: 18 RVA: 0x0000265E File Offset: 0x0000085E
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00003E28 File Offset: 0x00002028
	private void InitializeComponent()
	{
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.button7 = new global::System.Windows.Forms.Button();
		this.button6 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.button1 = new global::System.Windows.Forms.Button();
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
		this.button7.Text = "Apps";
		this.button7.UseVisualStyleBackColor = false;
		this.button6.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button6.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button6.Location = new global::System.Drawing.Point(0, 177);
		this.button6.Name = "button6";
		this.button6.Size = new global::System.Drawing.Size(630, 62);
		this.button6.TabIndex = 10;
		this.button6.Text = "Plugins";
		this.button6.UseVisualStyleBackColor = false;
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(0, 118);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(630, 62);
		this.button5.TabIndex = 9;
		this.button5.Text = "Themes";
		this.button5.UseVisualStyleBackColor = false;
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(0, 59);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(630, 62);
		this.button4.TabIndex = 8;
		this.button4.Text = "Development";
		this.button4.UseVisualStyleBackColor = false;
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(0, 0);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(630, 62);
		this.button3.TabIndex = 7;
		this.button3.Text = "Habbo Dev Team";
		this.button3.UseVisualStyleBackColor = false;
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(249, 62);
		this.label1.TabIndex = 28;
		this.label1.Text = "Categories";
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
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Categories";
		this.Text = "Categories";
		this.panel1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400000F RID: 15
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000010 RID: 16
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000011 RID: 17
	private global::System.Windows.Forms.Button button7;

	// Token: 0x04000012 RID: 18
	private global::System.Windows.Forms.Button button6;

	// Token: 0x04000013 RID: 19
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000014 RID: 20
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000015 RID: 21
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000016 RID: 22
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000017 RID: 23
	private global::System.Windows.Forms.Button button1;
}
