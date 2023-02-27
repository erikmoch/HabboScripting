using System;
using System.IO;
using System.Text;
using System.Threading;

// Token: 0x0200001C RID: 28
internal class Class4
{
	// Token: 0x060000D2 RID: 210 RVA: 0x0000D658 File Offset: 0x0000B858
	public Class4(string path)
	{
		this.string_0 = path;
		if (File.Exists(path))
		{
			Thread.Sleep(200);
			File.Delete(path);
		}
		File.Create(path).Close();
		this.binaryWriter_0 = new BinaryWriter(new StreamWriter(path).BaseStream);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
	public void method_0(string string_1)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt16(string_1.Length));
		this.binaryWriter_0.Write(bytes);
		bytes = Encoding.Default.GetBytes(string_1);
		this.binaryWriter_0.Write(bytes);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
	public void method_1(int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		this.binaryWriter_0.Write(bytes);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000D714 File Offset: 0x0000B914
	public void method_2()
	{
		this.binaryWriter_0.Close();
		StreamReader streamReader = new StreamReader(this.string_0);
		byte[] bytes = Encoding.Default.GetBytes(streamReader.ReadToEnd());
		streamReader.Close();
		Class2.smethod_0(ref bytes);
		BinaryWriter binaryWriter = new BinaryWriter(new StreamWriter(this.string_0).BaseStream);
		binaryWriter.Write(bytes);
		binaryWriter.Close();
	}

	// Token: 0x040000C9 RID: 201
	private BinaryWriter binaryWriter_0;

	// Token: 0x040000CA RID: 202
	private string string_0;
}
