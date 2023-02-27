using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Token: 0x02000010 RID: 16
public partial class NormalMode : Form
{
	// Token: 0x06000068 RID: 104 RVA: 0x00002AD8 File Offset: 0x00000CD8
	public NormalMode()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000028AC File Offset: 0x00000AAC
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_10();
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002616 File Offset: 0x00000816
	private void method_0(object sender, EventArgs e)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00009400 File Offset: 0x00007600
	private void button3_Click(object sender, EventArgs e)
	{
		if (this.textBox1.Text.Length < 4)
		{
			AlertError alertError = new AlertError();
			alertError.method_0("Information", "Fill all data");
			alertError.ShowDialog();
		}
		else
		{
			byte[] bytes = Encoding.Default.GetBytes(Class16.smethod_2(this.textBox1.Text));
			int num = bytes.Length - 4;
			int num2 = Class15.smethod_2(bytes);
			if (num != num2)
			{
				AlertError alertError = new AlertError();
				alertError.method_0("Habbo Security Filter", "If you send it, Habbo will be disconnected, NovoFatum" + Environment.NewLine + " R3 won't send the data");
				alertError.ShowDialog();
			}
			else if (Class1.class19_0 != null)
			{
				Class1.class19_0.method_7(bytes);
			}
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000094B8 File Offset: 0x000076B8
	private void button2_Click(object sender, EventArgs e)
	{
		if (this.textBox1.Text.Length < 4)
		{
			AlertError alertError = new AlertError();
			alertError.method_0("Information", "Fill all data");
			alertError.ShowDialog();
		}
		else
		{
			byte[] bytes = Encoding.Default.GetBytes(Class16.smethod_2(this.textBox1.Text));
			int num = bytes.Length - 4;
			int num2 = Class15.smethod_2(bytes);
			if (num != num2)
			{
				AlertError alertError = new AlertError();
				alertError.method_0("Habbo Security Filter", "If you send it, Habbo will be disconnected, NovoFatum" + Environment.NewLine + " R3 won't send the data");
				alertError.ShowDialog();
			}
			else if (Class1.class19_0 != null)
			{
				Class1.class19_0.method_8(bytes);
			}
		}
	}

	// Token: 0x04000072 RID: 114
	private bool bool_0 = false;
}
