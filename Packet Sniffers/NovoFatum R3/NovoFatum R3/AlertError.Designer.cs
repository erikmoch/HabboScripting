// Token: 0x02000002 RID: 2
public partial class AlertError : global::System.Windows.Forms.Form
{
	// Token: 0x06000005 RID: 5 RVA: 0x000025C5 File Offset: 0x000007C5
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000034D8 File Offset: 0x000016D8
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.button2 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 36f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = global::System.Drawing.Color.Red;
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(56, 65);
		this.label1.TabIndex = 0;
		this.label1.Text = "{}";
		this.label2.AutoSize = true;
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(16, 74);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(33, 37);
		this.label2.TabIndex = 1;
		this.label2.Text = "{}";
		this.button2.BackColor = global::System.Drawing.Color.Silver;
		this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.Purple;
		this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Purple;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.Color.White;
		this.button2.Location = new global::System.Drawing.Point(12, 237);
		this.button2.Margin = new global::System.Windows.Forms.Padding(7, 10, 7, 10);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(646, 62);
		this.button2.TabIndex = 19;
		this.button2.Text = "OK";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 318);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "AlertError";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "AlertError";
		base.Load += new global::System.EventHandler(this.AlertError_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000003 RID: 3
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000004 RID: 4
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000005 RID: 5
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04000006 RID: 6
	private global::System.Windows.Forms.Button button2;
}
