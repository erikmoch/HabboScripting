using System;
using PluginInterface;

// Token: 0x02000028 RID: 40
public class GClass4
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x060000FD RID: 253 RVA: 0x0000E29C File Offset: 0x0000C49C
	// (set) Token: 0x060000FE RID: 254 RVA: 0x00002F56 File Offset: 0x00001156
	public IPlugin IPlugin_0
	{
		get
		{
			return this.iplugin_0;
		}
		set
		{
			this.iplugin_0 = value;
		}
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002F5F File Offset: 0x0000115F
	public void method_0(object sender, EventArgs e)
	{
		this.IPlugin_0.ExecuteInternalFunction();
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
	public void method_1(object sender, EventArgs e)
	{
		try
		{
			Class1.class11_0.method_3(this.IPlugin_0.Name);
		}
		catch
		{
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000101 RID: 257 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
	// (set) Token: 0x06000102 RID: 258 RVA: 0x00002F6D File Offset: 0x0000116D
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x040000E0 RID: 224
	private IPlugin iplugin_0 = null;

	// Token: 0x040000E1 RID: 225
	private string string_0 = "";
}
