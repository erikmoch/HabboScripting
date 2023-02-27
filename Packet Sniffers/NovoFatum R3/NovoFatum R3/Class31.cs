using System;
using System.Security.Cryptography;

// Token: 0x0200003C RID: 60
internal class Class31
{
	// Token: 0x060001AC RID: 428 RVA: 0x00014320 File Offset: 0x00012520
	public uint method_0()
	{
		byte[] array = new byte[4];
		Class31.rngcryptoServiceProvider_0.GetBytes(array);
		return BitConverter.ToUInt32(array, 0);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00014348 File Offset: 0x00012548
	public int method_1()
	{
		byte[] array = new byte[4];
		Class31.rngcryptoServiceProvider_0.GetBytes(array);
		return BitConverter.ToInt32(array, 0);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00014370 File Offset: 0x00012570
	public float method_2()
	{
		float num = this.method_0();
		float num2 = 4.2949673E+09f;
		return num / num2;
	}

	// Token: 0x04000138 RID: 312
	private static RNGCryptoServiceProvider rngcryptoServiceProvider_0 = new RNGCryptoServiceProvider();
}
