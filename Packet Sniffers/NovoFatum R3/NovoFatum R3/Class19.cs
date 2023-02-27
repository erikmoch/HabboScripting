using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading.Tasks;

// Token: 0x02000030 RID: 48
internal class Class19
{
	// Token: 0x06000126 RID: 294 RVA: 0x0000ED0C File Offset: 0x0000CF0C
	public int method_0(byte[] byte_2, byte[] byte_3)
	{
		int result = -1;
		int num = 0;
		for (int i = 0; i < byte_2.Length; i++)
		{
			if (byte_2[i] == byte_3[num])
			{
				if (num == byte_3.Length - 1)
				{
					result = i - num;
					return result;
				}
				num++;
			}
			else
			{
				num = 0;
			}
		}
		return result;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0000ED58 File Offset: 0x0000CF58
	public byte[] method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		byte[] array = null;
		int num = this.method_0(byte_2, byte_3);
		if (num >= 0)
		{
			array = new byte[byte_2.Length - byte_3.Length + byte_4.Length];
			Buffer.BlockCopy(byte_2, 0, array, 0, num);
			Buffer.BlockCopy(byte_4, 0, array, num, byte_4.Length);
			Buffer.BlockCopy(byte_2, num + byte_3.Length, array, num + byte_4.Length, byte_2.Length - (num + byte_3.Length));
		}
		return array;
	}

	// Token: 0x06000128 RID: 296 RVA: 0x0000EDBC File Offset: 0x0000CFBC
	public Class19(Socket sock)
	{
		this.socket_0 = sock;
		this.socket_1 = new Socket(2, SocketType.Stream, ProtocolType.Tcp);
		this.socket_1.BeginConnect(Class1.string_4, Class1.int_0, new AsyncCallback(this.method_2), null);
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0000EE3C File Offset: 0x0000D03C
	private void method_2(IAsyncResult iasyncResult_0)
	{
		this.bool_0 = Class1.bool_4;
		this.socket_1.EndConnect(iasyncResult_0);
		this.asyncCallback_0 = new AsyncCallback(this.method_6);
		this.asyncCallback_1 = new AsyncCallback(this.method_5);
		Task task = new Task(new Action(this.method_4));
		task.Start();
		Task task2 = new Task(new Action(this.method_3));
		task2.Start();
		GC.Collect();
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00003031 File Offset: 0x00001231
	private void method_3()
	{
		if (this.socket_0.Connected)
		{
			this.socket_0.BeginReceive(this.byte_0, 0, this.byte_0.Length, SocketFlags.None, this.asyncCallback_0, null);
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00003066 File Offset: 0x00001266
	private void method_4()
	{
		if (this.socket_1.Connected)
		{
			this.socket_1.BeginReceive(this.byte_1, 0, this.byte_1.Length, SocketFlags.None, this.asyncCallback_1, null);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000EEBC File Offset: 0x0000D0BC
	private void method_5(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = this.socket_1.EndReceive(iasyncResult_0);
			if (num == 0)
			{
				this.method_9();
				if (!this.bool_0)
				{
					Class1.smethod_2();
				}
			}
			else
			{
				byte[] byte_ = Class20.smethod_0(this.byte_1, 0, num);
				if (!this.bool_0)
				{
					Class17.smethod_1(byte_);
				}
				else
				{
					this.method_7(byte_);
				}
			}
		}
		catch (Exception)
		{
			this.method_9();
			if (!this.bool_0)
			{
				Class1.smethod_2();
			}
		}
		finally
		{
			Task task = new Task(new Action(this.method_4));
			task.Start();
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000EF6C File Offset: 0x0000D16C
	private void method_6(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = this.socket_0.EndReceive(iasyncResult_0);
			if (num == 0)
			{
				this.method_9();
				if (!this.bool_0)
				{
					Class1.smethod_2();
				}
			}
			else
			{
				byte[] byte_ = Class20.smethod_0(this.byte_0, 0, num);
				if (Class24.class25_1 != null)
				{
					Class24.class25_1.method_1(byte_);
				}
				if (!this.bool_0)
				{
					Class17.smethod_0(byte_);
				}
				else
				{
					this.method_8(byte_);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.ToString());
			this.method_9();
			if (!this.bool_0)
			{
				Class1.smethod_2();
			}
		}
		finally
		{
			Task task = new Task(new Action(this.method_3));
			task.Start();
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0000309B File Offset: 0x0000129B
	public void method_7(byte[] byte_2)
	{
		while (this.bool_1)
		{
		}
		this.bool_1 = true;
		this.socket_0.Send(byte_2);
		this.bool_1 = false;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x000030C1 File Offset: 0x000012C1
	public void method_8(byte[] byte_2)
	{
		while (this.bool_2)
		{
		}
		this.bool_2 = true;
		if (Class24.class25_0 != null)
		{
			Class24.class25_0.method_1(byte_2);
		}
		this.socket_1.Send(byte_2);
		this.bool_2 = false;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000030FC File Offset: 0x000012FC
	private void method_9()
	{
		this.socket_1.Disconnect(false);
		this.socket_0.Disconnect(false);
		Debug.WriteLine("closed!!");
	}

	// Token: 0x040000F2 RID: 242
	private byte[] byte_0 = new byte[1048576];

	// Token: 0x040000F3 RID: 243
	private byte[] byte_1 = new byte[1048576];

	// Token: 0x040000F4 RID: 244
	private Socket socket_0;

	// Token: 0x040000F5 RID: 245
	private Socket socket_1;

	// Token: 0x040000F6 RID: 246
	private AsyncCallback asyncCallback_0;

	// Token: 0x040000F7 RID: 247
	private AsyncCallback asyncCallback_1;

	// Token: 0x040000F8 RID: 248
	private bool bool_0 = false;

	// Token: 0x040000F9 RID: 249
	private bool bool_1 = false;

	// Token: 0x040000FA RID: 250
	private bool bool_2 = false;
}
