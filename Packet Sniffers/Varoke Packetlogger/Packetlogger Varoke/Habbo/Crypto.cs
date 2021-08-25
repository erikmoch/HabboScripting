using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packetlogger_Varoke
{
    class HabboEncoders
    {
        // New Habbo Encoding by Itachi // Thanks to LittleJ
        // Called 'charEncode', nice name, no?
        // Include a easy CryptoClientMessage, enjoy!

        #region Habbo new Crypto: 'char Encode' by Itachi
        string Data;
        int Header;
        int Lenght;
        public string[] ExtraDatas;
        int e1 = 0;
        int e2 = 0;
        internal HabboEncoders(string InternalData)
        {
            Data = InternalData;
            string conn = Data.ToString();
            conn = conn.Replace("{char0}", Convert.ToChar(0).ToString());
            conn = conn.Replace("{char1}", Convert.ToChar(1).ToString());
            conn = conn.Replace("{char2}", Convert.ToChar(2).ToString());
            conn = conn.Replace("{char13}", Convert.ToChar(13).ToString());
            string final = "";
            foreach (char C in conn)
            {
                string zC = "{char" + (int)C + "}";
                final += zC;
            }
            final = final.Replace("{char", "");
            final = final.Substring(0, final.Length - 1);
            final = final.Replace("}", ";");
            string[] ToSepare = final.Split(';');
            int sLenght = HabboCrypto.DecodeBit8(InternalData.Substring(2, 2));
            int sHeader = HabboCrypto.DecodeBit8(InternalData.Substring(4, 2));
            string Extra = "";
            for (int i = 6; i != ToSepare.Length; i++)
            {
                string s = Convert.ToChar(int.Parse(ToSepare[i])).ToString();
                string Fs = "";
                if (ToSepare.Length > i + 1)
                    Fs = Convert.ToChar(int.Parse(ToSepare[i + 1])).ToString();
                if (GeneralSystem.IsValidName(s))
                {
                    Extra += Convert.ToChar(int.Parse(ToSepare[i]));
                    if (!GeneralSystem.IsValidName(Fs))
                        Extra += ";";
                }
                else
                    Extra += ToSepare[i] + ";";

            }
            Header = sHeader;
            Lenght = sLenght;
            ExtraDatas = Extra.Split(';');
        }

        internal int CharEncode_GetHeader()
        {
            return Header;
        }

        internal int CharEncode_GetLenght()
        {
            return Lenght;
        }

        internal string CharEncode_GetNextString()
        {
            while (true)
            {
                if (ExtraDatas.Length < e1)
                    return null;

                if (GeneralSystem.IsValidString(ExtraDatas[e1]))
                    return ExtraDatas[e1];
                else
                    e1++;
            }
        }

        internal int CharEncode_GetNextInt()
        {
            while (true)
            {
                if (ExtraDatas.Length < e1)
                    return -1;

                if (GeneralSystem.IsValidInt(ExtraDatas[e1]))
                    return int.Parse(ExtraDatas[e1]);
                else
                    e1++;
            }
        }
    }
        #endregion
}
