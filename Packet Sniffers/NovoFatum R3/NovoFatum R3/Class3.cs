using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

// Token: 0x0200001B RID: 27
internal class Class3
{
	// Token: 0x060000CF RID: 207 RVA: 0x0000D53C File Offset: 0x0000B73C
	public Class3(string path)
	{
		BinaryReader binaryReader = new BinaryReader(new StreamReader(path).BaseStream);
		List<byte> list = new List<byte>();
		byte item = binaryReader.ReadByte();
		for (;;)
		{
			try
			{
				list.Add(item);
				item = binaryReader.ReadByte();
			}
			catch
			{
				break;
			}
		}
		this.byte_0 = list.ToArray();
		binaryReader.Close();
		Class2.smethod_0(ref this.byte_0);
		Debug.WriteLine(Encoding.Default.GetString(this.byte_0));
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
	public int method_0()
	{
		int result = BitConverter.ToInt32(this.byte_0, this.int_0);
		this.int_0 += 4;
		return result;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000D600 File Offset: 0x0000B800
	public string method_1()
	{
		short num = BitConverter.ToInt16(this.byte_0, this.int_0);
		this.int_0 += 2;
		string @string = Encoding.Default.GetString(this.byte_0, this.int_0, (int)num);
		this.int_0 += (int)num;
		return @string;
	}

	// Token: 0x040000C7 RID: 199
	private byte[] byte_0;

	// Token: 0x040000C8 RID: 200
	private int int_0 = 0;
}
