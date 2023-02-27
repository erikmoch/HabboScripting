// Token: 0x02000016 RID: 22
public partial class MainWindow : global::System.Windows.Forms.Form
{
	// Token: 0x060000B1 RID: 177 RVA: 0x00002D37 File Offset: 0x00000F37
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000BB50 File Offset: 0x00009D50
	private void InitializeComponent()
	{
		this.label2 = new global::System.Windows.Forms.Label();
		this.label1 = new global::System.Windows.Forms.Label();
		this.button6 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label2.AutoSize = true;
		this.label2.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(597, 387);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(65, 37);
		this.label2.TabIndex = 23;
		this.label2.Text = "NF3";
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(11, 7);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(536, 62);
		this.label1.TabIndex = 22;
		this.label1.Text = "Welcome to NovoFatum";
		this.button6.BackColor = global::System.Drawing.Color.Silver;
		this.button6.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		this.button6.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		this.button6.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button6.ForeColor = global::System.Drawing.Color.White;
		this.button6.Location = new global::System.Drawing.Point(447, 232);
		this.button6.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button6.Name = "button6";
		this.button6.Size = new global::System.Drawing.Size(211, 154);
		this.button6.TabIndex = 21;
		this.button6.Text = "Desktop";
		this.button6.UseVisualStyleBackColor = false;
		this.button6.Click += new global::System.EventHandler(this.button6_Click);
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button5.FlatAppearance.BorderColor = global::System.Drawing.Color.Fuchsia;
		this.button5.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Fuchsia;
		this.button5.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Fuchsia;
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.Color.White;
		this.button5.Location = new global::System.Drawing.Point(447, 69);
		this.button5.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(211, 154);
		this.button5.TabIndex = 20;
		this.button5.Text = "Search";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.Red;
		this.button4.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Red;
		this.button4.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Red;
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.Color.White;
		this.button4.Location = new global::System.Drawing.Point(228, 232);
		this.button4.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(211, 154);
		this.button4.TabIndex = 19;
		this.button4.Text = "Manage";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.button3.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.button3.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.Color.White;
		this.button3.Location = new global::System.Drawing.Point(228, 69);
		this.button3.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(211, 154);
		this.button3.TabIndex = 18;
		this.button3.Text = "Categories";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.button2.BackColor = global::System.Drawing.Color.CornflowerBlue;
		this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.RoyalBlue;
		this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.RoyalBlue;
		this.button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.RoyalBlue;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.Color.White;
		this.button2.Location = new global::System.Drawing.Point(10, 232);
		this.button2.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(211, 154);
		this.button2.TabIndex = 17;
		this.button2.Text = "Changes";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackColor = global::System.Drawing.Color.MediumPurple;
		this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.Color.White;
		this.button1.Location = new global::System.Drawing.Point(10, 69);
		this.button1.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(211, 154);
		this.button1.TabIndex = 16;
		this.button1.Text = "NovoFatum";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button6);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "MainWindow";
		this.Text = "MainWindow";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000093 RID: 147
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000094 RID: 148
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04000095 RID: 149
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000096 RID: 150
	private global::System.Windows.Forms.Button button6;

	// Token: 0x04000097 RID: 151
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000098 RID: 152
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000099 RID: 153
	private global::System.Windows.Forms.Button button3;

	// Token: 0x0400009A RID: 154
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400009B RID: 155
	private global::System.Windows.Forms.Button button1;
}
