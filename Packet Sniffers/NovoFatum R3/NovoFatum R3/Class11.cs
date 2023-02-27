using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using PluginInterface;

// Token: 0x02000026 RID: 38
internal class Class11 : IPluginHost
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060000EA RID: 234 RVA: 0x0000DC80 File Offset: 0x0000BE80
	public string ClientRELEASE
	{
		get
		{
			return Class1.string_3;
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002616 File Offset: 0x00000816
	public void FilterParametres(byte[] Data, bool ToServer)
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000DC94 File Offset: 0x0000BE94
	public Class11()
	{
		if (!Directory.Exists(Environment.CurrentDirectory + "\\data\\plugins"))
		{
			Directory.CreateDirectory(Environment.CurrentDirectory + "\\data\\plugins");
		}
		this.gclass3_0 = new GClass3();
		this.method_0();
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002EB9 File Offset: 0x000010B9
	public void method_0()
	{
		this.method_1(Environment.CurrentDirectory + "\\data\\plugins");
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
	public void method_1(string string_0)
	{
		this.gclass3_0.Clear();
		foreach (string text in Directory.GetFiles(string_0))
		{
			FileInfo fileInfo = new FileInfo(text);
			if (fileInfo.Extension.Equals(".dll"))
			{
				this.method_7(text);
			}
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000DD48 File Offset: 0x0000BF48
	public void method_2()
	{
		lock (this.gclass3_0)
		{
			foreach (object obj2 in this.gclass3_0)
			{
				GClass4 gclass = (GClass4)obj2;
				gclass.IPlugin_0.Dispose();
				gclass.IPlugin_0 = null;
			}
		}
		this.gclass3_0.Clear();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000DDEC File Offset: 0x0000BFEC
	public bool method_3(string string_0)
	{
		lock (this.gclass3_0)
		{
			foreach (object obj2 in this.gclass3_0)
			{
				GClass4 gclass = (GClass4)obj2;
				if (gclass.IPlugin_0.Name.ToLower() == string_0.ToLower())
				{
					gclass.IPlugin_0.Dispose();
					gclass.IPlugin_0 = null;
					this.gclass3_0.method_1(gclass);
					string[] array = gclass.String_0.Split(new char[]
					{
						'\\'
					});
					this.list_0.Add(array[array.Length - 1]);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000DEEC File Offset: 0x0000C0EC
	public bool method_4(string string_0)
	{
		Assembly assembly = Assembly.LoadFrom(string_0);
		try
		{
			foreach (Type type in assembly.GetTypes())
			{
				if (type.IsPublic && !type.IsAbstract)
				{
					Type @interface = type.GetInterface("PluginInterface.IPlugin", true);
					if (@interface != null)
					{
						return true;
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0000DF68 File Offset: 0x0000C168
	public void method_5(byte[] byte_0)
	{
		lock (this.gclass3_0)
		{
			foreach (object obj2 in this.gclass3_0)
			{
				GClass4 gclass = (GClass4)obj2;
				gclass.IPlugin_0.DataFromClient(byte_0);
			}
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000DFFC File Offset: 0x0000C1FC
	public void method_6(byte[] byte_0)
	{
		lock (this.gclass3_0)
		{
			foreach (object obj2 in this.gclass3_0)
			{
				GClass4 gclass = (GClass4)obj2;
				gclass.IPlugin_0.DataFromServer(byte_0);
			}
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0000E090 File Offset: 0x0000C290
	public void method_7(string string_0)
	{
		Assembly assembly = Assembly.LoadFile(string_0);
		try
		{
			foreach (Type type in assembly.GetTypes())
			{
				if (type.IsPublic && !type.IsAbstract)
				{
					Type @interface = type.GetInterface("PluginInterface.IPlugin", true);
					if (@interface != null)
					{
						GClass4 gclass = new GClass4();
						gclass.String_0 = string_0;
						gclass.IPlugin_0 = (IPlugin)Activator.CreateInstance(assembly.GetType(type.ToString()));
						gclass.IPlugin_0.Host = this;
						gclass.IPlugin_0.Initialize();
						this.gclass3_0.method_0(gclass);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002ED0 File Offset: 0x000010D0
	public void SendDataToServer(byte[] Data)
	{
		if (Class1.class19_0 != null)
		{
			Class1.class19_0.method_8(Data);
		}
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002EE7 File Offset: 0x000010E7
	public void SendDataToClient(byte[] Data)
	{
		if (Class1.class19_0 != null)
		{
			Class1.class19_0.method_7(Data);
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002EFE File Offset: 0x000010FE
	public void method_8()
	{
		this.method_2();
		this.gclass3_0.Clear();
		this.gclass3_0 = null;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000E164 File Offset: 0x0000C364
	public GClass4 method_9(string string_0)
	{
		lock (this.gclass3_0)
		{
			foreach (object obj2 in this.gclass3_0)
			{
				GClass4 gclass = (GClass4)obj2;
				if (gclass.IPlugin_0.Name.ToLower() == string_0.ToLower())
				{
					return gclass;
				}
			}
		}
		return null;
	}

	// Token: 0x040000DE RID: 222
	public GClass3 gclass3_0;

	// Token: 0x040000DF RID: 223
	public List<string> list_0 = new List<string>();
}
