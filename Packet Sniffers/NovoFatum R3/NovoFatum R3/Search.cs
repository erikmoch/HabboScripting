using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000040 RID: 64
public partial class Search : Form
{
	// Token: 0x060001DB RID: 475 RVA: 0x000033C9 File Offset: 0x000015C9
	public Search()
	{
		this.InitializeComponent();
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002652 File Offset: 0x00000852
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_15();
	}

	// Token: 0x060001DD RID: 477 RVA: 0x000033E5 File Offset: 0x000015E5
	private void textBox1_MouseClick(object sender, MouseEventArgs e)
	{
		if (!this.bool_0)
		{
			this.textBox1.Text = "";
			this.textBox1.ForeColor = Color.Black;
			this.bool_0 = true;
		}
	}

	// Token: 0x04000156 RID: 342
	private bool bool_0 = false;
}
