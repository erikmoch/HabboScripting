// Token: 0x02000012 RID: 18
public partial class InstalledApps : global::System.Windows.Forms.Form
{
	// Token: 0x06000080 RID: 128 RVA: 0x00002BF8 File Offset: 0x00000DF8
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000A27C File Offset: 0x0000847C
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.button4 = new global::System.Windows.Forms.Button();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.label1 = new global::System.Windows.Forms.Label();
		this.button2 = new global::System.Windows.Forms.Button();
		this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
		this.button1 = new global::System.Windows.Forms.Button();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(12, 350);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(646, 62);
		this.button4.TabIndex = 22;
		this.button4.Text = "Back";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.panel1.AutoScroll = true;
		this.panel1.Location = new global::System.Drawing.Point(12, 77);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(650, 264);
		this.panel1.TabIndex = 28;
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(133, 62);
		this.label1.TabIndex = 27;
		this.label1.Text = "Apps";
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(464, 9);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(198, 62);
		this.button2.TabIndex = 26;
		this.button2.Text = "Install";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.openFileDialog_0.FileName = "openFileDialog1";
		this.openFileDialog_0.FileOk += new global::System.ComponentModel.CancelEventHandler(this.openFileDialog_0_FileOk);
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(260, 9);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(198, 62);
		this.button1.TabIndex = 29;
		this.button1.Text = "Unistall";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.timer_0.Interval = 3000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button4);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "InstalledApps";
		this.Text = "InstalledApps";
		base.Load += new global::System.EventHandler(this.InstalledApps_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000080 RID: 128
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000081 RID: 129
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000082 RID: 130
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000083 RID: 131
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000084 RID: 132
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000085 RID: 133
	private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

	// Token: 0x04000086 RID: 134
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000087 RID: 135
	private global::System.Windows.Forms.Timer timer_0;
}
