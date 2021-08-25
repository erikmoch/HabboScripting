using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PacketLogger.Classes
{
    class socketManage
    {
        public static Hashtable mySockets = new Hashtable();

        public static SockHandler getSocket(int socketNumber)
        {
            return (SockHandler)mySockets[socketNumber];
        }
    }
}
