// Token: 0x02000017 RID: 23
public partial class Manage : global::System.Windows.Forms.Form
{
	// Token: 0x060000B6 RID: 182 RVA: 0x00002D7D File Offset: 0x00000F7D
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000C458 File Offset: 0x0000A658
	private void InitializeComponent()
	{
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.button2.BackColor = global::System.Drawing.Color.Silver;
		this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.Color.White;
		this.button2.Location = new global::System.Drawing.Point(12, 19);
		this.button2.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(646, 93);
		this.button2.TabIndex = 18;
		this.button2.Text = "Apps";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackColor = global::System.Drawing.Color.Gray;
		this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.Color.White;
		this.button1.Location = new global::System.Drawing.Point(12, 132);
		this.button1.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(646, 93);
		this.button1.TabIndex = 19;
		this.button1.Text = "Sources";
		this.button1.UseVisualStyleBackColor = false;
		this.button3.BackColor = global::System.Drawing.Color.Black;
		this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button3.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.Color.White;
		this.button3.Location = new global::System.Drawing.Point(12, 244);
		this.button3.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(646, 93);
		this.button3.TabIndex = 20;
		this.button3.Text = "Settings";
		this.button3.UseVisualStyleBackColor = false;
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(12, 350);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(646, 62);
		this.button4.TabIndex = 21;
		this.button4.Text = "Back";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.button2);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Manage";
		this.Text = "Manage";
		base.ResumeLayout(false);
	}

	// Token: 0x0400009C RID: 156
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x0400009D RID: 157
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400009E RID: 158
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400009F RID: 159
	private global::System.Windows.Forms.Button button3;

	// Token: 0x040000A0 RID: 160
	private global::System.Windows.Forms.Button button4;
}
