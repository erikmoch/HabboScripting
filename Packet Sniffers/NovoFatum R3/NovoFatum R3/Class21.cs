using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

// Token: 0x02000032 RID: 50
internal class Class21
{
	// Token: 0x06000133 RID: 307 RVA: 0x00003120 File Offset: 0x00001320
	public Class21()
	{
		this.tcpListener_0 = new TcpListener(IPAddress.Any, Class1.int_0);
		this.tcpListener_0.Start();
		this.method_1();
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000314E File Offset: 0x0000134E
	private void method_0()
	{
		this.tcpListener_0.BeginAcceptSocket(new AsyncCallback(this.method_2), null);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
	private void method_1()
	{
		Task task = new Task(new Action(this.method_0));
		task.Start();
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000F0CC File Offset: 0x0000D2CC
	private void method_2(IAsyncResult iasyncResult_0)
	{
		Class1.bool_4 = !Class1.bool_4;
		Socket sock = this.tcpListener_0.EndAcceptSocket(iasyncResult_0);
		Class1.class19_0 = new Class19(sock);
		this.method_1();
	}

	// Token: 0x040000FB RID: 251
	public static byte[] byte_0 = new byte[1048576];

	// Token: 0x040000FC RID: 252
	private TcpListener tcpListener_0;
}
