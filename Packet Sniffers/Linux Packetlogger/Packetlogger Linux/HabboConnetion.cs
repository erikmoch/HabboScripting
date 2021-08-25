using System;
using System.Net;
using System.Net.Sockets;
namespace PacketloggerLinux
{
    class HabboConnection
    {
        private byte[] clientBuffer;
        private byte[] serverBuffer;

        private TcpListener _Listen;

        private Socket _Client;
        private Socket _Server;

        private AsyncCallback clientAsyn;
        private AsyncCallback serverAsyn;
        public HabboConnection()
        {
            _Listen = new TcpListener(38101);
            _Listen.Start();

            waitForDataListener();
        }

        private void waitForDataListener()
        {
            _Listen.BeginAcceptSocket(new AsyncCallback(StartupConnection), null);
        }

        private void StartupConnection(IAsyncResult iAr)
        {
            if (_Client != null && _Server != null) closeConnection();
            if (clientAsyn != null) clientAsyn = null;
            if (serverAsyn != null) serverAsyn = null;

            clientBuffer = new byte[1024];
            serverBuffer = new byte[1024];

            _Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _Client = _Listen.EndAcceptSocket(iAr);

            _Server.BeginConnect("66.132.225.13", 38101, new AsyncCallback(startProxy), null);

            waitForDataListener();
        }

        private void startProxy(IAsyncResult iAr)
        {
			Console.WriteLine("--- Startup ---");
            _Server.EndConnect(iAr);

            waitClientData();
            waitServerData();
        }

        #region client datagram -- client to server
        private void waitClientData()
        {
            if (clientAsyn == null)
            {
                clientAsyn = new AsyncCallback(clientReceive);
            }
            if (_Client.Connected)
            {
                _Client.BeginReceive(clientBuffer, 0, clientBuffer.Length, SocketFlags.None, clientAsyn, null);
            }
        }

        private void clientReceive(IAsyncResult iAr)
        {
            try
            {
                int bytes = _Client.EndReceive(iAr);

				// Console.WriteLine("[server] Receive " + bytes + " bytes");
				
                if (bytes == 0)
                {
                    closeConnection();
                    return;
                }

                string receive = System.Text.Encoding.GetEncoding("ISO-8859-1").GetString(clientBuffer, 0, bytes);
				
												string header = receive.Substring(4, 2);
				int id = decypherShort(header);
                sendToServer(receive);
				
				string leN = receive.Substring(2, 2);
				
				Console.WriteLine("[server] <-- " + receive.Replace(((char)1).ToString(), "[0]"));		
				MainClass.clientLog.AppendLine("[server][" + id +"] <-- " + getchrStr(receive) + " Len: " + decypherShort(leN));
            }
            catch
            {
            }
            finally
            {
                waitClientData();
            }

        }

        public void sendToClient(string data)
        {
            _Client.Send(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(data));
        }
        #endregion

        #region server datagram -- server to client
        private void waitServerData()
        {
            if (serverAsyn == null)
            {
                serverAsyn = new AsyncCallback(serverReceive);
            }
            if (_Server.Connected)
            {
                _Server.BeginReceive(serverBuffer, 0, serverBuffer.Length, SocketFlags.None, serverAsyn, null);
            }
        }

        private void serverReceive(IAsyncResult iAr)
        {
            try
            {
                if (iAr == null) return;
                int bytes = _Server.EndReceive(iAr);

				// Console.WriteLine("[client] Receive " + bytes + " bytes");
                if (bytes == 0)
                {
                    closeConnection();
                    return;
                }
     
				string receive = System.Text.Encoding.GetEncoding("ISO-8859-1").GetString(serverBuffer, 0, bytes);

                sendToClient(receive);
								string header = receive.Substring(4, 2);
				int id = decypherShort(header);
				Console.WriteLine("[client][" + id + "] <-- " + getchrStr(receive));
				MainClass.clientLog.AppendLine("[client][" + id +"] <-- "+ getchrStr(receive));
            }
            catch
            {
            }
            finally
            {
                waitServerData();
            }
        }
        private int decypherShort(string v)
        {
            if ((v[0] | v[1]) < 0)
                return -1;
            return ((v[0] << 8) + (v[1] << 0));
        }
		private string getchrStr(string data)
		{
			string output = "";
			foreach(char o in data)
			{
				int C = o;
				if(C < 1)
				{
					output += "[" + C + "]";
				}
				else
				{
					output += o;
				}
			}
			return output;
		}
        public void sendToServer(string data)
        {
            _Server.Send(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(data));
        }
        #endregion

        #region utils
        private IPAddress getIpFromHost(string Host)
        {
            IPAddress[] IPs = Dns.GetHostAddresses(Host);
            foreach (IPAddress IP in IPs)
            {
                return IP;
            }

            return null;
        }

        private void closeConnection()
        {
            _Server.Disconnect(false);
            _Client.Disconnect(false);
        }
        #endregion
	}
}

