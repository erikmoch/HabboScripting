using Ionic.Zlib1918;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Editor.Modules
{
    public static class CompressDecompress
    {
        /*   public static string Compress(Form1 _MainFrm, string input)
           {
               try
               {
                   byte[] bytes = ZlibStream.CompressBuffer(Encoding.GetEncoding(1252).GetBytes(input));
                   string str = Encoding.GetEncoding(1252).GetString(bytes);
                   int num = 0;
                   if (_MainFrm.rad_mode_photo)
                       num = _MainFrm.photopreviewHeader;
                   else if (_MainFrm.rad_mode_thumbnail)
                       num = _MainFrm.roomthumbnailHeader;
                   return ((object)_MainFrm.GetPacket("{l}{u:" + (object)num + "}{i:" + (object)bytes.Length + "}" + str, (HDestination)1)).ToString();
               }
               catch (Exception ex)
               {
                   Console.WriteLine(string.Format("An error occurred: {0}", (object)ex.Message), true);
                   return "";
               }
           }

           public static string Decompress(Form1 _MainFrm, string input)
           {
               byte[] bytes = (byte[])null;
               try
               {
                   EvaWirePacket hmessage = new EvaWirePacket(input);
                   int num = hmessage.ReadInteger();
                   bytes = hmessage.ReadBytes(num);
                   Encoding.Convert(Encoding.Default, Encoding.Unicode, bytes);
                   return Encoding.Default.GetString(ZlibStream.UncompressBuffer(bytes));
               }
               catch (Exception ex)
               {
                   if (bytes != null && bytes.Length >= 2)
                       Console.WriteLine(string.Format("An error occurred: {0} - Header bytes: ", (object)ex.Message) + Encoding.GetEncoding(1252).GetString(bytes).Substring(0, 2).ToHex(), true);
                   else
                       Console.WriteLine(string.Format("An error occurred: {0}", (object)ex.Message), true);
                   return "";
               }
           }

         */
        public static string Compress(Form1 _MainFrm, string input)
        {
            EncodeDecode encodeDecode = new EncodeDecode();
            try
            {
                byte[] numArray1 = ZlibStream.CompressBuffer(Encoding.GetEncoding(1252).GetBytes(input));
                byte[] bytes1 = Encoding.GetEncoding(1252).GetBytes(ReplaceSpecialChars.EscapedToNormalChars(_MainFrm, encodeDecode.EncodeInt32(numArray1.Length)));
                byte[] numArray2 = new byte[numArray1.Length + bytes1.Length];
                numArray1.CopyTo((Array)numArray2, bytes1.Length);
                int index1 = 0;
                foreach (byte num in bytes1)
                {
                    numArray2[index1] = num;
                    ++index1;
                }
                int num1 = 0;
                if (_MainFrm.thumbnailModeToolStripMenuItem.Checked)
                    num1 = _MainFrm.roomthumbnailHeader;
                else
                    num1 = _MainFrm.photopreviewHeader;
                byte[] bytes2 = Encoding.GetEncoding(1252).GetBytes(ReplaceSpecialChars.EscapedToNormalChars(_MainFrm, encodeDecode.EncodeUInt16((ushort)num1)));
                byte[] numArray3 = new byte[numArray2.Length + bytes2.Length];
                numArray2.CopyTo((Array)numArray3, bytes2.Length);
                int index2 = 0;
                foreach (byte num2 in bytes2)
                {
                    numArray3[index2] = num2;
                    ++index2;
                }
                byte[] bytes3 = Encoding.GetEncoding(1252).GetBytes(ReplaceSpecialChars.EscapedToNormalChars(_MainFrm, encodeDecode.EncodeInt32(numArray3.Length)));
                byte[] bytes4 = new byte[numArray3.Length + bytes3.Length];
                numArray3.CopyTo((Array)bytes4, bytes3.Length);
                int index3 = 0;
                foreach (byte num2 in bytes3)
                {
                    bytes4[index3] = num2;
                    ++index3;
                }
                return Encoding.GetEncoding(1252).GetString(Encoding.GetEncoding(1252).GetBytes(ReplaceSpecialChars.NormalToEscapedChars(_MainFrm, Encoding.GetEncoding(1252).GetString(bytes4))));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("An error occurred: {0}", (object)ex.Message), true);
                return "";
            }
        }

        public static string Decompress(Form1 _MainFrm, string input)
        {
            EncodeDecode encodeDecode = new EncodeDecode();
            try
            {
                byte[] bytes1 = Encoding.GetEncoding(1252).GetBytes(ReplaceSpecialChars.EscapedToNormalChars(_MainFrm, input));
                byte[] numArray = new byte[bytes1.Length - 10];
                Buffer.BlockCopy((Array)bytes1, 10, (Array)numArray, 0, numArray.Length);
                byte[] bytes2 = new byte[2];
                Buffer.BlockCopy((Array)bytes1, 4, (Array)bytes2, 0, 2);
                int num = (int)encodeDecode.DecodeUInt16(Encoding.GetEncoding(1252).GetString(bytes2));
                return Encoding.GetEncoding(1252).GetString(ZlibStream.UncompressBuffer(numArray));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("An error occurred: {0}", (object)ex.Message), true);
                return "";
            }
        }

        public static string ByteArrayToString(byte[] ba, int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
            for (int index = start; index <= end; ++index)
                stringBuilder.AppendFormat("{0:x2} ", (object)ba[index]);
            return stringBuilder.ToString();
        }
    }
}
