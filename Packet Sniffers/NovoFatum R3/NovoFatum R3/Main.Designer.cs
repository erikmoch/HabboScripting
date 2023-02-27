namespace NovoFatum_R3
{
	// Token: 0x02000014 RID: 20
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002CD9 File Offset: 0x00000ED9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NovoFatum_R3.Main));
			this.panel1 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(674, 424);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(674, 424);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
			base.Name = "Main";
			this.Text = "NovoFatum R3 was made by LittleJ - Download FREE!";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000091 RID: 145
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x04000092 RID: 146
		public global::System.Windows.Forms.Panel panel1;
	}
}
