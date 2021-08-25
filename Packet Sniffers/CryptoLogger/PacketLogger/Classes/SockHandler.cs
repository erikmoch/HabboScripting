using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Windows.Forms;
using System.Threading;


namespace PacketLogger.Classes
{
    public class SockHandler
    {
        // Variables
        Socket sockServer;
        Socket sockClient;
        public Habbo_Crypto_V23 _RC4;
        public Habbo_Crypto_V23 _RC42;
        ServerPacketManage serverManagement;
        ClientPacketManage clientManagement;
        public Encodings habboEncodings = new Encodings();
        public bool _encSent;
        private AsyncCallback serverCallback;
        private AsyncCallback clientCallback;
        internal byte[] serverBuffer = new byte[1024];
        internal byte[] clientBuffer = new byte[1024];
        public wndMain mainForm;
        string habboHostname;
        int habboPort;

        public SockHandler(int habboPort, string habboHost, wndMain mainForm)
        {
            // parse vars
            this.habboPort = habboPort;
            this.habboHostname = habboHost;
            this.mainForm = mainForm;
            // Start listening
            sockClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint local = new IPEndPoint(IPAddress.Any, this.habboPort);
            // Bind to sock
            sockClient.Bind(local);
            // Listen -> Backlog 1
            sockClient.Listen(1);
            // Wait for connection
            sockClient.BeginAccept(new AsyncCallback(Connection_Request), null);
            // Create server Socket -> Has to connect once client has established
            sockServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Construct handling classes
            this.serverManagement = new ServerPacketManage(this, this.mainForm);
            this.clientManagement = new ClientPacketManage(this, this.mainForm);
        }

        private void Connection_Request(IAsyncResult asyn)
        {
            // Called by sockClient when a connection is requested
            try
            {
                sockClient = sockClient.EndAccept(asyn);
                IPEndPoint localServer = new IPEndPoint(IPAddress.Parse(Dns.GetHostEntry(this.habboHostname).AddressList[0].ToString()), this.habboPort);
                sockServer.BeginConnect(localServer, new AsyncCallback(Server_Connect), null);
            }
            catch
            {
                // TODO: Errorz
            }

        }

        private void Server_Connect(IAsyncResult asyn)
        {
            // Called by sockServer -> When a Connection is established
            sockServer.EndConnect(asyn);
            // Allow both sockets to recv. data
            Server_DataArrival();
            Client_DataArrival();
        }

        private void Server_DataArrival()
        {
            // When data wants to be recv.
            // Server socket is allowed to connect -> Passes onto function Server_GetData
            if (serverCallback == null)
            {
                if (sockServer.Connected == true)
                {
                    serverCallback = new AsyncCallback(Server_GetData);
                }
            }

            if (sockServer.Connected == true)
            {
                sockServer.BeginReceive(serverBuffer, 0, serverBuffer.Length, SocketFlags.None, serverCallback, null);
            }
        }

        private void Client_DataArrival()
        {
            if (clientCallback == null)
            {
                if (sockClient.Connected == true)
                {
                    clientCallback = new AsyncCallback(Client_GetData);
                }
            }

            if (sockClient.Connected == true)
            {
                sockClient.BeginReceive(clientBuffer, 0, clientBuffer.Length, SocketFlags.None, clientCallback, null);
            }
        }

        private void Server_GetData(IAsyncResult asyn)
        {
            int _iRcv = 0;
            _iRcv = sockServer.EndReceive(asyn);
            // Check if any data was rcv.
            if (_iRcv == 0)
            {
                // TODO: Call error here
            }

            char[] _characters = new char[_iRcv];
            Decoder decode = Encoding.Default.GetDecoder();
            int _charactersLen = decode.GetChars(serverBuffer, 0, _iRcv, _characters, 0);
            string szData = new string(_characters);
            // Deal with Data =]
            this.clientManagement.SortClientPackets(szData);
            // Wait for some more data -> Cycle much?
            Server_DataArrival();
        }

        private void Client_GetData(IAsyncResult asyn)
        {
            int _iRcv = 0;
            _iRcv = sockClient.EndReceive(asyn);
            if (_iRcv == 0)
            {
                // TODO: Call Error here plx
            }

            char[] _characters = new char[_iRcv];
            Decoder decode = Encoding.Default.GetDecoder();
            int _charactersLen = decode.GetChars(clientBuffer, 0, _iRcv, _characters, 0);
            string szData = new string(_characters);
            serverManagement.runPackets(szData);
            // call ServerPacketClass
            Client_DataArrival();
        }


        #region Send Functions
        public void SendServerHeaders(string pck)
        {
            try
            {
                if (sockServer.Connected == true)
                {
                    pck = "@" + habboEncodings.encodeB64(pck) + pck;
                    if (_encSent == true)
                    {
                        pck = _RC42.encipher(pck);
                        _RC42.rePremix();
                    }
                    // Send Data
                    byte[] theData = Encoding.Default.GetBytes(pck);
                    sockServer.Send(theData);
                }
            }
            catch
            {

            }
        }

        public void SendClient(string pck)
        {
            try
            {
                byte[] theData = Encoding.Default.GetBytes(pck + Convert.ToChar(1));
                sockClient.Send(theData);
            }
            catch
            {
            }
        }

        public void SendServer(string pck)
        {
            try
            {
                if (sockServer.Connected == true)
                {
                    // Send Data
                    byte[] theData = Encoding.Default.GetBytes(pck);
                    sockServer.Send(theData);
                }
            }
            catch
            {

            }
        }

        #endregion
    }
}
