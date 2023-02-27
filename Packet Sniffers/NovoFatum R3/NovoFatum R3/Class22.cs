using System;
using System.Runtime.CompilerServices;
using Fiddler;

// Token: 0x02000033 RID: 51
internal class Class22
{
	// Token: 0x06000138 RID: 312 RVA: 0x0000F104 File Offset: 0x0000D304
	public static void smethod_0()
	{
		if (Class22.sessionStateHandler_0 == null)
		{
			Class22.sessionStateHandler_0 = new SessionStateHandler(Class22.smethod_2);
		}
		FiddlerApplication.BeforeRequest += Class22.sessionStateHandler_0;
		FiddlerApplication.Prefs.SetBoolPref("fiddler.network.streaming.abortifclientaborts", true);
		FiddlerApplication.Startup(12345, FiddlerCoreStartupFlags.RegisterAsSystemProxy | FiddlerCoreStartupFlags.AllowRemoteClients | FiddlerCoreStartupFlags.ChainToUpstreamGateway | FiddlerCoreStartupFlags.MonitorAllConnections | FiddlerCoreStartupFlags.CaptureLocalhostTraffic);
		Class22.bool_0 = true;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000317A File Offset: 0x0000137A
	public static void smethod_1()
	{
		FiddlerApplication.Shutdown();
		Class22.bool_0 = false;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00003187 File Offset: 0x00001387
	[CompilerGenerated]
	private static void smethod_2(Session session_0)
	{
		if (session_0.fullUrl == "http://habbo.hs.llnwd.net/dcr/hof_furni/39635/kuurna_chair.swf")
		{
			session_0.fullUrl = "http://images.habbo.com/";
		}
	}

	// Token: 0x040000FD RID: 253
	public static bool bool_0 = false;

	// Token: 0x040000FE RID: 254
	[CompilerGenerated]
	private static SessionStateHandler sessionStateHandler_0;
}
