using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200000E RID: 14
public partial class LittleJMode : Form
{
	// Token: 0x06000053 RID: 83 RVA: 0x000029F2 File Offset: 0x00000BF2
	public LittleJMode()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000028AC File Offset: 0x00000AAC
	private void button1_Click(object sender, EventArgs e)
	{
		Class0.main_0.method_10();
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00007F9C File Offset: 0x0000619C
	private void button4_Click(object sender, EventArgs e)
	{
		new LittleJMode_AddTimer(-1)
		{
			ShowIcon = false
		}.ShowDialog();
		this.method_0();
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00007FC4 File Offset: 0x000061C4
	private void method_0()
	{
		this.listView1.Items.Clear();
		foreach (int key in Class1.class7_0.dictionary_0.Keys)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = key.ToString();
			listViewItem.SubItems.AddRange(new string[]
			{
				Class1.class7_0.dictionary_0[key].string_0,
				Class1.class7_0.dictionary_0[key].int_0.ToString()
			});
			this.listView1.Items.Add(listViewItem);
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002A07 File Offset: 0x00000C07
	private void LittleJMode_Load(object sender, EventArgs e)
	{
		this.method_0();
		this.saveFileDialog_0.DefaultExt = ".nvt";
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00008098 File Offset: 0x00006298
	private void listView1_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = this.listView1.SelectedItems[0];
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000080B8 File Offset: 0x000062B8
	private void button5_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listView1.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			int int_ = Convert.ToInt32(listViewItem.Text);
			Class1.class7_0.method_1(int_);
		}
		this.method_0();
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00008130 File Offset: 0x00006330
	private void listView1_ItemActivate(object sender, EventArgs e)
	{
		ListViewItem listViewItem = this.listView1.SelectedItems[0];
		new LittleJMode_AddTimer(Convert.ToInt32(listViewItem.Text))
		{
			ShowIcon = false
		}.ShowDialog();
		this.method_0();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002A1F File Offset: 0x00000C1F
	private void button2_Click(object sender, EventArgs e)
	{
		this.saveFileDialog_0.ShowDialog();
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002A2D File Offset: 0x00000C2D
	private void button3_Click(object sender, EventArgs e)
	{
		this.openFileDialog_0.Title = "NovoFatum Timer";
		this.openFileDialog_0.FileName = "";
		this.openFileDialog_0.Filter = "NovoFatum Timer File (*.nvt)|*.nvt";
		this.openFileDialog_0.ShowDialog();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00008174 File Offset: 0x00006374
	private void saveFileDialog_0_FileOk(object sender, CancelEventArgs e)
	{
		if (!(this.saveFileDialog_0.FileName == ""))
		{
			Class4 @class = new Class4(this.saveFileDialog_0.FileName);
			@class.method_1(Class1.class7_0.dictionary_0.Count);
			foreach (Class8 class2 in Class1.class7_0.dictionary_0.Values)
			{
				@class.method_0(Convert.ToBase64String(class2.byte_0));
				@class.method_0(class2.string_0);
				@class.method_1(class2.int_0);
				@class.method_0(class2.bool_0 ? "1" : "0");
			}
			@class.method_2();
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00008258 File Offset: 0x00006458
	private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
	{
		if (!(this.openFileDialog_0.FileName == ""))
		{
			Class3 @class = new Class3(this.openFileDialog_0.FileName);
			int num = @class.method_0();
			for (int i = 0; i < num; i++)
			{
				Class8 class2 = new Class8();
				class2.byte_0 = Convert.FromBase64String(@class.method_1());
				class2.string_0 = @class.method_1();
				class2.int_0 = @class.method_0();
				class2.bool_0 = (@class.method_1() == "1");
				Class1.class7_0.method_0(class2);
			}
			this.method_0();
		}
	}
}
