using System;
using System.Collections.Generic;
using System.Text;

namespace Axed
{
    class ConnectionManager
    {
        public static System.Collections.Hashtable activeSockets = new System.Collections.Hashtable();

        public static ConnectionHandler GReference(int LoginNumber)
        {
            return (ConnectionHandler)activeSockets[LoginNumber];
        }
    }
}
