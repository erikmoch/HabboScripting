using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NovoFatum_R3
{
	// Token: 0x02000014 RID: 20
	public partial class Main : Form
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002C89 File Offset: 0x00000E89
		public Main()
		{
			this.InitializeComponent();
			this.delegate0_0 = new Main.Delegate0(this.method_22);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002616 File Offset: 0x00000816
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002616 File Offset: 0x00000816
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AD04 File Offset: 0x00008F04
		private void Main_Load(object sender, EventArgs e)
		{
			Class0.main_0.method_15();
			AlertError alertError = new AlertError();
			alertError.method_0("[Pwned Habbo patch release]", "NovoFatum is a free program. You can download \nfree from Habbo-Dev.com, ShenkX.co.uk, \nDarkbox.nl or KekoMundo.com\nWait for NF4 8-)");
			alertError.ShowDialog();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AD38 File Offset: 0x00008F38
		public void method_2()
		{
			AlertError alertError = new AlertError();
			alertError.method_0("Information", "Connection closed, reconnect!");
			alertError.ShowDialog();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AD64 File Offset: 0x00008F64
		public void method_3()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Desktop desktop = new Desktop();
			desktop.TopLevel = false;
			desktop.FormBorderStyle = FormBorderStyle.None;
			desktop.Visible = true;
			this.panel1.Controls.Add(desktop);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000AE04 File Offset: 0x00009004
		public void method_4()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			InstalledApps installedApps = new InstalledApps();
			installedApps.TopLevel = false;
			installedApps.FormBorderStyle = FormBorderStyle.None;
			installedApps.Visible = true;
			this.panel1.Controls.Add(installedApps);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000AEA4 File Offset: 0x000090A4
		public void method_5()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Advanced advanced = new Advanced();
			advanced.TopLevel = false;
			advanced.FormBorderStyle = FormBorderStyle.None;
			advanced.Visible = true;
			this.panel1.Controls.Add(advanced);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000AF44 File Offset: 0x00009144
		public void method_6()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			LittleJMode littleJMode = new LittleJMode();
			littleJMode.TopLevel = false;
			littleJMode.FormBorderStyle = FormBorderStyle.None;
			littleJMode.Visible = true;
			this.panel1.Controls.Add(littleJMode);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public void method_7()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			HabboEncoding_Form habboEncoding_Form = new HabboEncoding_Form();
			habboEncoding_Form.TopLevel = false;
			habboEncoding_Form.FormBorderStyle = FormBorderStyle.None;
			habboEncoding_Form.Visible = true;
			this.panel1.Controls.Add(habboEncoding_Form);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000B084 File Offset: 0x00009284
		public void method_8()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Tamper tamper = new Tamper();
			tamper.TopLevel = false;
			tamper.FormBorderStyle = FormBorderStyle.None;
			tamper.Visible = true;
			this.panel1.Controls.Add(tamper);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000B124 File Offset: 0x00009324
		public void method_9()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			ExpertMode expertMode = new ExpertMode();
			expertMode.TopLevel = false;
			expertMode.FormBorderStyle = FormBorderStyle.None;
			expertMode.Visible = true;
			this.panel1.Controls.Add(expertMode);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public void method_10()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			InjectionTools injectionTools = new InjectionTools();
			injectionTools.TopLevel = false;
			injectionTools.FormBorderStyle = FormBorderStyle.None;
			injectionTools.Visible = true;
			this.panel1.Controls.Add(injectionTools);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000B264 File Offset: 0x00009464
		public void method_11()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			NormalMode normalMode = new NormalMode();
			normalMode.TopLevel = false;
			normalMode.FormBorderStyle = FormBorderStyle.None;
			normalMode.Visible = true;
			this.panel1.Controls.Add(normalMode);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000B304 File Offset: 0x00009504
		public void method_12()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			IntraChat_LOGIN intraChat_LOGIN = new IntraChat_LOGIN();
			intraChat_LOGIN.TopLevel = false;
			intraChat_LOGIN.FormBorderStyle = FormBorderStyle.None;
			intraChat_LOGIN.Visible = true;
			this.panel1.Controls.Add(intraChat_LOGIN);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public void method_13()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Auto auto = new Auto();
			auto.TopLevel = false;
			auto.FormBorderStyle = FormBorderStyle.None;
			auto.Visible = true;
			this.panel1.Controls.Add(auto);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000B444 File Offset: 0x00009644
		public void method_14()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Connection connection = new Connection();
			connection.TopLevel = false;
			connection.FormBorderStyle = FormBorderStyle.None;
			connection.Visible = true;
			this.panel1.Controls.Add(connection);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000B4E4 File Offset: 0x000096E4
		public void method_15()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			MainWindow mainWindow = new MainWindow();
			mainWindow.TopLevel = false;
			mainWindow.FormBorderStyle = FormBorderStyle.None;
			mainWindow.Visible = true;
			this.panel1.Controls.Add(mainWindow);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000B584 File Offset: 0x00009784
		public void method_16()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Search search = new Search();
			search.TopLevel = false;
			search.FormBorderStyle = FormBorderStyle.None;
			search.Visible = true;
			this.panel1.Controls.Add(search);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000B624 File Offset: 0x00009824
		public void method_17()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Categories categories = new Categories();
			categories.TopLevel = false;
			categories.FormBorderStyle = FormBorderStyle.None;
			categories.Visible = true;
			this.panel1.Controls.Add(categories);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public void method_18()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Changes changes = new Changes();
			changes.TopLevel = false;
			changes.FormBorderStyle = FormBorderStyle.None;
			changes.Visible = true;
			this.panel1.Controls.Add(changes);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000B764 File Offset: 0x00009964
		public void method_19()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Animation animation = new Animation();
			animation.TopLevel = false;
			animation.FormBorderStyle = FormBorderStyle.None;
			animation.Visible = true;
			this.panel1.Controls.Add(animation);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000B804 File Offset: 0x00009A04
		public void method_20()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			NovoFatum novoFatum = new NovoFatum();
			novoFatum.TopLevel = false;
			novoFatum.FormBorderStyle = FormBorderStyle.None;
			novoFatum.Visible = true;
			this.panel1.Controls.Add(novoFatum);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		public void method_21()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Manage manage = new Manage();
			manage.TopLevel = false;
			manage.FormBorderStyle = FormBorderStyle.None;
			manage.Visible = true;
			this.panel1.Controls.Add(manage);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public void method_22()
		{
			if (base.InvokeRequired)
			{
				base.Invoke(this.delegate0_0);
			}
			else
			{
				this.method_23();
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B944 File Offset: 0x00009B44
		public void method_23()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Control control = (Control)obj;
				control.Dispose();
			}
			this.panel1.Controls.Clear();
			Started started = new Started();
			started.TopLevel = false;
			started.FormBorderStyle = FormBorderStyle.None;
			started.Visible = true;
			this.panel1.Controls.Add(started);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002616 File Offset: 0x00000816
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002CD2 File Offset: 0x00000ED2
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class1.smethod_1();
		}

		// Token: 0x04000090 RID: 144
		private Main.Delegate0 delegate0_0;

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000A7 RID: 167
		private delegate void Delegate0();
	}
}
