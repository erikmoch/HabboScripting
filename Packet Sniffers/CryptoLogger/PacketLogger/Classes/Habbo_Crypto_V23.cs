/* Habbo Hotel RC4 Encryption Algorithm
 * Habbo Hotel Version: 23
 * Cracked By: Mike[Office.Boy] & Erik[Sage]
 * Changelog: - setKey, preMix functions stripped [Static Enc]
 *            - init stripped, sBox (Table) is set manually [pSBox]
 *            - STATIC encryption - Habbo No longer sets a key (Fuck knows why)
 * 
 * http://script-o-matic.net
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketLogger.Classes
{
    public class Habbo_Crypto_V23
    {
        // Class Variables
        int i;
        int j;

        int[] key = new int[256];
        int[] table = new int[256];

        public string dBuffer;

        public bool toPremix;

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

        public Habbo_Crypto_V23()
        {
            //Initialise the variables that store offset info
            this.initCalculators();

            //Set up the key and table arrays
            this.init();

            this.premixTable(this.premixString, this.premixCount);
        }

        private void initCalculators()
        {
            i = 0;
            j = 0;
        }

        private static string GenerateRandomString(int Length)
        {
            string tmp = "";
            Random Rnd = new Random();
            for (int x = 0; x < Length; x++)
            {
                char tmp2 = (char)Rnd.Next(65, 122);
                tmp += tmp2.ToString();
            }
            return tmp;
        }

        internal void premixTable(string datain, int count)
        {
            for (int a = 0; a < count; a++)
            {
                this.encipher(datain);
            }
        }

        private void init()
        {
            int z;

            for (z = 0; z <= 254; z++)
            {
                table[z] = z + 1;
            }
            table[0] = 0;
            table[255] = 1;
        }

        public string encipher(string data)
        {
            StringBuilder cipher = new StringBuilder(data.Length * 2);

            int t = 0;
            int k = 0;

            for (int a = 0; a < data.Length; a++)
            {
                i = (i + 1) % 256;
                j = (j + table[i]) % 256;
                t = table[i];
                table[i] = table[j];
                table[j] = t;

                k = table[(table[i] + table[j]) % 256];

                int c = (char)data.Substring(a, 1).ToCharArray()[0] ^ k;

                if (c <= 0)
                {
                    cipher.Append("00");
                }
                else
                {
                    cipher.Append(di[c >> 4 & 0xf]);
                    cipher.Append(di[c & 0xf]);
                }

            }
            return cipher.ToString();
        }

        public string deciphper(string data)
        {
            StringBuilder cipher = new StringBuilder(data.Length);
            int t = 0;
            int k = 0;
            for (int a = 0; a < data.Length; a += 2)
            {
                i = (i + 1) % 256;
                j = (j + table[i]) % 256;
                t = table[i];
                table[i] = table[j];
                table[j] = t;
                k = table[(table[i] + table[j]) % 256];
                //t = System.Convert.ToInt32( data.Substring(a, a + 2), 16);
                t = System.Convert.ToInt32(JavaSubstring(data, a, a + 2), 16);
                cipher = cipher.Append((char)(t ^ k));
            }

            return cipher.ToString();
        }

        public string rePremix()
        {
            int tmpCount = 11;
            string tmpString = "riMUcVB[rTVypVYADlk";
            this.premixTable(tmpString, tmpCount);
            return "";
        }

        public string JavaSubstring(string dataIn, int start, int end)
        {
            return dataIn.Substring(start, end - start);
        }

        #region Constants

        string[] di = {
        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", 
        "A", "B", "C", "D", "E", "F"
        };

        //string premixString = "1wz8rzgiv87708l9oi7ot8l9smdqv5yvzz8tavkyuoi9p3kgrrq7r5p53kchnb5hly8jkfx5hsoo6imx8o5ktczwdst8dooa7r331wkrw8zi8789io89mq5vztvyo93gr755khbhyjf5soixokcws8oar3wr";
        //int premixCount = 17;

        string premixString = "oeVD^yocjsGeXDT`TSjuOXBLNqueHOEruCWLiNRDyZXYb";
        int premixCount = 21;

        #endregion
    }
}
