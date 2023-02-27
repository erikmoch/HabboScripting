using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Token: 0x0200000D RID: 13
public partial class HabboEncoding_Form : Form
{
	// Token: 0x0600004B RID: 75 RVA: 0x0000296A File Offset: 0x00000B6A
	public HabboEncoding_Form()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000297F File Offset: 0x00000B7F
	private void button2_Click(object sender, EventArgs e)
	{
		this.textBox2.Text = Class16.smethod_0(Class15.smethod_1(Convert.ToInt32(this.textBox1.Text)));
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000029A6 File Offset: 0x00000BA6
	private void button3_Click(object sender, EventArgs e)
	{
		this.textBox2.Text = Class16.smethod_0(Class15.smethod_0(Convert.ToInt32(this.textBox1.Text)));
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000076AC File Offset: 0x000058AC
	private void button4_Click(object sender, EventArgs e)
	{
		this.textBox1.Text = Class15.smethod_2(Encoding.Default.GetBytes(Class16.smethod_2(this.textBox2.Text))).ToString();
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000076EC File Offset: 0x000058EC
	private void button5_Click(object sender, EventArgs e)
	{
		this.textBox1.Text = Class15.smethod_3(Encoding.Default.GetBytes(Class16.smethod_2(this.textBox2.Text))).ToString();
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000028AC File Offset: 0x00000AAC
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_10();
	}
}
