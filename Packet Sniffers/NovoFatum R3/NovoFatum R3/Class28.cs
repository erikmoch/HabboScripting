using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

// Token: 0x02000039 RID: 57
internal class Class28
{
	// Token: 0x060001A2 RID: 418 RVA: 0x00013B90 File Offset: 0x00011D90
	public static void smethod_0(int int_1, byte[] byte_2)
	{
		if (Class0.packetlogger_0 != null && !Class1.bool_0)
		{
			if (Class28.byte_0 != null)
			{
				byte[] array = new byte[Class28.byte_0.Length + byte_2.Length];
				int num = 0;
				foreach (byte b in Class28.byte_0)
				{
					array[num++] = b;
				}
				foreach (byte b in byte_2)
				{
					array[num++] = b;
				}
				byte_2 = array;
				Class28.byte_0 = null;
			}
			while (byte_2.Length >= 6)
			{
				int num2 = Class15.smethod_2(byte_2);
				if (num2 > byte_2.Length)
				{
					Class28.byte_0 = byte_2;
					break;
				}
				byte[] fromMessage = Class20.smethod_0(byte_2, 0, num2 + 4);
				Class13 @class = new Class13(fromMessage);
				Class0.packetlogger_0.method_1(@class.Int32_1, Class16.smethod_0(fromMessage));
				byte_2 = Class20.smethod_0(byte_2, 4, byte_2.Length - 4);
				byte_2 = Class20.smethod_0(byte_2, num2, byte_2.Length - num2);
			}
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00013CA4 File Offset: 0x00011EA4
	private static int smethod_1(string string_0)
	{
		foreach (string text in Class28.dictionary_3.Keys)
		{
			if (string_0.Contains(text))
			{
				return Class28.dictionary_3[text];
			}
		}
		return -1;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00013D14 File Offset: 0x00011F14
	public static void smethod_2(int int_1, byte[] byte_2)
	{
		if (Class0.packetlogger_0 != null && !Class1.bool_1)
		{
			if (Class28.byte_1 != null)
			{
				byte[] array = new byte[Class28.byte_1.Length + byte_2.Length];
				int num = 0;
				foreach (byte b in Class28.byte_1)
				{
					array[num++] = b;
				}
				foreach (byte b in byte_2)
				{
					array[num++] = b;
				}
				byte_2 = array;
				Class28.byte_1 = null;
			}
			while (byte_2.Length >= 6)
			{
				int num2 = Class15.smethod_2(byte_2);
				if (num2 > byte_2.Length)
				{
					Class28.byte_1 = byte_2;
					break;
				}
				byte[] array3 = Class20.smethod_0(byte_2, 0, num2 + 4);
				int int_2 = Class15.smethod_3(new byte[]
				{
					array3[4],
					array3[5]
				});
				Class0.packetlogger_0.method_0(int_2, Class16.smethod_0(array3));
				byte_2 = Class20.smethod_0(byte_2, 4, byte_2.Length - 4);
				byte_2 = Class20.smethod_0(byte_2, num2, byte_2.Length - num2);
			}
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000032BF File Offset: 0x000014BF
	public static void smethod_3(string string_0)
	{
		if (Class0.packetlogger_0 != null && !Class1.bool_1)
		{
			Class0.packetlogger_0.method_0(0, string_0);
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000032E4 File Offset: 0x000014E4
	public static void smethod_4(string string_0)
	{
		if (Class0.packetlogger_0 != null && !Class1.bool_0)
		{
			Class0.packetlogger_0.method_1(0, string_0);
		}
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00013E3C File Offset: 0x0001203C
	private static void smethod_5()
	{
		foreach (Class29 @class in Class28.dictionary_0.Values)
		{
			Thread.Sleep(600);
			Class14 class2 = new Class14(311);
			class2.method_1(@class.int_5);
			class2.method_1(-1);
			Class1.class19_0.method_8(class2.method_5());
		}
		foreach (Class29 @class in Class28.dictionary_0.Values)
		{
			Class28.stringBuilder_0.Append(string.Concat(new object[]
			{
				"INSERT INTO `latinemu`.`catalog_pages` (`id`, `parentid`, `minrank`, `caption`, `caption_code`, `color_id`, `icon_id`, `layout`, `headline1`, `teaser1`, `special`, `text1`, `text2`, `text3`) VALUES (",
				@class.int_0,
				", '",
				@class.int_1,
				"', '1', '",
				@class.string_0.Replace("'", "\\'"),
				"', '",
				@class.string_1.Replace("'", "\\'"),
				"', '",
				@class.int_2,
				"', '",
				@class.int_3,
				"', '",
				@class.string_2,
				"', '",
				@class.string_3.Replace("'", "\\'"),
				"', '",
				@class.string_4.Replace("'", "\\'"),
				"', '",
				@class.string_5.Replace("'", "\\'"),
				"', '",
				@class.string_6.Replace("'", "\\'"),
				"', '",
				@class.string_7.Replace("'", "\\'"),
				"', '",
				@class.string_8.Replace("'", "\\'"),
				"');"
			}));
		}
		foreach (Class30 class3 in Class28.dictionary_1.Values)
		{
			Class28.stringBuilder_0.Append(string.Concat(new object[]
			{
				"INSERT INTO `latinemu`.`catalog_items` (`id`, `pageId`, `furniId`, `amount`, `cost_credits`, `cost_point`, `caption`, `parentId`, `insideBox`) VALUES (",
				class3.int_0,
				", '",
				class3.int_1,
				"', '",
				class3.int_4,
				"', '",
				class3.int_5,
				"', '",
				class3.int_2,
				"', '",
				class3.int_3,
				"', '",
				class3.string_0.Replace("'", "\\'"),
				"', '",
				class3.int_6,
				"', '",
				class3.bool_0 ? 1 : 0,
				"');"
			}));
		}
		StreamWriter streamWriter = new StreamWriter("catalog.sql");
		streamWriter.WriteLine(Class28.stringBuilder_0.ToString());
		streamWriter.Close();
		Debug.WriteLine("Finished!");
	}

	// Token: 0x04000116 RID: 278
	private static Dictionary<int, Class29> dictionary_0 = new Dictionary<int, Class29>();

	// Token: 0x04000117 RID: 279
	private static Dictionary<int, Class30> dictionary_1 = new Dictionary<int, Class30>();

	// Token: 0x04000118 RID: 280
	private static Dictionary<int, int> dictionary_2 = new Dictionary<int, int>();

	// Token: 0x04000119 RID: 281
	private static Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	// Token: 0x0400011A RID: 282
	private static StringBuilder stringBuilder_0 = new StringBuilder();

	// Token: 0x0400011B RID: 283
	private static int int_0 = 1;

	// Token: 0x0400011C RID: 284
	private static byte[] byte_0 = null;

	// Token: 0x0400011D RID: 285
	private static byte[] byte_1 = null;
}
