using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packetlogger_Varoke
{
    class HabboCrypto
    {
        public static string EncodeBit32(string v)
        {
            return EncodeBit32(v.Length);
        }

        public static string EncodeBit32(int v) // int
        {
            string t = "";
            t += (char)0; // 4 bytes
            t += (char)((v >> 24) & 0xFF); // 3 bytes
            t += (char)((v >> 16) & 0xFF); // 2 bytes
            t += (char)((v >> 8) & 0xFF); // 1 byte
            t += (char)((v) & 0xFF);
            return t;
        }

        public static int DecodeBit24(string v)
        {
            if ((v[0] | v[1] | v[2] | v[3]) < 0)
                return -1;
            return ((v[0] << 24) + (v[1] << 16) + (v[2] << 8) + (v[3] << 0));
        }

        public static int DecodeBit8(string v)
        {
            if ((v[0] | v[1]) < 0)
                return -1;
            return ((v[0] << 8) + (v[1] << 0));
        }
    }
}
