using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketLogger.Classes
{
    public class DataStack
    {
        private StringBuilder sb;
        int state = 0;
        int waitFor;
        bool stackDone = false;
        const int headersize = 3;
        private Habbo_Crypto_V23 crypt;
        private ServerPacketManage handler;
        internal bool cryptOn = false;

        public DataStack(ref Habbo_Crypto_V23 crypt, ServerPacketManage handle)
        {
            this.crypt = crypt;
            this.handler = handle;
        }

        public void newData(string data)
        {
            switch (state)
            {
                case 0: //New stack
                    sb = new StringBuilder();
                    state = 1;
                    newData(data);
                    break;

                case 1: //Message Header
                    sb.Append(data);
                    if (sb.Length == headersize)
                    {
                        waitFor = StackFunctions.DecodeInt(sb.ToString());
                        sb = new StringBuilder();
                        state = 2;
                    }
                    break;

                case 2: //Message
                    sb.Append(data);
                    if (sb.Length == waitFor)
                    {
                        stackDone = true;
                        state = 0;

                        if (this.cryptOn)
                        {
                            this.handler.sockClass._RC4.premixTable("aaaaaaaaaaaaaaaaaaaa", 10);
                        }
                    }
                    break;

            }
        }

        public bool StackReady
        {
            get
            {
                return stackDone;
            }
        }

        public string StackData
        {
            get
            {
                stackDone = false;
                return sb.ToString();
            }
        }
    }
}
