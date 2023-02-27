using System;

// Token: 0x02000036 RID: 54
internal class Class25
{
	// Token: 0x06000190 RID: 400 RVA: 0x000135B0 File Offset: 0x000117B0
	public void method_0(byte[] byte_0)
	{
		int num = byte_0.Length;
		this.int_0 = 0;
		while (this.int_0 < 256)
		{
			this.int_2[this.int_0] = this.int_0;
			this.int_0++;
		}
		this.int_1 = 0;
		this.int_0 = 0;
		while (this.int_0 < 256)
		{
			this.int_1 = (this.int_1 + this.int_2[this.int_0] + (int)byte_0[this.int_0 % num]) % 256;
			this.method_2(this.int_0, this.int_1);
			this.int_0++;
		}
		this.int_0 = 0;
		this.int_1 = 0;
		this.bool_0 = true;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0001367C File Offset: 0x0001187C
	public void method_1(byte[] byte_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			this.int_0 = ++this.int_0 % 256;
			this.int_1 = (this.int_1 + this.int_2[this.int_0]) % 256;
			this.method_2(this.int_0, this.int_1);
			byte_0[i] = (byte)((int)(byte_0[i] & byte.MaxValue) ^ this.int_2[(this.int_2[this.int_0] + this.int_2[this.int_1]) % 256]);
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00013724 File Offset: 0x00011924
	private void method_2(int int_3, int int_4)
	{
		int num = this.int_2[int_3];
		this.int_2[int_3] = this.int_2[int_4];
		this.int_2[int_4] = num;
	}

	// Token: 0x0400010E RID: 270
	private int int_0 = 0;

	// Token: 0x0400010F RID: 271
	private int int_1 = 0;

	// Token: 0x04000110 RID: 272
	private int[] int_2 = new int[256];

	// Token: 0x04000111 RID: 273
	public bool bool_0 = false;
}
