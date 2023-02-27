using System;
using System.Windows.Forms;
using NovoFatum_R3;

// Token: 0x0200003F RID: 63
internal static class Class32
{
	// Token: 0x060001DA RID: 474 RVA: 0x00003393 File Offset: 0x00001593
	[STAThread]
	private static void Main()
	{
		Class32.appDomain_0 = AppDomain.CreateDomain("NovoFatum R3", null);
		Class1.smethod_0();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Class0.main_0 = new Main();
		Application.Run(Class0.main_0);
	}

	// Token: 0x04000155 RID: 341
	public static AppDomain appDomain_0;
}
