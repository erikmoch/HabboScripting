using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000005 RID: 5
public partial class Changes : Form
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002683 File Offset: 0x00000883
	public Changes()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002652 File Offset: 0x00000852
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_15();
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00004494 File Offset: 0x00002694
	private void Changes_Load(object sender, EventArgs e)
	{
		Color[] array = new Color[]
		{
			Color.FromArgb(128, 128, 255),
			Color.FromArgb(128, 255, 128),
			Color.FromArgb(255, 192, 128),
			Color.FromArgb(255, 128, 255)
		};
		this.panel1.Controls.Clear();
		int num = 0;
		int num2 = 0;
		Class10.list_0.Add("NovoFatum R3");
		Class10.list_0.Add("NovoFatum R3");
		Class10.list_0.Add("NovoFatum R3");
		Class10.list_0.Add("NovoFatum R3");
		foreach (string text in Class10.list_0)
		{
			Button button = new Button();
			button.BackColor = array[num++];
			button.FlatStyle = FlatStyle.Popup;
			button.ForeColor = SystemColors.ButtonHighlight;
			if (num > array.Length)
			{
				num = 0;
			}
			button.Location = new Point(0, 59 * num2);
			button.Name = "button_" + num2;
			button.Size = new Size(630, 62);
			button.Text = text;
			button.UseVisualStyleBackColor = false;
			this.panel1.Controls.Add(button);
			num2++;
		}
		this.button2.Text = "Updates [" + num2 + "]";
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00004684 File Offset: 0x00002884
	private void button2_Click(object sender, EventArgs e)
	{
		foreach (string a in Class10.list_0)
		{
			if (!(a == "NovoFatum R3"))
			{
			}
		}
	}
}
