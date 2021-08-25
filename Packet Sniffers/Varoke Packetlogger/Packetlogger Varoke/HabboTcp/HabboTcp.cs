using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
namespace Packetlogger_Varoke.HabboTcp
{
    /// <summary>
    /// Write by Littlej
    /// </summary>
    class HabboTCP
    {
        private int Pos;
        private int Port;
        private string Host;
        private byte[] HabboDataBuffer = new byte[2048];
        public bool RoomLagFilter = false;
        public bool TradeLagFilter = false;
        private Socket Server;
        private Socket Client;
        private TcpListener Open;

        private AsyncCallback ServerCallBack;
        private AsyncCallback ClientCallBack;
        public List<string> ClientFilter;
        public List<string> ServerFilter;
        public HabboTCP(int Port, string Host)
        {
            this.ClientFilter = new List<string>();
            this.ServerFilter = new List<string>();
            this.Port = Port;
            this.Host = Host;
            Open = new TcpListener(this.Port);
            Open.Start();
            @WaitForData();
            @SetConnection();
        }
        private void SetConnection()
        {
            if (Server != null)
                Server.Dispose();
            if (Client != null)
                Client.Dispose();
            if (ClientCallBack != null)
                ClientCallBack = null;
            if (ServerCallBack != null)
                ServerCallBack = null;
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        private void WaitForData()
        {
            Open.BeginAcceptSocket(new AsyncCallback(OnAcceptNewConnection), null);
        }
        /// <summary>
        /// Fix more than one connection.
        /// </summary>
        /// <param name="iAr"></param>
        private void OnAcceptNewConnection(IAsyncResult iAr)
        {
            SetConnection();
            Client = Open.EndAcceptSocket(iAr);
            if (Client.RemoteEndPoint.ToString().Split(':')[0] != "127.0.0.1")
            {
                WaitForData();
                return;
            }
            IPEndPoint ServerAddress = new IPEndPoint(IPAddress.Parse(this.Host), this.Port);
            Server.BeginConnect(ServerAddress, new AsyncCallback(OnStartAsyncallback), null);
            WaitForData();
        }

        private void OnStartAsyncallback(IAsyncResult iAr)
        {
            Server.EndConnect(iAr);
            try
            {
                ServerConnection();
            }
            catch { }
            try
            {
                ClientConnection();
            }
            catch { }
        }

        private void ClientConnection()
        {
            try
            {
                if (ClientCallBack == null)
                {
                    if (Client.Connected)
                    {
                        ClientCallBack = new AsyncCallback(OnServerReceive);
                    }
                }
                if (Client.Connected)
                {
                    Client.BeginReceive(HabboDataBuffer, 0, HabboDataBuffer.Length, SocketFlags.None, ClientCallBack, null);
                }
            }
            catch { ClientConnection(); }
        }

        private void ServerConnection()
        {
            try
            {
                if (ServerCallBack == null)
                {
                    if (Server.Connected)
                    {
                        ServerCallBack = new AsyncCallback(OnClientReceive);
                    }
                }

                if (Server.Connected)
                {
                    Server.BeginReceive(HabboDataBuffer, 0, HabboDataBuffer.Length, SocketFlags.None, ServerCallBack, null);
                }
            }
            catch { ServerConnection(); }
        }
        private void CloseConnection()
        {
            Client.Disconnect(false);
            Server.Disconnect(false);
        }
        #region Data Process
        /// <summary>
        /// For doing extra-user interactions.
        /// </summary>
        /// <param name="Data"></param>
        private void DataProcess(string Data)
        {
            if (Data.StartsWith("<"))
            {
                CloseConnection();
                return;
            }
            string ExtraData = Data.Substring(2);

            switch (Data.Substring(0, 2))
            {
               /* case "@E":
                    StringBuilder Packet = new StringBuilder();

                    Packet.Append("BK");
                    Packet.Append("Welcome to PacketLogger Varoke 1.0");
                    Packet.Append((char)1);

                    SendToClient(Packet.ToString());
                    break;*/
            }
        }
        #endregion

        #region ClientCallBack
        private void OnServerReceive(IAsyncResult iAr)
        {
            try
            {
                int ReceiveData = 0;
                ReceiveData = Client.EndReceive(iAr);
                StringBuilder DataBuffer = new StringBuilder();
                DataBuffer.Append(System.Text.Encoding.Default.GetString(HabboDataBuffer, 0, ReceiveData));

                string connectionData = System.Text.Encoding.Default.GetString(HabboDataBuffer, 0, ReceiveData);

                if (connectionData == "")
                {
                    CloseConnection();
                    return;
                }
                if (ServerFilter.Contains(connectionData.Substring(0, 2)))
                {
                    ServerConnection();
                    return;
                }
                string Data = connectionData;
                WriteServerLine(Data.Replace(Convert.ToChar(0).ToString(), "[0]"));
                SendToServer(connectionData);
            }
            catch { }
            ClientConnection();
        }
        #endregion

        #region ServerCallBack
        private int MyCredits = 0;
        private void OnClientReceive(IAsyncResult iAr)
        {
            try
            {
                int ReceiveData = 0;
                ReceiveData = Server.EndReceive(iAr);

                string connectionData = System.Text.Encoding.Default.GetString(HabboDataBuffer, 0, ReceiveData);
                if (connectionData == "")
                {
                    CloseConnection();
                    return;
                }
                if (connectionData.StartsWith("@{"))
                {
                    if (RoomLagFilter)
                    {
                        ServerConnection();
                        return;
                    }
                }
                if (connectionData.StartsWith("Ah"))
                {
                    if (TradeLagFilter)
                    {
                        ServerConnection();
                        return;
                    }

                }
                if (ClientFilter.Contains(connectionData.Substring(0, 2)))
                {
                    ServerConnection();
                    return;
                }
                string Data = connectionData;

                if (Data.StartsWith("<?xml"))
                    WriteClientLine(connectionData);
                else
                {
                    WriteClientLine(connectionData.Replace(Convert.ToChar(0).ToString(), "[0]").Replace(Convert.ToChar(1).ToString(), "[1]").Replace(Convert.ToChar(2).ToString(), "[2]").Replace(Convert.ToChar(3).ToString(), "[3]").Replace(Convert.ToChar(4).ToString(), "[4]").Replace(Convert.ToChar(10).ToString(), "[10]").Replace(Convert.ToChar(13).ToString(), "[13]"));
                }

                SendToClient(connectionData);
                DataProcess(connectionData);
            }
            catch { }
            ServerConnection();
        }
        #endregion

        #region Print
        private string DataClient = "";
        private string DataServer = "";
        private void WriteClientLine(string Data)
        {
            this.DataClient = Data;
            this.DataClient = this.DataClient.Replace("[NEWLINE]", "#");
            mWriteClienTLine();
        }
        private void mWriteClienTLine()
        {
            try
            {
                AppManager.Packetlogger.WriteClientLine("-----");
                if (DataClient.Contains("#"))
                {
                    foreach (string Line in DataClient.Split('#'))
                    {
                        AppManager.Packetlogger.WriteClientLine(Line);
                    }
                }
                else
                    AppManager.Packetlogger.WriteClientLine(DataClient);
            }
            catch { }
        }
        private void WriteServerLine(string Data)
        {
            try
            {
                this.DataServer = Data;
                WriteServerTLine();
            }
            catch { }
        }
        private void WriteServerTLine()
        {
            try
            {
                AppManager.Packetlogger.WriteServerLine("-----");
                AppManager.Packetlogger.WriteServerLine(DataServer);
            }
            catch { }
        }
        #endregion

        #region DataSender
        public void SendToClient(string Data)
        {
            try
            {
                string conn = Data;
                conn = conn.Replace("{char0}", Convert.ToChar(0).ToString());
                conn = conn.Replace("{char1}", Convert.ToChar(1).ToString());
                conn = conn.Replace("{char2}", Convert.ToChar(2).ToString());
                conn = conn.Replace("{char10}", Convert.ToChar(10).ToString());
                conn = conn.Replace("{char13}", Convert.ToChar(13).ToString());
                byte[] byData = System.Text.Encoding.Default.GetBytes(conn);
                Client.Send(byData);
            }
            catch { }
        }

        public void SendToServer(string Data)
        {
            try
            {
                byte[] byData = System.Text.Encoding.Default.GetBytes(Data);
                Server.Send(byData);
            }
            catch { }
        }
        #endregion
    }
}
