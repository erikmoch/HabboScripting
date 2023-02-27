using System;
using System.Diagnostics;
using System.IO;
using System.Net;

// Token: 0x0200002F RID: 47
internal class Class18
{
	// Token: 0x06000124 RID: 292 RVA: 0x0000EB70 File Offset: 0x0000CD70
	public Class18(string gameHost, int port)
	{
		if (File.Exists(this.string_1))
		{
			this.bool_0 = true;
			this.method_0();
			this.bool_0 = false;
		}
		string[] array = gameHost.Split(new char[]
		{
			'.'
		});
		if (Class1.string_8 == "")
		{
			Class1.string_6 = array[0].Split(new char[]
			{
				'-'
			})[1];
		}
		Debug.WriteLine(gameHost);
		IPAddress[] hostAddresses = Dns.GetHostAddresses(gameHost);
		foreach (IPAddress ipaddress in hostAddresses)
		{
			Class1.string_4 = ipaddress.ToString();
		}
		File.Copy(this.string_0, this.string_1);
		File.AppendAllText(this.string_0, "\r\n127.0.0.1\t" + gameHost);
		this.bool_0 = true;
		if (Class1.int_0 != port)
		{
			Class1.int_0 = port;
			Class1.class21_0 = new Class21();
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
	public void method_0()
	{
		if (this.bool_0)
		{
			StreamReader streamReader = new StreamReader(this.string_1);
			string value = streamReader.ReadToEnd();
			streamReader.Close();
			StreamWriter streamWriter = new StreamWriter(this.string_0);
			streamWriter.Write(value);
			streamWriter.Close();
			if (File.Exists(this.string_1))
			{
				File.Delete(this.string_1);
			}
			this.bool_0 = false;
		}
	}

	// Token: 0x040000EF RID: 239
	private string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\system32\\drivers\\etc\\hosts";

	// Token: 0x040000F0 RID: 240
	private string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\system32\\drivers\\etc\\hosts.bck";

	// Token: 0x040000F1 RID: 241
	private bool bool_0 = false;
}
