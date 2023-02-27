using System;
using System.IO;

// Token: 0x02000038 RID: 56
internal class Class27
{
	// Token: 0x0600019C RID: 412 RVA: 0x000032A4 File Offset: 0x000014A4
	public void method_0(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x000139A8 File Offset: 0x00011BA8
	public Class27()
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
			this.string_2 = array[text.Split(new char[]
			{
				'\u0019'
			}).Length - 1];
		}
		catch
		{
			this.string_2 = "## NOT FOUND ##";
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600019E RID: 414 RVA: 0x000032AD File Offset: 0x000014AD
	public bool Boolean_0
	{
		get
		{
			return this.string_3.Contains("connection.info.host");
		}
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00013A5C File Offset: 0x00011C5C
	private string method_1(string string_4, int int_0, int int_1)
	{
		if (int_0 < 0)
		{
			int_0 = string_4.Length + int_0;
		}
		return string_4.Substring(int_0, int_1);
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00013A88 File Offset: 0x00011C88
	public object method_2(string string_4)
	{
		string text = this.string_3.Substring(this.string_3.IndexOf("\"" + string_4 + "\" : \"") + ("\"" + string_4 + "\" : \"").Length);
		text = text.Split(new char[]
		{
			'"'
		})[0];
		object result;
		if (string_4 == "connection.info.port")
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

	// Token: 0x060001A1 RID: 417 RVA: 0x00013B24 File Offset: 0x00011D24
	public string method_3(string string_4)
	{
		string text = this.string_3.Substring(this.string_3.IndexOf("var " + string_4 + " = \"") + ("var " + string_4 + " = \"").Length);
		return text.Split(new char[]
		{
			'"'
		})[0];
	}

	// Token: 0x04000112 RID: 274
	public const string string_0 = "connection.info.host";

	// Token: 0x04000113 RID: 275
	public const string string_1 = "connection.info.port";

	// Token: 0x04000114 RID: 276
	public string string_2 = "";

	// Token: 0x04000115 RID: 277
	public string string_3;
}
