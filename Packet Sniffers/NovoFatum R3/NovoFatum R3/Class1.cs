using System;
using System.Diagnostics;
using System.IO;

// Token: 0x02000018 RID: 24
internal class Class1
{
	// Token: 0x060000B8 RID: 184 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
	public static void smethod_0()
	{
		if (!Directory.Exists(Environment.CurrentDirectory + "\\data"))
		{
			Directory.CreateDirectory(Environment.CurrentDirectory + "\\data");
		}
		if (File.Exists("unloadHelper"))
		{
			Class3 @class = new Class3("unloadHelper");
			int i = @class.method_0();
			int num = 0;
			while (i > num)
			{
				string path = Environment.CurrentDirectory + "\\data\\plugins\\" + @class.method_1();
				File.Delete(path);
				num++;
			}
			File.Delete("unloadHelper");
		}
		Class1.class11_0 = new Class11();
		Class1.class7_0 = new Class7();
		Class9.smethod_0();
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000C958 File Offset: 0x0000AB58
	public static void smethod_1()
	{
		if (Class1.class18_0 != null)
		{
			Class1.class18_0.method_0();
		}
		if (Class12.bool_0)
		{
			Class12.smethod_1();
		}
		Class4 @class = new Class4("unloadHelper");
		@class.method_1(Class1.class11_0.list_0.Count);
		foreach (string text in Class1.class11_0.list_0)
		{
			@class.method_0(text);
		}
		@class.method_2();
		Environment.Exit(0);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000CA00 File Offset: 0x0000AC00
	public static void smethod_2()
	{
		if (Class1.class18_0 != null)
		{
			Class1.class18_0.method_0();
		}
		if (Class12.bool_0)
		{
			Class12.smethod_1();
		}
		if (Class6.string_0 != "")
		{
			Class6.string_0 = "";
		}
		if (Class24.string_1 != "")
		{
			short short_ = 0;
			Class17.short_0 = 0;
			Class17.short_1 = short_;
			bool flag = true;
			Class17.bool_1 = true;
			Class17.bool_0 = flag;
			Class24.smethod_0();
		}
		Class0.main_0.method_2();
		Class1.bool_4 = false;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000CA90 File Offset: 0x0000AC90
	public static void smethod_3(string string_12)
	{
		new Process
		{
			StartInfo = 
			{
				UseShellExecute = true,
				FileName = string_12
			}
		}.Start();
	}

	// Token: 0x040000A1 RID: 161
	public static string string_0 = "";

	// Token: 0x040000A2 RID: 162
	public static string string_1 = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.97 Safari/537.11";

	// Token: 0x040000A3 RID: 163
	public static AppDomain appDomain_0 = AppDomain.CurrentDomain;

	// Token: 0x040000A4 RID: 164
	public static Class18 class18_0;

	// Token: 0x040000A5 RID: 165
	public static bool bool_0 = false;

	// Token: 0x040000A6 RID: 166
	public static bool bool_1 = false;

	// Token: 0x040000A7 RID: 167
	public static bool bool_2 = false;

	// Token: 0x040000A8 RID: 168
	public static bool bool_3 = false;

	// Token: 0x040000A9 RID: 169
	public static string string_2 = "";

	// Token: 0x040000AA RID: 170
	public static string string_3 = "";

	// Token: 0x040000AB RID: 171
	public static string string_4 = "";

	// Token: 0x040000AC RID: 172
	public static int int_0 = -1;

	// Token: 0x040000AD RID: 173
	public static Class21 class21_0;

	// Token: 0x040000AE RID: 174
	public static Class19 class19_0;

	// Token: 0x040000AF RID: 175
	public static bool bool_4 = false;

	// Token: 0x040000B0 RID: 176
	public static string string_5 = "";

	// Token: 0x040000B1 RID: 177
	public static string string_6 = "";

	// Token: 0x040000B2 RID: 178
	public static string string_7 = "";

	// Token: 0x040000B3 RID: 179
	public static int int_1 = -1;

	// Token: 0x040000B4 RID: 180
	public static string string_8 = "";

	// Token: 0x040000B5 RID: 181
	public static string string_9 = "";

	// Token: 0x040000B6 RID: 182
	public static string string_10 = "";

	// Token: 0x040000B7 RID: 183
	public static string string_11 = "";

	// Token: 0x040000B8 RID: 184
	public static Class5 class5_0;

	// Token: 0x040000B9 RID: 185
	public static Class7 class7_0;

	// Token: 0x040000BA RID: 186
	public static Class11 class11_0;
}
