using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x0200001F RID: 31
internal class Class7
{
	// Token: 0x060000DF RID: 223 RVA: 0x00002E71 File Offset: 0x00001071
	public Class7()
	{
		this.dictionary_0 = new Dictionary<int, Class8>();
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000D944 File Offset: 0x0000BB44
	public int method_0(Class8 class8_0)
	{
		int result;
		lock (this.dictionary_0)
		{
			class8_0.bool_1 = true;
			Thread thread = new Thread(new ThreadStart(class8_0.method_0));
			thread.Start();
			int num = this.int_0++;
			this.dictionary_0.Add(num, class8_0);
			result = num;
		}
		return result;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
	public void method_1(int int_1)
	{
		lock (this.dictionary_0)
		{
			this.dictionary_0[int_1].bool_1 = false;
			this.dictionary_0.Remove(int_1);
		}
	}

	// Token: 0x040000CE RID: 206
	public Dictionary<int, Class8> dictionary_0;

	// Token: 0x040000CF RID: 207
	private int int_0 = 0;
}
