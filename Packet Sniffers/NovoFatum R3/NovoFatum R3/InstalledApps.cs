using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x02000012 RID: 18
public partial class InstalledApps : Form
{
	// Token: 0x06000077 RID: 119 RVA: 0x00002B83 File Offset: 0x00000D83
	public InstalledApps()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002B98 File Offset: 0x00000D98
	private void button4_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_21();
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002BA4 File Offset: 0x00000DA4
	private void InstalledApps_Load(object sender, EventArgs e)
	{
		this.method_0();
		Class1.bool_2 = false;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00009F44 File Offset: 0x00008144
	private void method_0()
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
			button.Location = new Point(0, 59 * num2);
			button.Name = "button_" + gclass.IPlugin_0.Name;
			button.Size = new Size(630, 62);
			button.Text = controlName;
			button.UseVisualStyleBackColor = false;
			button.Click += gclass.method_1;
			this.panel1.Controls.Add(button);
			num2++;
		}
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002BB2 File Offset: 0x00000DB2
	private void button2_Click(object sender, EventArgs e)
	{
		this.openFileDialog_0.Title = "NovoFatum Plugins";
		this.openFileDialog_0.FileName = "";
		this.openFileDialog_0.Filter = "NovoFatum Plugin (*.dll)|*.dll";
		this.openFileDialog_0.ShowDialog();
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000A114 File Offset: 0x00008314
	private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
	{
		if (!(this.openFileDialog_0.FileName == ""))
		{
			bool flag = Class1.class11_0.method_4(this.openFileDialog_0.FileName);
			Debug.WriteLine(this.method_1());
			if (!flag)
			{
				AlertError alertError = new AlertError();
				alertError.method_0("Error", "Invalid plugin file");
				alertError.ShowDialog();
			}
			else
			{
				string str = this.method_1();
				File.Copy(this.openFileDialog_0.FileName, Environment.CurrentDirectory + "\\data\\plugins\\" + str);
				Class1.class11_0.method_7(Environment.CurrentDirectory + "\\data\\plugins\\" + str);
				this.method_0();
			}
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000A1C8 File Offset: 0x000083C8
	private string method_1()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory + "\\data\\plugins\\");
		return string.Format("nv{0}.dll", (directoryInfo.LastWriteTime.Ticks + 1L).ToString("x2"));
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000A220 File Offset: 0x00008420
	private void button1_Click(object sender, EventArgs e)
	{
		Class1.bool_2 = !Class1.bool_2;
		if (Class1.bool_2)
		{
			AlertError alertError = new AlertError();
			alertError.method_0("Information", "Click one to unistall!");
			alertError.ShowDialog();
			this.timer_0.Start();
		}
		else
		{
			this.timer_0.Stop();
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002BF0 File Offset: 0x00000DF0
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.method_0();
	}
}
