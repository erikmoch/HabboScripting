using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Token: 0x0200003D RID: 61
public partial class Packetlogger : Form
{
	// Token: 0x060001B1 RID: 433 RVA: 0x0000332F File Offset: 0x0000152F
	public Packetlogger()
	{
		this.InitializeComponent();
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00014394 File Offset: 0x00012594
	private void Packetlogger_Load(object sender, EventArgs e)
	{
		this.fontDialog_0.Font = this.richTextBox1.Font;
		bool flag = false;
		Class1.bool_1 = false;
		Class1.bool_0 = flag;
		this.delegate1_1 = new Packetlogger.Delegate1(this.method_1);
		this.delegate1_0 = new Packetlogger.Delegate1(this.method_0);
		this.color_0 = Color.PaleGreen;
		this.color_1 = Color.MediumPurple;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00014400 File Offset: 0x00012600
	public void method_0(int int_1, string string_0)
	{
		if (base.InvokeRequired)
		{
			base.Invoke(this.delegate1_0, new object[]
			{
				int_1,
				string_0
			});
		}
		else
		{
			if (int_1 > 0)
			{
				this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
				this.richTextBox1.SelectionLength = 0;
				this.richTextBox1.SelectionColor = this.color_0;
				this.richTextBox1.AppendText(string.Concat(new object[]
				{
					"[LOG][SERVER] > ",
					int_1,
					": ",
					string_0,
					Environment.NewLine
				}));
			}
			else
			{
				this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
				this.richTextBox1.SelectionLength = 0;
				this.richTextBox1.SelectionColor = Color.Red;
				this.richTextBox1.AppendText("[INFO][SERVER] > " + string_0 + Environment.NewLine);
			}
			this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
			if (this.bool_0)
			{
				this.richTextBox1.ScrollToCaret();
			}
		}
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00014538 File Offset: 0x00012738
	public void method_1(int int_1, string string_0)
	{
		if (base.InvokeRequired)
		{
			base.Invoke(this.delegate1_1, new object[]
			{
				int_1,
				string_0
			});
		}
		else
		{
			if (int_1 > 0)
			{
				this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
				this.richTextBox1.SelectionLength = 0;
				this.richTextBox1.SelectionColor = this.color_1;
				this.richTextBox1.AppendText(string.Concat(new object[]
				{
					"[LOG][CLIENT] > ",
					int_1,
					": ",
					string_0,
					Environment.NewLine
				}));
			}
			else
			{
				this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
				this.richTextBox1.SelectionLength = 0;
				this.richTextBox1.SelectionColor = Color.Red;
				this.richTextBox1.AppendText("[INFO][CLIENT] > " + string_0 + Environment.NewLine);
			}
			this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
			if (this.bool_0)
			{
				this.richTextBox1.ScrollToCaret();
			}
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002616 File Offset: 0x00000816
	private void richTextBox1_SizeChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002616 File Offset: 0x00000816
	private void Packetlogger_SizeChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002616 File Offset: 0x00000816
	private void Packetlogger_Resize(object sender, EventArgs e)
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002616 File Offset: 0x00000816
	private void timer_0_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002616 File Offset: 0x00000816
	private void method_2(object sender, EventArgs e)
	{
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002616 File Offset: 0x00000816
	private void method_3(object sender, EventArgs e)
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002616 File Offset: 0x00000816
	private void method_4(object sender, EventArgs e)
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00002616 File Offset: 0x00000816
	private void method_5(object sender, EventArgs e)
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002616 File Offset: 0x00000816
	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00003359 File Offset: 0x00001559
	private void Packetlogger_FormClosed(object sender, FormClosedEventArgs e)
	{
		Class0.packetlogger_0 = null;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00014670 File Offset: 0x00012870
	private void stopTheServerLogToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.stopTheServerLogToolStripMenuItem.Text == "Stop the server log")
		{
			this.stopTheServerLogToolStripMenuItem.Text = "Start the server log";
			Class1.bool_1 = true;
		}
		else
		{
			this.stopTheServerLogToolStripMenuItem.Text = "Stop the server log";
			Class1.bool_1 = false;
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002616 File Offset: 0x00000816
	private void method_6(object sender, EventArgs e)
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x000146C8 File Offset: 0x000128C8
	private void stopTheClientLogToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.stopTheClientLogToolStripMenuItem.Text == "Stop the client log")
		{
			this.stopTheClientLogToolStripMenuItem.Text = "Start the client log";
			Class1.bool_0 = true;
		}
		else
		{
			this.stopTheClientLogToolStripMenuItem.Text = "Stop the client log";
			Class1.bool_0 = false;
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002616 File Offset: 0x00000816
	private void method_7(object sender, EventArgs e)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00003361 File Offset: 0x00001561
	private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.richTextBox1.ResetText();
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002616 File Offset: 0x00000816
	private void method_8(object sender, EventArgs e)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002616 File Offset: 0x00000816
	private void Packetlogger_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00014720 File Offset: 0x00012920
	private void Packetlogger_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode.ToString() == "F4")
		{
			this.txtSearch.Visible = !this.txtSearch.Visible;
			this.richTextBox1.Select(0, 0);
		}
		else if (e.KeyCode == Keys.Return)
		{
			int num = 0;
			if (this.txtSearch.Text.Length > 5)
			{
				num = this.method_9(this.txtSearch.Text.Trim(), this.int_0, this.richTextBox1.Text.Length);
			}
			if (num >= 0)
			{
				this.richTextBox1.SelectionBackColor = Color.LightYellow;
				int length = this.txtSearch.Text.Length;
				this.richTextBox1.Select(num, length);
				this.richTextBox1.ScrollToCaret();
				this.int_0 = num + length;
			}
			else
			{
				this.int_0 = 0;
			}
		}
		else if (e.KeyCode.ToString() == "F7")
		{
			if (this.stopTheClientLogToolStripMenuItem.Text == "Stop the client log")
			{
				this.stopTheClientLogToolStripMenuItem.Text = "Start the client log";
				Class1.bool_0 = true;
			}
			else
			{
				this.stopTheClientLogToolStripMenuItem.Text = "Stop the client log";
				Class1.bool_0 = false;
			}
		}
		else if (e.KeyCode.ToString() == "F3")
		{
			this.richTextBox1.Clear();
		}
		else if (e.KeyCode.ToString() == "F8")
		{
			if (this.stopTheServerLogToolStripMenuItem.Text == "Stop the server log")
			{
				this.stopTheServerLogToolStripMenuItem.Text = "Start the server log";
				Class1.bool_1 = true;
			}
			else
			{
				this.stopTheServerLogToolStripMenuItem.Text = "Stop the server log";
				Class1.bool_1 = false;
			}
		}
		else if (e.KeyCode.ToString() == "F9")
		{
			if (base.Opacity == 0.78)
			{
				base.Opacity = 1.0;
			}
			else
			{
				base.Opacity = 0.78;
			}
			this.Refresh();
		}
		else if (e.KeyCode.ToString() == "F10")
		{
			this.txtInject.Visible = !this.txtInject.Visible;
			this.bool_1 = true;
		}
		else if (e.KeyCode.ToString() == "F11")
		{
			this.txtInject.Visible = !this.txtInject.Visible;
			this.bool_1 = false;
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00014A18 File Offset: 0x00012C18
	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		int num = 0;
		if (this.txtSearch.Text.Length > 5)
		{
			num = this.method_9(this.txtSearch.Text.Trim(), this.int_0, this.richTextBox1.Text.Length);
		}
		if (num >= 0)
		{
			this.richTextBox1.SelectionBackColor = Color.LightYellow;
			int length = this.txtSearch.Text.Length;
			this.richTextBox1.Select(num, length);
			this.richTextBox1.ScrollToCaret();
			this.int_0 = 0;
		}
		else
		{
			this.int_0 = 0;
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00014ABC File Offset: 0x00012CBC
	public int method_9(string string_0, int int_1, int int_2)
	{
		int num = 0;
		if (int_1 > 0 && int_2 > 0 && num >= 0)
		{
			this.richTextBox1.Undo();
		}
		int result = -1;
		if (int_1 >= 0 && num >= 0 && (int_2 > int_1 || int_2 == -1))
		{
			num = this.richTextBox1.Find(string_0, int_1, int_2, RichTextBoxFinds.None);
			if (num != -1)
			{
				result = num;
			}
		}
		return result;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00014B24 File Offset: 0x00012D24
	private void txtInject_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Encoding.Default.GetString(Class15.smethod_1(this.txtInject.Text.Length)) + this.txtInject.Text;
			if (!this.bool_1)
			{
				Class1.class19_0.method_8(Encoding.Default.GetBytes(Class16.smethod_2(this.txtInject.Text)));
			}
			else
			{
				Class1.class19_0.method_7(Encoding.Default.GetBytes(Class16.smethod_2(this.txtInject.Text)));
			}
		}
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002616 File Offset: 0x00000816
	private void txtInject_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00014BC8 File Offset: 0x00012DC8
	private void saveHabboswfToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Task task = new Task(new Action(this.method_10));
		task.Start();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00014BF0 File Offset: 0x00012DF0
	private void method_10()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile("http://habbo.hs.llnwd.net/gordon/" + Class1.string_3 + "/Habbo.swf", Environment.CurrentDirectory + "\\" + Class1.string_3 + ".swf");
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00014C38 File Offset: 0x00012E38
	private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (File.Exists(Class1.string_3 + ".txt"))
		{
			File.Delete(Class1.string_3 + ".txt");
		}
		StreamWriter streamWriter = new StreamWriter(Class1.string_3 + ".txt");
		streamWriter.Write(this.richTextBox1.Text);
		streamWriter.Close();
		this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
		this.richTextBox1.SelectionLength = 0;
		this.richTextBox1.SelectionColor = Color.Red;
		this.richTextBox1.AppendText("Generated " + Class1.string_3 + ".txt" + Environment.NewLine);
		this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
		if (this.bool_0)
		{
			this.richTextBox1.ScrollToCaret();
		}
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002616 File Offset: 0x00000816
	private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00014D28 File Offset: 0x00012F28
	private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = this.richTextBox1.BackColor;
		DialogResult dialogResult = this.colorDialog_0.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			this.richTextBox1.BackColor = this.colorDialog_0.Color;
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00014D78 File Offset: 0x00012F78
	private void fontFamilyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		DialogResult dialogResult = this.fontDialog_0.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			this.richTextBox1.SelectAll();
			this.richTextBox1.Font = this.fontDialog_0.Font;
			this.richTextBox1.DeselectAll();
		}
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002616 File Offset: 0x00000816
	private void fontDialog_0_Apply(object sender, EventArgs e)
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00014DC8 File Offset: 0x00012FC8
	private void clientToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = this.color_1;
		DialogResult dialogResult = this.colorDialog_0.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			this.color_1 = this.colorDialog_0.Color;
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00014E0C File Offset: 0x0001300C
	private void serverToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = this.color_0;
		DialogResult dialogResult = this.colorDialog_0.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			this.color_0 = this.colorDialog_0.Color;
		}
	}

	// Token: 0x04000139 RID: 313
	private Packetlogger.Delegate1 delegate1_0;

	// Token: 0x0400013A RID: 314
	private Packetlogger.Delegate1 delegate1_1;

	// Token: 0x0400013B RID: 315
	private bool bool_0 = true;

	// Token: 0x0400013C RID: 316
	private int int_0 = 0;

	// Token: 0x0400013D RID: 317
	private bool bool_1 = false;

	// Token: 0x0400013E RID: 318
	private Color color_0;

	// Token: 0x0400013F RID: 319
	private Color color_1;

	// Token: 0x0200003E RID: 62
	// (Invoke) Token: 0x060001D7 RID: 471
	private delegate void Delegate1(int messageId, string body);
}
