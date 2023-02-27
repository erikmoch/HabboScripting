// Token: 0x02000042 RID: 66
public partial class Tamper : global::System.Windows.Forms.Form
{
	// Token: 0x060001E8 RID: 488 RVA: 0x0000348A File Offset: 0x0000168A
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x000164A0 File Offset: 0x000146A0
	private void InitializeComponent()
	{
		this.button5 = new global::System.Windows.Forms.Button();
		this.listView1 = new global::System.Windows.Forms.ListView();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.button3 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.button1 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(18, 281);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(221, 62);
		this.button5.TabIndex = 42;
		this.button5.Text = "Delete";
		this.button5.UseVisualStyleBackColor = false;
		this.listView1.BackColor = global::System.Drawing.Color.White;
		this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_0,
			this.columnHeader_1
		});
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.listView1.HideSelection = false;
		this.listView1.Location = new global::System.Drawing.Point(245, 77);
		this.listView1.Name = "listView1";
		this.listView1.Size = new global::System.Drawing.Size(423, 267);
		this.listView1.TabIndex = 41;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = global::System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Original";
		this.columnHeader_0.Width = 86;
		this.columnHeader_1.Text = "Replacement";
		this.columnHeader_1.Width = 166;
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(18, 213);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(221, 62);
		this.button3.TabIndex = 40;
		this.button3.Text = "Load Tamper";
		this.button3.UseVisualStyleBackColor = false;
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(18, 145);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(221, 62);
		this.button2.TabIndex = 39;
		this.button2.Text = "Save Tamper";
		this.button2.UseVisualStyleBackColor = false;
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(18, 77);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(221, 62);
		this.button4.TabIndex = 38;
		this.button4.Text = "Add Tamper";
		this.button4.UseVisualStyleBackColor = false;
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(7, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(185, 62);
		this.label1.TabIndex = 37;
		this.label1.Text = "Tamper";
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(18, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 36;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Tamper";
		this.Text = "Tamper";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000166 RID: 358
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000167 RID: 359
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000168 RID: 360
	private global::System.Windows.Forms.ListView listView1;

	// Token: 0x04000169 RID: 361
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x0400016A RID: 362
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x0400016B RID: 363
	private global::System.Windows.Forms.Button button3;

	// Token: 0x0400016C RID: 364
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400016D RID: 365
	private global::System.Windows.Forms.Button button4;

	// Token: 0x0400016E RID: 366
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400016F RID: 367
	private global::System.Windows.Forms.Button button1;
}
