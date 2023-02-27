using System;

// Token: 0x0200002C RID: 44
internal static class Class15
{
	// Token: 0x0600011A RID: 282 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
	public static byte[] smethod_0(int int_0)
	{
		return new byte[]
		{
			(byte)(int_0 >> 8),
			(byte)int_0
		};
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000E7CC File Offset: 0x0000C9CC
	public static byte[] smethod_1(int int_0)
	{
		return new byte[]
		{
			(byte)(int_0 >> 24),
			(byte)(int_0 >> 16),
			(byte)(int_0 >> 8),
			(byte)int_0
		};
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000E800 File Offset: 0x0000CA00
	public static int smethod_2(byte[] byte_0)
	{
		int result;
		if ((byte_0[0] | byte_0[1] | byte_0[2] | byte_0[3]) < 0)
		{
			result = -1;
		}
		else
		{
			result = ((int)byte_0[0] << 24) + ((int)byte_0[1] << 16) + ((int)byte_0[2] << 8) + (int)byte_0[3];
		}
		return result;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0000E844 File Offset: 0x0000CA44
	public static int smethod_3(byte[] byte_0)
	{
		int result;
		if ((byte_0[0] | byte_0[1]) < 0)
		{
			result = -1;
		}
		else
		{
			result = ((int)byte_0[0] << 8) + (int)byte_0[1];
		}
		return result;
	}
}
