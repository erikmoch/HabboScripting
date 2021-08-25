using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketLogger.Classes
{
    class ClientPacketManage
    {
        SockHandler sockClass;
        wndMain mainForm;
        private string clientBuffer = "";

        public ClientPacketManage(SockHandler sockClass, wndMain mainForm)
        {
            // ~Constructor
            this.sockClass = sockClass;
            this.mainForm = mainForm;
        }

        public void SortClientPackets(string pck)
        {
            string newPck = "";
            string thePck = "";
            thePck = pck;

            if (this.clientBuffer != "")
            {
                thePck = clientBuffer + thePck;
                clientBuffer = "";
            }

            while (thePck != "")
            {
                if (thePck.IndexOf(Convert.ToChar(1)) != -1)
                {
                    newPck = thePck.Substring(0, thePck.IndexOf(Convert.ToChar(1)));
                    this.ClientProtocol(newPck);
                    thePck = thePck.Substring(thePck.IndexOf(Convert.ToChar(1)) + 1);
                }
                else
                {
                    this.clientBuffer = thePck;
                    break;
                }
            }
        }

        private void ClientProtocol(string pck)
        {
            string aPck = pck;

            switch (aPck.Substring(0, 2))
            {
                case "@A":
                    //sockClass._RC4 = new Habbo_Crypto_V23();
                    //sockClass._RC42 = new Habbo_Crypto_V23();
                    sockClass._encSent = false;
                    break;

                case "@E":
                    break;

                case "@m":
                    // Posters :-)
                    break;

            }
            // Forward Client packets to server
            sockClass.SendClient(aPck);
            // Log Packets
            string toLog = aPck;

            // Check if log = enabled
            if (this.sockClass.mainForm.chkClientPause.Checked == false)
            {
                this.mainForm.AddClientLog(toLog + "\r\n");
            }
        }
    }
}
