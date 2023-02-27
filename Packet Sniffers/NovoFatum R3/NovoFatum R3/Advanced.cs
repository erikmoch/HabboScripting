using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000007 RID: 7
public partial class Advanced : Form
{
	// Token: 0x06000023 RID: 35 RVA: 0x000027A7 File Offset: 0x000009A7
	public Advanced()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000027BC File Offset: 0x000009BC
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_14();
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00004F90 File Offset: 0x00003190
	private void button2_Click(object sender, EventArgs e)
	{
		Class1.string_8 = this.textBox1.Text;
		Class1.string_9 = this.textBox2.Text;
		Class1.string_10 = this.textBox3.Text;
		Class1.string_11 = this.textBox4.Text;
		Class0.main_0.method_13();
	}
}
