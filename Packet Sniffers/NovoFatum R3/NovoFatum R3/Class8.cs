using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000020 RID: 32
internal class Class8
{
	// Token: 0x060000E2 RID: 226 RVA: 0x0000DA24 File Offset: 0x0000BC24
	public void method_0()
	{
		while (this.bool_1)
		{
			List<byte> list = new List<byte>();
			if (this.bool_0)
			{
				list.AddRange(this.byte_0);
				Class1.class19_0.method_8(list.ToArray());
				list.Clear();
			}
			else
			{
				Class1.class19_0.method_7(this.byte_0);
			}
			Thread.Sleep(this.int_0);
		}
	}

	// Token: 0x040000D0 RID: 208
	public string string_0;

	// Token: 0x040000D1 RID: 209
	public byte[] byte_0;

	// Token: 0x040000D2 RID: 210
	public bool bool_0 = false;

	// Token: 0x040000D3 RID: 211
	public int int_0;

	// Token: 0x040000D4 RID: 212
	public bool bool_1 = false;
}
