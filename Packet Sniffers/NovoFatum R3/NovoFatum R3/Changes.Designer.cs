// Token: 0x02000005 RID: 5
public partial class Changes : global::System.Windows.Forms.Form
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002698 File Offset: 0x00000898
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000046E0 File Offset: 0x000028E0
	private void InitializeComponent()
	{
		this.button1 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.panel1 = new global::System.Windows.Forms.Panel();
		base.SuspendLayout();
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 2;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(464, 12);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(198, 62);
		this.button2.TabIndex = 6;
		this.button2.Text = "Update [*]";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(207, 62);
		this.label1.TabIndex = 24;
		this.label1.Text = "Changes";
		this.panel1.AutoScroll = true;
		this.panel1.Location = new global::System.Drawing.Point(12, 80);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(650, 264);
		this.panel1.TabIndex = 25;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Changes";
		this.Text = "Changes";
		base.Load += new global::System.EventHandler(this.Changes_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000018 RID: 24
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000019 RID: 25
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400001A RID: 26
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400001B RID: 27
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400001C RID: 28
	private global::System.Windows.Forms.Panel panel1;
}
