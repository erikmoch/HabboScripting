using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200000A RID: 10
public partial class Desktop : Form
{
	// Token: 0x06000036 RID: 54 RVA: 0x00002868 File Offset: 0x00000A68
	public Desktop()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002652 File Offset: 0x00000852
	private void button3_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_15();
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00006350 File Offset: 0x00004550
	private void button1_Click(object sender, EventArgs e)
	{
		if (Class6.string_0 != "")
		{
			AlertError alertError = new AlertError();
			alertError.method_0("Information", "Currently connected!");
			alertError.ShowDialog();
		}
		else
		{
			Class0.main_0.method_14();
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002616 File Offset: 0x00000816
	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000287D File Offset: 0x00000A7D
	private void button2_Click(object sender, EventArgs e)
	{
		if (Class0.packetlogger_0 == null)
		{
			Class0.packetlogger_0 = new Packetlogger();
			Class0.packetlogger_0.Show();
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000028A0 File Offset: 0x00000AA0
	private void button5_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_12();
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000028AC File Offset: 0x00000AAC
	private void button4_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_10();
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000028B8 File Offset: 0x00000AB8
	private void Desktop_Load(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000639C File Offset: 0x0000459C
	private void method_0()
	{
		Color[] array = new Color[]
		{
			Color.FromArgb(128, 128, 255),
			Color.FromArgb(128, 255, 128),
			Color.FromArgb(255, 192, 128),
			Color.FromArgb(255, 128, 255)
		};
		int num = 0;
		int num2 = 6;
		foreach (object obj in Class1.class11_0.gclass3_0)
		{
			GClass4 gclass = (GClass4)obj;
			string controlName = gclass.IPlugin_0.ControlName;
			Button button = new Button();
			button.BackColor = array[num++];
			button.FlatStyle = FlatStyle.Popup;
			button.ForeColor = SystemColors.ButtonHighlight;
			if (num > array.Length - 1)
			{
				num = 0;
			}
			if (num2 % 2 != 0)
			{
				button.Location = new Point(219 * (num2 / 2) + 12, 19);
			}
			else
			{
				button.Location = new Point(219 * (num2 / 2 - 1) + 12, 183);
			}
			button.Name = "button_" + gclass.IPlugin_0.Name;
			button.Size = new Size(211, 154);
			button.Text = controlName;
			button.UseVisualStyleBackColor = false;
			button.Click += gclass.method_0;
			this.panel1.Controls.Add(button);
			num2++;
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000028C0 File Offset: 0x00000AC0
	private void button6_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_8();
	}
}
