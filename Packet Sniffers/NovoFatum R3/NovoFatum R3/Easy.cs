using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000009 RID: 9
public partial class Easy : Form
{
	// Token: 0x06000030 RID: 48 RVA: 0x0000282E File Offset: 0x00000A2E
	public Easy()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000026D2 File Offset: 0x000008D2
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_3();
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002616 File Offset: 0x00000816
	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00005CB8 File Offset: 0x00003EB8
	private void button2_Click(object sender, EventArgs e)
	{
		Class1.bool_3 = true;
		string text = this.comboBox2.Text.ToLower();
		switch (text)
		{
		case "com":
			Class1.string_7 = "game-us.habbo.com";
			Class1.int_1 = 38101;
			break;
		case "br":
			Class1.string_7 = "game-br-oivoieitaas.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "tr":
			Class1.string_7 = "game-tr.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "no":
			Class1.string_7 = "game-no.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "dk":
			Class1.string_7 = "game-dk.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "fi":
			Class1.string_7 = "game-fi.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "fr":
			Class1.string_7 = "game-fr.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "es":
			Class1.string_7 = "game-es.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "it":
			Class1.string_7 = "game-it.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "de":
			Class1.string_7 = "game-de.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "se":
			Class1.string_7 = "game-se.habbo.com";
			Class1.int_1 = 30000;
			break;
		case "nl":
			Class1.string_7 = "game-nl.habbo.com";
			Class1.int_1 = 30000;
			break;
		}
		Class1.string_6 = this.comboBox2.Text.ToLower();
		Class0.main_0.method_23();
	}
}
