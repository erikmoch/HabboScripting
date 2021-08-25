using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacketLogger.Classes
{
    public class ServerPacketManage
    {
        internal SockHandler sockClass;
        wndMain mainForm;
        private DataStack mStack;

        public ServerPacketManage(SockHandler sockClass, wndMain mainForm)
        {
            // Get instances
            this.sockClass = sockClass;
            this.mainForm = mainForm;
            this.mStack = new DataStack(ref this.sockClass._RC4, this);
        }

        public void runPackets(string szData)
        {
            string wholePck = szData;
            string pck = "";

            // Loop
            /*while (wholePck != "")
            {
                int pckLen = sockClass.habboEncodings.decodeB64(wholePck.Substring(1, 2)) + 3;
                pck = wholePck.Substring(0, pckLen);
                wholePck = wholePck.Substring(pckLen);
                ServerProtocol(pck);
            }*/

            ServerProtocol(wholePck);
        }

        /*public void runPackets(string szData)
        {
            int charCount;

            for (charCount = 0; charCount < szData.Length; charCount++)
            {
                if (this.sockClass._encSent == true)
                {

                    mStack.cryptOn = true;
                    // Encryption is on :-)
                    string toIn = this.sockClass._RC4.deciphper(szData.Substring(charCount, 2));
                    mStack.newData(toIn);
                    charCount++; // +1 again to charCount, because we are doing 2chars instead of 1 :-)

                }
                else 
                {
                    // Encryption is off :-)
                    string toIn = szData.Substring(charCount, 1);
                    mStack.newData(toIn);
                }

                if (mStack.StackReady)
                {
                    ServerProtocol(StackFunctions.EncodeInt(mStack.StackData.Length, 3) + mStack.StackData);
                }
            }
        }*/

        private void ServerProtocol(string pck)
        {
            try
            {
                string tmpPck = pck;
                switch (pck.Substring(2))
                {
                    case "@A":
                        // @Ax_RAt28198060055442132775748128160271627020424699888376484448701315336738429686491376338449773524733616378225101375849293
                        //pck = pck.Substring(0, 6) + "11327754587858607315713800539258107547333354195987961233054591572488776856892571761906037997538141938962449439077610";
                        break;
                }
                //string endPacket = pck.Substring(3);
                sockClass.SendServer(pck);
                // For Packetlog
                string toLog = pck;
                //toLog = toLog.Replace("\r", "\r\n");
                // Check if packetlog enabled
                if (this.mainForm.chkServerPause.Checked == false)
                {
                    this.mainForm.AddServerLog(toLog + "\r\n");
                }
            }
            catch
            {

            }
        }
    }
}
