using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Token: 0x0200000F RID: 15
public partial class LittleJMode_AddTimer : Form
{
	// Token: 0x06000061 RID: 97 RVA: 0x00002A90 File Offset: 0x00000C90
	public LittleJMode_AddTimer(int EditMode = -1)
	{
		this.int_0 = EditMode;
		this.InitializeComponent();
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002616 File Offset: 0x00000816
	private void LittleJMode_AddTimer_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000025BD File Offset: 0x000007BD
	private void LittleJMode_AddTimer_DoubleClick(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00008A80 File Offset: 0x00006C80
	private void button3_Click(object sender, EventArgs e)
	{
		if (this.comboBox2.Text == "" || this.textBox2.Text == "" || this.textBox4.Text == "" || this.textBox1.Text == "" || this.textBox3.Text == "")
		{
			MessageBox.Show("Fill all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else
		{
			try
			{
				if (this.int_0 > -1)
				{
					Class1.class7_0.dictionary_0[this.int_0].byte_0 = Encoding.Default.GetBytes(Class16.smethod_2(this.textBox4.Text));
					Class1.class7_0.dictionary_0[this.int_0].string_0 = this.textBox1.Text;
					Class1.class7_0.dictionary_0[this.int_0].int_0 = Convert.ToInt32(this.textBox2.Text);
					Class1.class7_0.dictionary_0[this.int_0].bool_0 = (this.comboBox2.Text == "Server");
				}
				else
				{
					Class8 @class = new Class8();
					@class.byte_0 = Encoding.Default.GetBytes(Class16.smethod_2(this.textBox4.Text));
					@class.string_0 = this.textBox1.Text;
					@class.int_0 = Convert.ToInt32(this.textBox2.Text);
					@class.bool_0 = (this.comboBox2.Text == "Server");
					Class1.class7_0.method_0(@class);
				}
				base.Close();
			}
			catch
			{
				MessageBox.Show("Bad data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00008C94 File Offset: 0x00006E94
	private void LittleJMode_AddTimer_Load(object sender, EventArgs e)
	{
		if (this.int_0 > -1)
		{
			this.textBox4.Text = Class16.smethod_0(Class1.class7_0.dictionary_0[this.int_0].byte_0);
			this.textBox1.Text = Class1.class7_0.dictionary_0[this.int_0].string_0;
			this.textBox2.Text = Class1.class7_0.dictionary_0[this.int_0].int_0.ToString();
			this.comboBox2.Text = (Class1.class7_0.dictionary_0[this.int_0].bool_0 ? "Server" : "Client");
		}
	}

	// Token: 0x04000066 RID: 102
	public int int_0 = -1;
}
