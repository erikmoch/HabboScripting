// Token: 0x0200000F RID: 15
public partial class LittleJMode_AddTimer : global::System.Windows.Forms.Form
{
	// Token: 0x06000066 RID: 102 RVA: 0x00002AB3 File Offset: 0x00000CB3
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00008D60 File Offset: 0x00006F60
	private void InitializeComponent()
	{
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.textBox2 = new global::System.Windows.Forms.TextBox();
		this.label2 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.textBox3 = new global::System.Windows.Forms.TextBox();
		this.label4 = new global::System.Windows.Forms.Label();
		this.textBox4 = new global::System.Windows.Forms.TextBox();
		this.button3 = new global::System.Windows.Forms.Button();
		this.comboBox2 = new global::System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.textBox1.BackColor = global::System.Drawing.Color.Silver;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.Location = new global::System.Drawing.Point(12, 45);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(323, 43);
		this.textBox1.TabIndex = 3;
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(5, 5);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(152, 37);
		this.label1.TabIndex = 4;
		this.label1.Text = "Description";
		this.textBox2.BackColor = global::System.Drawing.Color.Silver;
		this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox2.Location = new global::System.Drawing.Point(341, 45);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new global::System.Drawing.Size(323, 43);
		this.textBox2.TabIndex = 5;
		this.label2.AutoSize = true;
		this.label2.Location = new global::System.Drawing.Point(334, 5);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(94, 37);
		this.label2.TabIndex = 6;
		this.label2.Text = "Period";
		this.label3.AutoSize = true;
		this.label3.Location = new global::System.Drawing.Point(5, 91);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(43, 37);
		this.label3.TabIndex = 8;
		this.label3.Text = "ID";
		this.textBox3.BackColor = global::System.Drawing.Color.Silver;
		this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox3.Location = new global::System.Drawing.Point(12, 131);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new global::System.Drawing.Size(323, 43);
		this.textBox3.TabIndex = 7;
		this.textBox3.Text = "#This field is automatic#";
		this.label4.AutoSize = true;
		this.label4.Location = new global::System.Drawing.Point(334, 91);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(73, 37);
		this.label4.TabIndex = 10;
		this.label4.Text = "Data";
		this.textBox4.BackColor = global::System.Drawing.Color.Silver;
		this.textBox4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox4.Location = new global::System.Drawing.Point(341, 131);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new global::System.Drawing.Size(323, 43);
		this.textBox4.TabIndex = 9;
		this.button3.BackColor = global::System.Drawing.Color.Gray;
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button3.Location = new global::System.Drawing.Point(12, 244);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(652, 62);
		this.button3.TabIndex = 31;
		this.button3.Text = "Add/Edit";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.comboBox2.BackColor = global::System.Drawing.Color.Silver;
		this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.comboBox2.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Items.AddRange(new object[]
		{
			"Client",
			"Server"
		});
		this.comboBox2.Location = new global::System.Drawing.Point(12, 186);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new global::System.Drawing.Size(652, 45);
		this.comboBox2.TabIndex = 40;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 318);
		base.Controls.Add(this.comboBox2);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "LittleJMode_AddTimer";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "LittleJMode_AddTimer";
		base.Load += new global::System.EventHandler(this.LittleJMode_AddTimer_Load);
		base.Click += new global::System.EventHandler(this.LittleJMode_AddTimer_Click);
		base.DoubleClick += new global::System.EventHandler(this.LittleJMode_AddTimer_DoubleClick);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000067 RID: 103
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000068 RID: 104
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000069 RID: 105
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400006A RID: 106
	private global::System.Windows.Forms.TextBox textBox2;

	// Token: 0x0400006B RID: 107
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400006C RID: 108
	private global::System.Windows.Forms.Label label3;

	// Token: 0x0400006D RID: 109
	private global::System.Windows.Forms.TextBox textBox3;

	// Token: 0x0400006E RID: 110
	private global::System.Windows.Forms.Label label4;

	// Token: 0x0400006F RID: 111
	private global::System.Windows.Forms.TextBox textBox4;

	// Token: 0x04000070 RID: 112
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000071 RID: 113
	private global::System.Windows.Forms.ComboBox comboBox2;
}
