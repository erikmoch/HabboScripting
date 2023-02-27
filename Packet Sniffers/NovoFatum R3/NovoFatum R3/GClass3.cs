using System;
using System.Collections;

// Token: 0x02000027 RID: 39
public class GClass3 : CollectionBase
{
	// Token: 0x060000F9 RID: 249 RVA: 0x00002F18 File Offset: 0x00001118
	public void method_0(GClass4 gclass4_0)
	{
		if (this.method_2(gclass4_0.IPlugin_0.Name) == null)
		{
			base.List.Add(gclass4_0);
		}
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002F40 File Offset: 0x00001140
	public void method_1(GClass4 gclass4_0)
	{
		base.List.Remove(gclass4_0);
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000E214 File Offset: 0x0000C414
	public GClass4 method_2(string string_0)
	{
		GClass4 result = null;
		foreach (object obj in base.List)
		{
			GClass4 gclass = (GClass4)obj;
			if (gclass.IPlugin_0.Name.Equals(string_0) || gclass.String_0.Equals(string_0))
			{
				result = gclass;
				break;
			}
		}
		return result;
	}
}
