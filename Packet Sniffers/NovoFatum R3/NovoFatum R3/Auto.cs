using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NovoFatum_R3.Properties;

// Token: 0x02000008 RID: 8
public partial class Auto : Form
{
	// Token: 0x06000028 RID: 40 RVA: 0x000027ED File Offset: 0x000009ED
	public Auto()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000027BC File Offset: 0x000009BC
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_14();
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000056CC File Offset: 0x000038CC
	private void method_0(object sender, EventArgs e)
	{
		if (this.byte_0 == 0)
		{
			this.pictureBox1.Image = Resources.Bitmap_1;
			this.label1.Text = "Open the Habbo Client";
			this.byte_0 = 1;
		}
		else if (this.byte_0 == 1)
		{
			this.pictureBox1.Image = Resources.Bitmap_2;
			this.label1.Text = "Enjoy with NovoFatum :)!";
			this.byte_0 = 2;
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00005748 File Offset: 0x00003948
	private void button2_Click(object sender, EventArgs e)
	{
		if (this.byte_0 == 0)
		{
			Class12.smethod_0();
			this.pictureBox1.Image = Resources.Bitmap_1;
			this.label1.Text = "Open the Habbo Client";
			this.byte_0 = 1;
		}
		else if (this.byte_0 == 1)
		{
			this.pictureBox1.Image = Resources.Bitmap_2;
			this.label1.Text = "Enjoy with NovoFatum :)!";
			this.byte_0 = 2;
			this.button1.Enabled = false;
			this.button2.Enabled = false;
		}
		else if (this.byte_0 != 2)
		{
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000057F0 File Offset: 0x000039F0
	private void pictureBox2_Click(object sender, EventArgs e)
	{
		string[] array = new string[]
		{
			"Ouch!",
			"Habbo without scripting was bored!",
			"Is the scripting dead?",
			"NovoFatum R3! Have fun! :-)"
		};
		Random random = new Random();
		int num = random.Next(0, array.Length);
		MessageBox.Show(array[num]);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002616 File Offset: 0x00000816
	private void label1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0400002F RID: 47
	private byte byte_0 = 0;
}
