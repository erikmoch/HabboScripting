using System;

// Token: 0x0200001A RID: 26
internal class Class2
{
	// Token: 0x060000CC RID: 204 RVA: 0x0000D44C File Offset: 0x0000B64C
	public static void smethod_0(ref byte[] byte_1)
	{
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = Class2.byte_0[i % Class2.byte_0.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + (int)array[i] + (int)array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		int num2 = 0;
		num = 0;
		i = num2;
		for (int j = 0; j < byte_1.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + (int)array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num3 = (int)(array[i] + array[num]) % 256;
			byte[] array3 = byte_1;
			int num4 = j;
			array3[num4] ^= array[num3];
		}
	}

	// Token: 0x040000C6 RID: 198
	private static byte[] byte_0 = new byte[]
	{
		247,
		95,
		95,
		136,
		70,
		200,
		148,
		76,
		229,
		92,
		131,
		20,
		11,
		114,
		94,
		6,
		182,
		92,
		46,
		79,
		182,
		14,
		206,
		7,
		96,
		135,
		56,
		33,
		121,
		165,
		252,
		145,
		110,
		187,
		16,
		64,
		196,
		214,
		223,
		48,
		107,
		86,
		177,
		185,
		53,
		99,
		216,
		82,
		194,
		154,
		104,
		50,
		201,
		116,
		23,
		75,
		16,
		158,
		100,
		235,
		177,
		97,
		209,
		136,
		87,
		203,
		56,
		214,
		236,
		208,
		149,
		144,
		186,
		133,
		15,
		35,
		139,
		187,
		20,
		165,
		232,
		200,
		215,
		62,
		223,
		39,
		105,
		104,
		69,
		136,
		212,
		148,
		110,
		87,
		184,
		193,
		109,
		26,
		131,
		110
	};
}
