using System;
using System.Collections.Generic;
using System.Text;

// Token: 0x0200002B RID: 43
internal class Class14
{
	// Token: 0x06000111 RID: 273 RVA: 0x00002FC7 File Offset: 0x000011C7
	public Class14(int Header)
	{
		this.method_0(Header);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000E650 File Offset: 0x0000C850
	public Class14(byte[] data)
	{
		foreach (byte item in data)
		{
			this.list_0.Add(item);
		}
		this.bool_0 = true;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
	public void method_0(int int_0)
	{
		short value = (short)int_0;
		this.method_4(BitConverter.GetBytes(value), true);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00002FE8 File Offset: 0x000011E8
	public void method_1(int int_0)
	{
		this.method_4(BitConverter.GetBytes(int_0), true);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
	public void method_2(bool bool_1)
	{
		this.method_4(new byte[]
		{
			bool_1 ? 1 : 0
		}, false);
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002FF7 File Offset: 0x000011F7
	public void method_3(string string_0)
	{
		this.method_0(string_0.Length);
		this.method_4(Encoding.ASCII.GetBytes(string_0), false);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
	public void method_4(byte[] byte_0, bool bool_1)
	{
		if (bool_1)
		{
			for (int i = byte_0.Length - 1; i > -1; i--)
			{
				this.list_0.Add(byte_0[i]);
			}
		}
		else
		{
			this.list_0.AddRange(byte_0);
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000E72C File Offset: 0x0000C92C
	public byte[] method_5()
	{
		byte[] result;
		if (this.bool_0)
		{
			result = this.list_0.ToArray();
		}
		else
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(this.list_0.Count));
			list.Reverse();
			list.AddRange(this.list_0);
			result = list.ToArray();
		}
		return result;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0000E788 File Offset: 0x0000C988
	public override string ToString()
	{
		return Encoding.Default.GetString(this.method_5());
	}

	// Token: 0x040000E6 RID: 230
	private List<byte> list_0 = new List<byte>();

	// Token: 0x040000E7 RID: 231
	private bool bool_0 = false;
}
