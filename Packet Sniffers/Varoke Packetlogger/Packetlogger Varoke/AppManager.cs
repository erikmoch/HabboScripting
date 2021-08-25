using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Packetlogger_Varoke.HabboTcp;
namespace Packetlogger_Varoke
{
    static class AppManager
    {
        public static ConnectionManager Connection;
        public static Logger Packetlogger;
        public static void OnClose()
        {
            if (Connection != null)
            {
                Connection.CheckHost(Connection.Normalhost);
            }
            Environment.Exit(0);
        }
    }
}
