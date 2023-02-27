using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000013 RID: 19
public partial class IntraChat_LOGIN : Form
{
	// Token: 0x06000082 RID: 130 RVA: 0x00002C1D File Offset: 0x00000E1D
	public IntraChat_LOGIN()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000026D2 File Offset: 0x000008D2
	private void button3_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_3();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002C32 File Offset: 0x00000E32
	private void IntraChat_LOGIN_Load(object sender, EventArgs e)
	{
		if (Class1.class5_0 == null || !Class1.class5_0.bool_0)
		{
		}
		if (Class1.class5_0 == null)
		{
			Class1.class5_0 = new Class5();
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002616 File Offset: 0x00000816
	private void method_0(object sender, EventArgs e)
	{
	}
}
