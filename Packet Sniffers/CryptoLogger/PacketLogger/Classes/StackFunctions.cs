using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketLogger.Classes
{
    public static class StackFunctions
    {
        public static string EncodeInt(int value, int length)
        {
            StringBuilder stack = new StringBuilder(length);
            for (int x = 1; x <= length; x++)
            {
                int offset = 6 * (length - x);
                byte val = (byte)(64 + (value >> offset & 0x3f));
                stack.Append((char)val);
            }
            return stack.ToString();
        }

        public static int DecodeInt(string strVal)
        {
            char[] val = strVal.ToCharArray();
            int intTot = 0;
            int y = 0;
            for (int x = (val.Length - 1); x >= 0; x--)
            {
                int intTmp = (int)(byte)((val[x] - 64));
                if (y > 0)
                {
                    intTmp = intTmp * (int)(Math.Pow(64, y));
                }
                intTot += intTmp;
                y++;
            }
            return intTot;
        }
    }
}
