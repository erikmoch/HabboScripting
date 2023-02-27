// Token: 0x02000003 RID: 3
public partial class Animation : global::System.Windows.Forms.Form
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002618 File Offset: 0x00000818
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003A1C File Offset: 0x00001C1C
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.label4 = new global::System.Windows.Forms.Label();
		base.SuspendLayout();
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 8;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 40f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(78, 23);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(524, 72);
		this.label1.TabIndex = 24;
		this.label1.Text = "NovoFatum eXtreme";
		this.label2.AutoSize = true;
		this.label2.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(229, 111);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(228, 62);
		this.label2.TabIndex = 25;
		this.label2.Text = "RSALittleJ";
		this.label3.AutoSize = true;
		this.label3.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label3.Location = new global::System.Drawing.Point(138, 192);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(389, 62);
		this.label3.TabIndex = 26;
		this.label3.Text = "Habbo Dev Team";
		this.timer_1.Enabled = true;
		this.timer_1.Interval = 25;
		this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
		this.label4.AutoSize = true;
		this.label4.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label4.Location = new global::System.Drawing.Point(259, 267);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(153, 62);
		this.label4.TabIndex = 27;
		this.label4.Text = "R3 0.1";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Animation";
		this.Text = "Animation";
		base.Load += new global::System.EventHandler(this.Animation_Load);
		base.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Animation_MouseClick);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000008 RID: 8
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000009 RID: 9
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x0400000A RID: 10
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400000B RID: 11
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400000C RID: 12
	private global::System.Windows.Forms.Label label3;

	// Token: 0x0400000D RID: 13
	private global::System.Windows.Forms.Timer timer_1;

	// Token: 0x0400000E RID: 14
	private global::System.Windows.Forms.Label label4;
}
