// Token: 0x02000009 RID: 9
public partial class Easy : global::System.Windows.Forms.Form
{
	// Token: 0x06000034 RID: 52 RVA: 0x00002843 File Offset: 0x00000A43
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00005F18 File Offset: 0x00004118
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.comboBox2 = new global::System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Segoe UI", 35f);
		this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.label1.Location = new global::System.Drawing.Point(12, 11);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(650, 62);
		this.label1.TabIndex = 28;
		this.label1.Text = "Select one hotel and have fun";
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button2.Location = new global::System.Drawing.Point(340, 352);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(322, 62);
		this.button2.TabIndex = 27;
		this.button2.Text = "Next";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new global::System.Drawing.Point(13, 352);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(322, 62);
		this.button1.TabIndex = 26;
		this.button1.Text = "Back";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.comboBox2.BackColor = global::System.Drawing.Color.Silver;
		this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.comboBox2.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Items.AddRange(new object[]
		{
			"ES",
			"IT",
			"DE",
			"SE",
			"NL",
			"FR",
			"FÍ",
			"DK",
			"NO",
			"BR",
			"TR"
		});
		this.comboBox2.Location = new global::System.Drawing.Point(13, 87);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new global::System.Drawing.Size(652, 45);
		this.comboBox2.TabIndex = 41;
		this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new global::System.Drawing.Size(674, 424);
		base.Controls.Add(this.comboBox2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
		base.Name = "Easy";
		this.Text = "Easy";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000036 RID: 54
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000037 RID: 55
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000038 RID: 56
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000039 RID: 57
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400003A RID: 58
	private global::System.Windows.Forms.ComboBox comboBox2;
}
