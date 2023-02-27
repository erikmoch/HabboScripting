using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000006 RID: 6
public partial class Connection : Form
{
	// Token: 0x0600001A RID: 26 RVA: 0x000026BD File Offset: 0x000008BD
	public Connection()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000026D2 File Offset: 0x000008D2
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_3();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000026DE File Offset: 0x000008DE
	private void method_0(object sender, EventArgs e)
	{
		this.button2.Enabled = true;
		this.button4.Enabled = true;
		this.button5.Enabled = true;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002704 File Offset: 0x00000904
	private void button4_Click(object sender, EventArgs e)
	{
		this.button2.Enabled = true;
		this.button4.Enabled = false;
		this.button5.Enabled = true;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000272A File Offset: 0x0000092A
	private void button5_Click(object sender, EventArgs e)
	{
		this.button2.Enabled = true;
		this.button4.Enabled = true;
		this.button5.Enabled = false;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002750 File Offset: 0x00000950
	private void button2_Click(object sender, EventArgs e)
	{
		if (!this.button4.Enabled)
		{
			Class0.main_0.method_13();
		}
		else if (!this.button5.Enabled)
		{
			Class0.main_0.method_5();
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002616 File Offset: 0x00000816
	private void Connection_Load(object sender, EventArgs e)
	{
	}
}
