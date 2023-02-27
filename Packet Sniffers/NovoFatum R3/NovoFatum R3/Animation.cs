using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000003 RID: 3
public partial class Animation : Form
{
	// Token: 0x06000007 RID: 7 RVA: 0x000025EA File Offset: 0x000007EA
	public Animation()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000260A File Offset: 0x0000080A
	private void Animation_MouseClick(object sender, MouseEventArgs e)
	{
		Class0.main_0.method_20();
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002616 File Offset: 0x00000816
	private void Animation_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000260A File Offset: 0x0000080A
	private void method_0(object sender, EventArgs e)
	{
		Class0.main_0.method_20();
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000260A File Offset: 0x0000080A
	private void method_1(object sender, EventArgs e)
	{
		Class0.main_0.method_20();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000037D4 File Offset: 0x000019D4
	private void timer_0_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		this.BackColor = Color.FromArgb(random.Next(254), random.Next(254), random.Next(254));
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003814 File Offset: 0x00001A14
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (this.label1.Location.Y > 0)
		{
			this.label1.Location = new Point(this.label1.Location.X, this.label1.Location.Y - 1);
		}
		else
		{
			this.label1.Location = new Point(this.label1.Location.X, this.int_0);
		}
		if (this.label2.Location.Y > 0)
		{
			this.label2.Location = new Point(this.label2.Location.X, this.label2.Location.Y - 1);
		}
		else
		{
			this.label2.Location = new Point(this.label2.Location.X, this.int_0);
		}
		if (this.label3.Location.Y > 0)
		{
			this.label3.Location = new Point(this.label3.Location.X, this.label3.Location.Y - 1);
		}
		else
		{
			this.label3.Location = new Point(this.label3.Location.X, this.int_0);
		}
		if (this.label4.Location.Y > 0)
		{
			this.label4.Location = new Point(this.label4.Location.X, this.label4.Location.Y - 1);
		}
		else
		{
			this.label4.Location = new Point(this.label4.Location.X, this.int_0);
		}
	}

	// Token: 0x04000007 RID: 7
	private int int_0 = 424;
}
