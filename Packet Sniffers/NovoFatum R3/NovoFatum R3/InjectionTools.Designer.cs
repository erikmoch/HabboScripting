// Token: 0x02000011 RID: 17
public partial class InjectionTools : global::System.Windows.Forms.Form
{
	// Token: 0x06000075 RID: 117 RVA: 0x00002B5E File Offset: 0x00000D5E
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x000099EC File Offset: 0x00007BEC
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(352, 62);
		this.label1.TabIndex = 26;
		this.label1.Text = "Injections Tools";
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 25;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button2.BackColor = global::System.Drawing.Color.PaleGreen;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(12, 282);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(650, 62);
		this.button2.TabIndex = 27;
		this.button2.Text = "Habbo Encoding";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(12, 145);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(650, 62);
		this.button3.TabIndex = 28;
		this.button3.Text = "Expert Mode";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(12, 77);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(650, 62);
		this.button4.TabIndex = 29;
		this.button4.Text = "Normal Mode";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.button5.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(12, 213);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(650, 62);
		this.button5.TabIndex = 30;
		this.button5.Text = "LittleJ Mode";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "InjectionTools";
		this.Text = "Injections Tools";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000079 RID: 121
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x0400007A RID: 122
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400007B RID: 123
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400007C RID: 124
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400007D RID: 125
	private global::System.Windows.Forms.Button button3;

	// Token: 0x0400007E RID: 126
	private global::System.Windows.Forms.Button button4;

	// Token: 0x0400007F RID: 127
	private global::System.Windows.Forms.Button button5;
}
