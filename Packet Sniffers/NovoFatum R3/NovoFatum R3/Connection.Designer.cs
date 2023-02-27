// Token: 0x02000006 RID: 6
public partial class Connection : global::System.Windows.Forms.Form
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002782 File Offset: 0x00000982
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00004A5C File Offset: 0x00002C5C
	private void InitializeComponent()
	{
		this.button1 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.label3 = new global::System.Windows.Forms.Label();
		this.button5 = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		base.SuspendLayout();
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(322, 62);
		this.button1.TabIndex = 2;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.Enabled = false;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(339, 350);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(322, 62);
		this.button2.TabIndex = 3;
		this.button2.Text = "Next";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(12, 49);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(649, 62);
		this.button4.TabIndex = 6;
		this.button4.Text = "Auto";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.label3.AutoSize = true;
		this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label3.Location = new global::System.Drawing.Point(12, 114);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(459, 37);
		this.label3.TabIndex = 9;
		this.label3.Text = "Input hotel url, banner url and rsa key";
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(13, 154);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(649, 62);
		this.button5.TabIndex = 8;
		this.button5.Text = "Advance";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.label1.AutoSize = true;
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(541, 37);
		this.label1.TabIndex = 7;
		this.label1.Text = "Open your client and start using NovoFatum";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Connection";
		this.Text = "Connection";
		base.Load += new global::System.EventHandler(this.Connection_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400001D RID: 29
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x0400001E RID: 30
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400001F RID: 31
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000020 RID: 32
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000021 RID: 33
	private global::System.Windows.Forms.Label label3;

	// Token: 0x04000022 RID: 34
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000023 RID: 35
	private global::System.Windows.Forms.Label label1;
}
