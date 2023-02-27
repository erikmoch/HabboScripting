using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200000C RID: 12
public partial class ExpertMode : Form
{
	// Token: 0x06000043 RID: 67 RVA: 0x000028F9 File Offset: 0x00000AF9
	public ExpertMode()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000028AC File Offset: 0x00000AAC
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_10();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002616 File Offset: 0x00000816
	private void label2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00006D50 File Offset: 0x00004F50
	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		int num = Convert.ToInt32(this.comboBox1.Text);
		this.panel1.Controls.Clear();
		for (int i = 0; i < num; i++)
		{
			ComboBox comboBox = new ComboBox();
			comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox.FormattingEnabled = true;
			comboBox.BackColor = Color.Silver;
			comboBox.FlatStyle = FlatStyle.Popup;
			comboBox.Items.AddRange(new object[]
			{
				"String",
				"Int",
				"Bool"
			});
			int y = i * 53;
			comboBox.Location = new Point(-1, y);
			comboBox.Name = "combox" + i;
			comboBox.Size = new Size(160, 45);
			comboBox.TabIndex = 0;
			this.panel1.Controls.Add(comboBox);
			TextBox textBox = new TextBox();
			textBox.Location = new Point(165, y);
			textBox.BackColor = Color.Silver;
			textBox.Name = "text" + i;
			textBox.BorderStyle = BorderStyle.FixedSingle;
			textBox.Size = new Size(459, 47);
			textBox.TabIndex = 6;
			this.panel1.Controls.Add(textBox);
		}
		this.int_0 = num;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002915 File Offset: 0x00000B15
	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.button2.Text = ((this.comboBox2.Text == "Client") ? "Send to Client" : "Send to Server");
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00006EB0 File Offset: 0x000050B0
	private void button2_Click(object sender, EventArgs e)
	{
		if (this.comboBox2.Text == "" || this.comboBox1.Text == "" || this.textBox1.Text == "")
		{
			MessageBox.Show("Fill all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else
		{
			Class14 @class = new Class14(Convert.ToInt32(this.textBox1.Text));
			string text = "";
			string a = "get";
			for (int i = 0; i < this.int_0 * 2; i++)
			{
				if (a == "get")
				{
					text = this.panel1.Controls[i].Text;
					a = "set";
				}
				else
				{
					string text2 = text;
					if (text2 != null)
					{
						if (!(text2 == "String"))
						{
							if (!(text2 == "Int"))
							{
								if (text2 == "Bool")
								{
									@class.method_2(this.panel1.Controls[i].Text == "true");
								}
							}
							else
							{
								@class.method_1(Convert.ToInt32(this.panel1.Controls[i].Text));
							}
						}
						else
						{
							@class.method_3(this.panel1.Controls[i].Text);
						}
					}
					a = "get";
				}
			}
			if (this.comboBox2.Text.Contains("Server"))
			{
				Class1.class19_0.method_8(@class.method_5());
			}
			else
			{
				Class1.class19_0.method_7(@class.method_5());
			}
		}
	}

	// Token: 0x04000045 RID: 69
	private int int_0 = 0;
}
