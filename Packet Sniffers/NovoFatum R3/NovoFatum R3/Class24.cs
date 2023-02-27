using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using RSAKeyGenerator;

// Token: 0x02000035 RID: 53
internal static class Class24
{
	// Token: 0x06000185 RID: 389 RVA: 0x00003251 File Offset: 0x00001451
	public static void smethod_0()
	{
		Class24.class23_0 = null;
		Class24.class23_1 = null;
		Class24.class23_2 = null;
		Class24.class23_3 = null;
		Class24.class25_0 = null;
		Class24.class25_1 = null;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00012F34 File Offset: 0x00011134
	public static void smethod_1(string string_2)
	{
		RSAKey.init("(zB0F6]1(6RCw70lGQY7hA`uORr=5eE8AT<Dsa%@2>{ImO1Cs~3vi\"7&'oQ=j,H");
		Class24.string_0 = RSAKey.GetKeys(Class1.string_3);
		if (Class1.string_10 == "" && Class1.string_11 == "")
		{
			Class24.class23_4 = new Class23(Class24.string_0[0], 16);
			Class24.class23_5 = new Class23(Class24.string_0[1], 16);
		}
		else
		{
			Class24.class23_4 = new Class23(Class1.string_10, 16);
			Class24.class23_5 = new Class23(Class1.string_11, 16);
		}
		Class24.int_0 = Class24.smethod_7();
		Class24.string_1 = string_2;
		string text = Class6.smethod_3("url.prefix", false) + "/gamedata/supersecret?token=";
		if (Class1.string_9 != "")
		{
			text = Class1.string_9;
		}
		WebRequest webRequest = WebRequest.Create(text + string_2);
		webRequest.Headers[25] = Class1.string_0;
		((HttpWebRequest)webRequest).UserAgent = Class1.string_1;
		WebResponse response = webRequest.GetResponse();
		Image original = Image.FromStream(response.GetResponseStream());
		Bitmap bitmap = new Bitmap(original);
		int width = bitmap.Width;
		int height = bitmap.Height;
		Debug.WriteLine(text);
		int num = 0;
		byte[] array = new byte[width * height * 4];
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				int num2 = bitmap.GetPixel(j, i).ToArgb();
				array[num++] = (byte)(num2 >> 24 & 255);
				array[num++] = (byte)(num2 >> 16 & 255);
				array[num++] = (byte)(num2 >> 8 & 255);
				array[num++] = (byte)(num2 & 255);
			}
		}
		string text2 = Class24.smethod_6(Class24.smethod_5(array), string_2);
		int num3 = (int)text2[0];
		text2 = text2.Substring(1);
		string value = text2.Substring(0, num3);
		text2 = text2.Substring(num3);
		int length = (int)text2[0];
		text2 = text2.Substring(1);
		string value2 = text2.Substring(0, length);
		Class24.class23_0 = new Class23(value, 10);
		Class24.class23_1 = new Class23(value2, 10);
		Class24.smethod_4();
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00013190 File Offset: 0x00011390
	public static void smethod_2(string string_2)
	{
		try
		{
			Class24.class25_0 = new Class25();
			Class23 @class = new Class23(string_2, 10);
			string text = @class.method_5(Class24.class23_2, Class24.class23_0).method_3(16).ToLower();
			Class24.class25_0.method_0(Class26.smethod_1(text));
			while (!Class24.class25_0.bool_0)
			{
			}
		}
		catch
		{
			AlertError alertError = new AlertError();
			alertError.method_0("Exploit error", "Try again! Failure exploiting!");
			alertError.ShowDialog();
		}
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00013220 File Offset: 0x00011420
	private static string smethod_3(string string_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = string_2.Split(new char[]
		{
			' '
		});
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Substring(0, 1);
			string str = array[i].Substring(1);
			stringBuilder.Append(text.ToUpper() + str + " ");
		}
		return stringBuilder.ToString().Remove(stringBuilder.Length - 1);
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000132A0 File Offset: 0x000114A0
	private static void smethod_4()
	{
		Class24.class23_2 = new Class23(Class24.smethod_10(), 16);
		Debug.WriteLine(Class24.class23_0);
		Debug.WriteLine(Class24.class23_1);
		Class23 @class = Class24.class23_1.method_5(Class24.class23_2, Class24.class23_0);
		Class23 class2 = new Class23(Class24.smethod_8(Encoding.Default.GetBytes(@class.method_3(10)), Class24.int_0));
		Class24.class23_3 = class2.method_5(Class24.class23_5, Class24.class23_4);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00013320 File Offset: 0x00011520
	private static string smethod_5(byte[] byte_0)
	{
		string text = "";
		int num = 0;
		int num2 = 0;
		for (int i = 39; i < 69; i++)
		{
			int num3 = 0;
			for (int j = 4; j < 84; j++)
			{
				int num4 = ((i + num3) * 100 + j) * 4;
				for (int k = 1; k < 4; k++)
				{
					num2 |= (int)(byte_0[num4 + k] & 1) << 7 - num;
					if (num == 7)
					{
						text += (char)num2;
						num2 = 0;
						num = 0;
					}
					else
					{
						num++;
					}
				}
				if (j % 2 == 0)
				{
					num3++;
				}
			}
		}
		return text;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x000133D0 File Offset: 0x000115D0
	private static string smethod_6(string string_2, string string_3)
	{
		string text = "";
		int num = 0;
		for (int i = 0; i < string_2.Length; i++)
		{
			text += (string_2[i] ^ string_3[num]);
			if (++num == string_3.Length)
			{
				num = 0;
			}
		}
		return text;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0001342C File Offset: 0x0001162C
	public static int smethod_7()
	{
		return (Class24.class23_4.method_9() + 7) / 8;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0001344C File Offset: 0x0001164C
	private static byte[] smethod_8(byte[] byte_0, int int_1)
	{
		byte[] array = new byte[int_1];
		int num = byte_0.Length - 1;
		while (num >= 0 && int_1 > 11)
		{
			array[--int_1] = byte_0[num--];
		}
		array[--int_1] = 0;
		while (int_1 > 2)
		{
			array[--int_1] = 1;
		}
		array[--int_1] = 2;
		array[--int_1] = 0;
		return array;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x000134C4 File Offset: 0x000116C4
	private static string smethod_9(int int_1)
	{
		string text = "";
		Random random = new Random();
		for (int i = 0; i < int_1; i++)
		{
			int value = 1 + (int)(random.NextDouble() * 254.0);
			text += Convert.ToString(value, 16);
		}
		return text;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00013514 File Offset: 0x00011714
	private static string smethod_10()
	{
		int i = 10;
		string text = null;
		string text2 = null;
		string text3 = null;
		while (i > 0)
		{
			text = Class24.smethod_9(34);
			Class23 @class = new Class23(text, 16);
			string text4 = Class24.class23_1.method_5(@class, Class24.class23_0).ToString();
			if (text4.Length >= 64)
			{
				text3 = text;
				IL_75:
				string result;
				if (text != text3)
				{
					result = text3;
				}
				else
				{
					result = text;
				}
				return result;
			}
			if (text2 == null || text4.Length > text2.Length)
			{
				text2 = text4;
				text3 = text;
			}
			i--;
		}
		goto IL_75;
	}

	// Token: 0x04000103 RID: 259
	private static Class23 class23_0;

	// Token: 0x04000104 RID: 260
	private static Class23 class23_1;

	// Token: 0x04000105 RID: 261
	private static Class23 class23_2;

	// Token: 0x04000106 RID: 262
	public static Class23 class23_3;

	// Token: 0x04000107 RID: 263
	public static Class25 class25_0;

	// Token: 0x04000108 RID: 264
	public static Class25 class25_1;

	// Token: 0x04000109 RID: 265
	public static string[] string_0;

	// Token: 0x0400010A RID: 266
	public static string string_1;

	// Token: 0x0400010B RID: 267
	private static Class23 class23_4;

	// Token: 0x0400010C RID: 268
	private static Class23 class23_5;

	// Token: 0x0400010D RID: 269
	private static int int_0;
}
