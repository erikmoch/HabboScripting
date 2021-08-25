using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketLogger.Classes
{
    public class Encodings
    {
        public int GetVL64Length(char[] raw)
        {
            int pos = 0;
            int v = 0;
            bool negative = (raw[pos] & 4) == 4;
            int totalBytes = raw[pos] >> 3 & 7;
            v = raw[pos] & 3;
            pos++;
            int shiftAmount = 2;
            for (int b = 1; b < totalBytes; b++)
            {
                v |= (raw[pos] & 0x3f) << shiftAmount;
                shiftAmount = 2 + 6 * b;
                pos++;
            }

            if (negative == true)
                v *= -1;

            string Tmp;
            Tmp = encodeVL64(v);
            return Tmp.Length;
        }

        public string encodeB64(int value, int length)
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

        public string encodeB64(string strVal)
        {
            int value = strVal.Length;
            int length = 2;
            StringBuilder stack = new StringBuilder(length);
            for (int x = 1; x <= length; x++)
            {
                int offset = 6 * (length - x);
                byte val = (byte)(64 + (value >> offset & 0x3f));
                stack.Append((char)val);
            }
            return stack.ToString();
        }

        public int decodeB64(string strVal)
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

        public string encodeVL64(int i)
        {
            byte[] wf = new byte[6];
            int pos = 0;
            int startPos = pos;
            int bytes = 1;
            int negativeMask = i >= 0 ? 0 : 4;
            i = Math.Abs(i);
            wf[pos++] = (byte)(64 + (i & 3));
            for (i >>= 2; i != 0; i >>= 6)
            {
                bytes++;
                wf[pos++] = (byte)(64 + (i & 0x3f));
            }

            wf[startPos] = (byte)(wf[startPos] | bytes << 3 | negativeMask);

            System.Text.ASCIIEncoding encoder = new ASCIIEncoding();
            string tmp = encoder.GetString(wf);
            return tmp.Replace("\0", "");
        }

        public int decodeVL64(string data)
        {
            return decodeVL64(data.ToCharArray());
        }

        public int decodeVL64(char[] raw)
        {
            int pos = 0;
            int v = 0;
            bool negative = (raw[pos] & 4) == 4;
            int totalBytes = raw[pos] >> 3 & 7;
            v = raw[pos] & 3;
            pos++;
            int shiftAmount = 2;
            for (int b = 1; b < totalBytes; b++)
            {
                v |= (raw[pos] & 0x3f) << shiftAmount;
                shiftAmount = 2 + 6 * b;
                pos++;
            }

            if (negative == true)
                v *= -1;
            return v;
        }
    }
}
