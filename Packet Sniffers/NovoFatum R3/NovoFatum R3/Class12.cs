using System;
using System.Runtime.CompilerServices;
using Fiddler;

// Token: 0x02000029 RID: 41
internal class Class12
{
	// Token: 0x06000104 RID: 260 RVA: 0x0000E308 File Offset: 0x0000C508
	public static void smethod_0()
	{
		if (Class12.sessionStateHandler_0 == null)
		{
			Class12.sessionStateHandler_0 = new SessionStateHandler(Class12.smethod_2);
		}
		FiddlerApplication.AfterSessionComplete += Class12.sessionStateHandler_0;
		FiddlerApplication.Prefs.SetBoolPref("fiddler.network.streaming.abortifclientaborts", true);
		FiddlerApplication.Startup(12345, FiddlerCoreStartupFlags.RegisterAsSystemProxy | FiddlerCoreStartupFlags.AllowRemoteClients | FiddlerCoreStartupFlags.ChainToUpstreamGateway | FiddlerCoreStartupFlags.MonitorAllConnections | FiddlerCoreStartupFlags.CaptureLocalhostTraffic);
		Class12.bool_0 = true;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002F90 File Offset: 0x00001190
	public static void smethod_1()
	{
		FiddlerApplication.Shutdown();
		Class12.bool_0 = false;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000E35C File Offset: 0x0000C55C
	[CompilerGenerated]
	private static void smethod_2(Session session_0)
	{
		if (Class1.string_8 == "")
		{
			if (session_0.fullUrl.Contains("habbo") && session_0.fullUrl.EndsWith("/client") && !session_0.fullUrl.Contains("facebook") && session_0.GetResponseBodyAsString().Contains("sso.ticket"))
			{
				session_0.SaveRequest(Environment.CurrentDirectory + "\\http-headers.txt", true);
				Class6.smethod_1();
				Class6.smethod_0(session_0.GetResponseBodyAsString());
				Class0.main_0.method_22();
			}
		}
		else if (session_0.fullUrl == Class1.string_8 && session_0.GetResponseBodyAsString().Contains("sso.ticket"))
		{
			session_0.SaveRequest(Environment.CurrentDirectory + "\\http-headers.txt", true);
			Class6.smethod_1();
			Class6.smethod_0(session_0.GetResponseBodyAsString());
			Class0.main_0.method_22();
		}
	}

	// Token: 0x040000E2 RID: 226
	public static bool bool_0 = false;

	// Token: 0x040000E3 RID: 227
	[CompilerGenerated]
	private static SessionStateHandler sessionStateHandler_0;
}
