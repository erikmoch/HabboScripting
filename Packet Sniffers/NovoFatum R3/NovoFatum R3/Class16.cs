using System;
using System.Text;

// Token: 0x0200002D RID: 45
internal static class Class16
{
	// Token: 0x0600011E RID: 286 RVA: 0x0000E870 File Offset: 0x0000CA70
	public static string smethod_0(byte[] byte_0)
	{
		return Class16.smethod_1(Encoding.Default.GetString(byte_0));
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0000E890 File Offset: 0x0000CA90
	public static string smethod_1(string string_0)
	{
		for (int i = 0; i < 13; i++)
		{
			string_0 = string_0.Replace(string.Concat(Convert.ToChar(i)), "[" + i + "]");
		}
		return string_0;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
	public static string smethod_2(string string_0)
	{
		for (int i = 0; i < 13; i++)
		{
			string_0 = string_0.Replace("[" + i + "]", string.Concat(Convert.ToChar(i)));
		}
		return string_0;
	}
}
