// Token: 0x0200000E RID: 14
public partial class LittleJMode : global::System.Windows.Forms.Form
{
	// Token: 0x0600005F RID: 95 RVA: 0x00002A6B File Offset: 0x00000C6B
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000082FC File Offset: 0x000064FC
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.listView1 = new global::System.Windows.Forms.ListView();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
		this.button5 = new global::System.Windows.Forms.Button();
		this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
		this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(1, 12);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(279, 62);
		this.label1.TabIndex = 30;
		this.label1.Text = "LittleJ mode";
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 29;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button4.Location = new global::System.Drawing.Point(12, 77);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(221, 62);
		this.button4.TabIndex = 31;
		this.button4.Text = "Add Timer";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(12, 145);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(221, 62);
		this.button2.TabIndex = 32;
		this.button2.Text = "Save Timer";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(12, 213);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(221, 62);
		this.button3.TabIndex = 33;
		this.button3.Text = "Load Timer";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.listView1.BackColor = global::System.Drawing.Color.White;
		this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_0,
			this.columnHeader_1,
			this.columnHeader_2
		});
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.listView1.HideSelection = false;
		this.listView1.Location = new global::System.Drawing.Point(239, 77);
		this.listView1.Name = "listView1";
		this.listView1.Size = new global::System.Drawing.Size(423, 267);
		this.listView1.TabIndex = 34;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = global::System.Windows.Forms.View.Details;
		this.listView1.ItemActivate += new global::System.EventHandler(this.listView1_ItemActivate);
		this.listView1.Click += new global::System.EventHandler(this.listView1_Click);
		this.columnHeader_0.Text = "ID";
		this.columnHeader_0.Width = 86;
		this.columnHeader_1.Text = "Description";
		this.columnHeader_1.Width = 166;
		this.columnHeader_2.Text = "Period";
		this.columnHeader_2.Width = 94;
		this.button5.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
		this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button5.Location = new global::System.Drawing.Point(12, 281);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(221, 62);
		this.button5.TabIndex = 35;
		this.button5.Text = "Delete";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.saveFileDialog_0.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveFileDialog_0_FileOk);
		this.openFileDialog_0.FileName = "openFileDialog1";
		this.openFileDialog_0.FileOk += new global::System.ComponentModel.CancelEventHandler(this.openFileDialog_0_FileOk);
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
		base.Name = "LittleJMode";
		this.Text = "LittleJMode";
		base.Load += new global::System.EventHandler(this.LittleJMode_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000059 RID: 89
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x0400005A RID: 90
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400005B RID: 91
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400005C RID: 92
	private global::System.Windows.Forms.Button button4;

	// Token: 0x0400005D RID: 93
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400005E RID: 94
	private global::System.Windows.Forms.Button button3;

	// Token: 0x0400005F RID: 95
	private global::System.Windows.Forms.ListView listView1;

	// Token: 0x04000060 RID: 96
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04000061 RID: 97
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x04000062 RID: 98
	private global::System.Windows.Forms.ColumnHeader columnHeader_2;

	// Token: 0x04000063 RID: 99
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000064 RID: 100
	private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;

	// Token: 0x04000065 RID: 101
	private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;
}
