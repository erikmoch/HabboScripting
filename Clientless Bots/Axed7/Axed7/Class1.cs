using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Axed
{
    class AxedServerSocketManager
    {
        string License;
        Socket MySocket;
        frmSplash frmSplash;
        private AsyncCallback pfnWorkerCallBack;
        private byte[] dataBuffer = new byte[1000];
        public AxedServerSocketManager(string License, frmSplash fS)
        {
            this.frmSplash = fS;
            this.License = License;
            MySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint Details = new IPEndPoint(IPAddress.Parse(Dns.GetHostEntry("jeax.redirectme.net").AddressList[0].ToString()),1337);
            IPEndPoint Details = new IPEndPoint(IPAddress.Parse(Dns.GetHostEntry("localhost").AddressList[0].ToString()),1337);
            MySocket.Connect(Details);
            SendData(License + Convert.ToChar(10) + System.Windows.Forms.SystemInformation.ComputerName);
            WaitForData();
        }
        internal void SendData(string TheData)
        {
            try
            {
                string Tmp = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(TheData));

                byte[] byData = System.Text.Encoding.Default.GetBytes(Tmp);
                MySocket.Send(byData);
            }
            catch
            {

            }
        }
        private void WaitForData()
        {
            if (pfnWorkerCallBack == null)
            {
                if (MySocket.Connected == true)
                {
                    pfnWorkerCallBack = new AsyncCallback(DataRecieved);
                }
            }

            if (MySocket.Connected == true)
            {
                MySocket.BeginReceive(dataBuffer, 0, dataBuffer.Length, SocketFlags.None, pfnWorkerCallBack, null);

            }
        }
        private void DataRecieved(IAsyncResult syncc)
        {
            try
            {
                int iRx = 0;
                iRx = MySocket.EndReceive(syncc);
                char[] chars = new char[iRx];
                System.Text.Decoder d = System.Text.Encoding.Default.GetDecoder();
                int charLen = d.GetChars(dataBuffer, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                string Tmp = new System.String(Encoding.Default.GetChars(Convert.FromBase64String(szData)));
                Tmp = Tmp.Substring(0, Tmp.IndexOf(Convert.ToChar(5)));
                switch (Tmp)
                {
                    case "ACCEPT":
                        frmSplash.EnableMe();
                        break;
                    case "DENY":
                        System.Windows.Forms.MessageBox.Show("License or ticket wrong!");
                        Environment.Exit(0);
                        break;
                    case "REGD":
                        System.Windows.Forms.MessageBox.Show("Registration Successful!");
                        frmSplash.EnableMe();
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("License or ticket wrong!");
                        Environment.Exit(0);
                        break;
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("License or ticket wrong or other unknown error!");
                Environment.Exit(0);
            }
        }
    }
}
