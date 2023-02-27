using System;
using System.Globalization;

// Token: 0x02000037 RID: 55
internal class Class26
{
	// Token: 0x06000195 RID: 405 RVA: 0x00013754 File Offset: 0x00011954
	public static int smethod_0(string string_0)
	{
		int num = 0;
		foreach (char char_ in string_0)
		{
			if (Class26.smethod_5(char_))
			{
				num++;
			}
		}
		if (num % 2 != 0)
		{
			num--;
		}
		return num / 2;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000137A0 File Offset: 0x000119A0
	public static byte[] smethod_1(string string_0)
	{
		string text = "";
		foreach (char c in string_0)
		{
			if (Class26.smethod_5(c))
			{
				text += c;
			}
		}
		if (text.Length % 2 != 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		int num = text.Length / 2;
		byte[] array = new byte[num];
		int num2 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			string string_ = new string(new char[]
			{
				text[num2],
				text[num2 + 1]
			});
			array[i] = Class26.smethod_6(string_);
			num2 += 2;
		}
		return array;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0001386C File Offset: 0x00011A6C
	private static int smethod_2(char char_0, int int_0)
	{
		return int.Parse(char_0.ToString(), NumberStyles.HexNumber);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0001388C File Offset: 0x00011A8C
	public static string smethod_3(byte[] byte_0)
	{
		string text = "";
		for (int i = 0; i < byte_0.Length; i++)
		{
			text += byte_0[i].ToString("X2");
		}
		return text;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x000138CC File Offset: 0x00011ACC
	public static bool smethod_4(string string_0)
	{
		bool result = true;
		foreach (char char_ in string_0)
		{
			if (!Class26.smethod_5(char_))
			{
				result = false;
				return result;
			}
		}
		return result;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00013908 File Offset: 0x00011B08
	public static bool smethod_5(char char_0)
	{
		int num = Convert.ToInt32('A');
		int num2 = Convert.ToInt32('0');
		char_0 = char.ToUpper(char_0);
		int num3 = Convert.ToInt32(char_0);
		return (num3 >= num && num3 < num + 6) || (num3 >= num2 && num3 < num2 + 10);
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00013968 File Offset: 0x00011B68
	private static byte smethod_6(string string_0)
	{
		if (string_0.Length > 2 || string_0.Length <= 0)
		{
			throw new ArgumentException("hex must be 1 or 2 characters in length");
		}
		return byte.Parse(string_0, NumberStyles.HexNumber);
	}
}
