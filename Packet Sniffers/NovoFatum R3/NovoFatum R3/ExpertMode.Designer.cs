// Token: 0x0200000C RID: 12
public partial class ExpertMode : global::System.Windows.Forms.Form
{
	// Token: 0x06000049 RID: 73 RVA: 0x00002945 File Offset: 0x00000B45
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0000706C File Offset: 0x0000526C
	private void InitializeComponent()
	{
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.button1 = new global::System.Windows.Forms.Button();
		this.label2 = new global::System.Windows.Forms.Label();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.button2 = new global::System.Windows.Forms.Button();
		this.comboBox1 = new global::System.Windows.Forms.ComboBox();
		this.comboBox2 = new global::System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.textBox1.BackColor = global::System.Drawing.Color.Silver;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.ForeColor = global::System.Drawing.Color.White;
		this.textBox1.Location = new global::System.Drawing.Point(13, 49);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(650, 43);
		this.textBox1.TabIndex = 34;
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(12, 350);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(650, 62);
		this.button1.TabIndex = 32;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.label2.AutoSize = true;
		this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label2.Location = new global::System.Drawing.Point(6, 9);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(43, 37);
		this.label2.TabIndex = 35;
		this.label2.Text = "ID";
		this.label2.Click += new global::System.EventHandler(this.label2_Click);
		this.panel1.AutoScroll = true;
		this.panel1.Location = new global::System.Drawing.Point(13, 98);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(649, 178);
		this.panel1.TabIndex = 36;
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(342, 282);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(320, 62);
		this.button2.TabIndex = 37;
		this.button2.Text = "Send";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.comboBox1.BackColor = global::System.Drawing.Color.Silver;
		this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.comboBox1.Font = new global::System.Drawing.Font("Segoe UI", 30f);
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[]
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"11",
			"12"
		});
		this.comboBox1.Location = new global::System.Drawing.Point(12, 282);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new global::System.Drawing.Size(160, 62);
		this.comboBox1.TabIndex = 38;
		this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
		this.comboBox2.BackColor = global::System.Drawing.Color.Silver;
		this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.comboBox2.Font = new global::System.Drawing.Font("Segoe UI", 30f);
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Items.AddRange(new object[]
		{
			"Client",
			"Server"
		});
		this.comboBox2.Location = new global::System.Drawing.Point(178, 282);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new global::System.Drawing.Size(160, 62);
		this.comboBox2.TabIndex = 39;
		this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.comboBox2);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "ExpertMode";
		this.Text = "ExpertMode";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000046 RID: 70
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000047 RID: 71
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000048 RID: 72
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000049 RID: 73
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400004A RID: 74
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x0400004B RID: 75
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400004C RID: 76
	private global::System.Windows.Forms.ComboBox comboBox1;

	// Token: 0x0400004D RID: 77
	private global::System.Windows.Forms.ComboBox comboBox2;
}
