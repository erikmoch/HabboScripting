using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NovoFatum_R3.Properties;

// Token: 0x02000019 RID: 25
public partial class NovoFatum : Form
{
	// Token: 0x060000BE RID: 190 RVA: 0x00002DA2 File Offset: 0x00000FA2
	public NovoFatum()
	{
		this.InitializeComponent();
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002652 File Offset: 0x00000852
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_15();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002DB7 File Offset: 0x00000FB7
	private void method_0(object sender, EventArgs e)
	{
		Class0.main_0.method_19();
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002DB7 File Offset: 0x00000FB7
	private void pictureBox2_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_19();
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002DC3 File Offset: 0x00000FC3
	private void label6_Click(object sender, EventArgs e)
	{
		Class1.smethod_3("http://darkbox.nl");
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002DCF File Offset: 0x00000FCF
	private void label4_Click(object sender, EventArgs e)
	{
		Class1.smethod_3("http://habbo-dev.com");
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002DDB File Offset: 0x00000FDB
	private void label5_Click(object sender, EventArgs e)
	{
		Class1.smethod_3("http://kekomundo.com");
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002616 File Offset: 0x00000816
	private void label7_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002DE7 File Offset: 0x00000FE7
	private void label2_Click(object sender, EventArgs e)
	{
		Class1.smethod_3("http://shenkx.co.uk");
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002616 File Offset: 0x00000816
	private void label1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000CB80 File Offset: 0x0000AD80
	private void label3_Click(object sender, EventArgs e)
	{
		AlertError alertError = new AlertError();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Twitter: @RSALittleJ");
		stringBuilder.AppendLine("Habbo: RSALittleJ/RSALittleJ1");
		stringBuilder.AppendLine("MSN: littlej@hotmail.es/Skype: littlejkm");
		alertError.method_0("Contact me", stringBuilder.ToString());
		alertError.ShowDialog();
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002DF3 File Offset: 0x00000FF3
	private void label8_Click(object sender, EventArgs e)
	{
		Class1.smethod_3("http://exploitsclic.tk");
	}
}
