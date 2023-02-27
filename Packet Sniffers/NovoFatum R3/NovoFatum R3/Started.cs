using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using NovoFatum_R3.Properties;

// Token: 0x02000041 RID: 65
public partial class Started : Form
{
	// Token: 0x060001E0 RID: 480 RVA: 0x0000343B File Offset: 0x0000163B
	public Started()
	{
		this.InitializeComponent();
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000026D2 File Offset: 0x000008D2
	private void button2_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_3();
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002652 File Offset: 0x00000852
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_15();
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00015FB0 File Offset: 0x000141B0
	private void Started_Load(object sender, EventArgs e)
	{
		if (Class1.bool_3)
		{
			WebClient webClient = new WebClient();
			webClient.Headers[40] = Class1.string_1;
			Class1.class18_0 = new Class18(Class1.string_7, Class1.int_1);
		}
		else
		{
			StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\http-headers.txt");
			string text = streamReader.ReadToEnd();
			Class1.string_0 = text.Substring(text.LastIndexOf("Cookie: ")).Split(new char[]
			{
				Environment.NewLine[0]
			})[0].Substring(8);
			Class1.string_1 = text.Substring(text.LastIndexOf("User-Agent: ")).Split(new char[]
			{
				Environment.NewLine[0]
			})[0].Substring(12);
			streamReader.Close();
			File.Delete(Environment.CurrentDirectory + "\\http-headers.txt");
			Class1.class18_0 = new Class18(Class6.smethod_3("connection.info.host", false).ToString(), Convert.ToInt32(Class6.smethod_3("connection.info.port", true)));
			Class12.smethod_1();
		}
	}
}
