using System;
using System.Text;

// Token: 0x0200002A RID: 42
internal class Class13
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000109 RID: 265 RVA: 0x0000E460 File Offset: 0x0000C660
	public int Int32_0
	{
		get
		{
			return Class15.smethod_2(new byte[]
			{
				this.byte_0[0],
				this.byte_0[1],
				this.byte_0[2],
				this.byte_0[3]
			});
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600010A RID: 266 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
	public int Int32_1
	{
		get
		{
			return Class15.smethod_3(new byte[]
			{
				this.byte_0[4],
				this.byte_0[5]
			});
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600010B RID: 267 RVA: 0x0000E4DC File Offset: 0x0000C6DC
	private byte[] Byte_0
	{
		get
		{
			return Class20.smethod_0(this.byte_0, 6, this.byte_0.Length - 6);
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002FA5 File Offset: 0x000011A5
	public Class13(byte[] fromMessage)
	{
		this.byte_0 = fromMessage;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000E504 File Offset: 0x0000C704
	public string method_0()
	{
		int num = Class15.smethod_3(new byte[]
		{
			this.Byte_0[this.int_0++],
			this.Byte_0[this.int_0++]
		});
		byte[] bytes = Class20.smethod_0(this.Byte_0, this.int_0, num);
		this.int_0 += num;
		return Encoding.Default.GetString(bytes);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0000E588 File Offset: 0x0000C788
	public int method_1()
	{
		return Class15.smethod_2(new byte[]
		{
			this.Byte_0[this.int_0++],
			this.Byte_0[this.int_0++],
			this.Byte_0[this.int_0++],
			this.Byte_0[this.int_0++]
		});
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0000E610 File Offset: 0x0000C810
	public bool method_2()
	{
		return this.Byte_0[this.int_0++] == 1;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000E638 File Offset: 0x0000C838
	public byte[] method_3()
	{
		return this.byte_0;
	}

	// Token: 0x040000E4 RID: 228
	private byte[] byte_0 = new byte[0];

	// Token: 0x040000E5 RID: 229
	private int int_0 = 0;
}
