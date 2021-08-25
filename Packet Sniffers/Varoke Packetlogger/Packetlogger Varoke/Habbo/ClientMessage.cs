using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packetlogger_Varoke
{
    static class HabboEncoding
    {
        public static string cypherShort(int v) // str len, packet len, packet header -- b64
        {
            string t = "";
            t += (char)((v >> 8) & 0xFF);
            t += (char)((v >> 0) & 0xFF);
            return t;
        }

        public static string cypherInt(int v)
        {
            string t = "";
            t += (char)((v >> 24) & 0xFF);
            t += (char)((v >> 16) & 0xFF);
            t += (char)((v >> 8) & 0xFF);
            t += (char)((v >> 0) & 0xFF);
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

    public class SClientMessage
    {
        public String oString;
        private String oData;
        public SClientMessage(string Data)
        {
            oString = Data;
            oData = oString.Substring(6);
        }

        public int Lenght()
        {
            return HabboEncoding.DecodeBit8(oString.Substring(2, 4));
        }

        public int Header()
        {
            return HabboEncoding.DecodeBit8(oString.Substring(4, 6));
        }

        public int GetNextInt()
        {
            int result = HabboEncoding.DecodeBit24(oData.Substring(0, 4));
            oData = oData.Substring(4);

            return result;
        }

        public String GetNextString()
        {
            int len = HabboEncoding.DecodeBit8(oData.Substring(0, 2));
            oData = oData.Substring(2);

            String Result = oData.Substring(0, len);
            oData = oData.Substring(len);

            return Result;
        }
    }

    class ClientMessage
    {
        public String oString;
        public String oData;

        public ClientMessage(string Data)
        {
            oData = Data.Substring(4);
        }
        public int Header()
        {
            int Header = HabboCrypto.DecodeBit8(oData.Substring(0, 2));
            oData = oData.Substring(2);
            return Header;
        }

        public bool CanGetNextString()
        {
            try
            {
                int len = HabboCrypto.DecodeBit8(oData.Substring(0, 2));
                if (len > 0)
                {
                    String Result = oData.Substring(0, len);
                    if (Result != "")
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public int NewNextInt()
        {
            int result = HabboCrypto.DecodeBit24(oData.Substring(1, 4));
            return result;
        }

        public int GetNextInt()
        {
            int result = HabboCrypto.DecodeBit24(oData.Substring(0, 4));
            oData = oData.Substring(4);

            return result;
        }

        public String GetNextString()
        {
            int len = HabboCrypto.DecodeBit8(oData.Substring(0, 2));
            oData = oData.Substring(2);

            String Result = oData.Substring(0, len);
            oData = oData.Substring(len);

            return Result;
        }
    }
}
