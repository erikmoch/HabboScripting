using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public partial class AlertError : Form
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002574 File Offset: 0x00000774
	public AlertError()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002589 File Offset: 0x00000789
	public void method_0(string string_2, string string_3)
	{
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002599 File Offset: 0x00000799
	private void AlertError_Load(object sender, EventArgs e)
	{
		this.label1.Text = this.string_0;
		this.label2.Text = this.string_1;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000025BD File Offset: 0x000007BD
	private void button2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x04000001 RID: 1
	private string string_0;

	// Token: 0x04000002 RID: 2
	private string string_1;
}
