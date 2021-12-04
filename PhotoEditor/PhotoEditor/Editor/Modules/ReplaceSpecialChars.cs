using PhotoEditor.Editor.Photo.ByteHandler;
using System;
using System.Text;

namespace PhotoEditor.Editor.Modules
{
    public static class ReplaceSpecialChars
    {
        public static string EscapedToNormalChars(Form1 _MainFrm, string input)
        {
            try
            {
                return Encoding.GetEncoding(1252).GetString(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(Encoding.GetEncoding(1252).GetBytes(input), new byte[3]
                {
          (byte) 91,
          (byte) 48,
          (byte) 93
                }, new byte[1]), new byte[3]
                {
          (byte) 91,
          (byte) 49,
          (byte) 93
                }, new byte[1] { (byte)1 }), new byte[3]
                {
          (byte) 91,
          (byte) 50,
          (byte) 93
                }, new byte[1] { (byte)2 }), new byte[3]
                {
          (byte) 91,
          (byte) 51,
          (byte) 93
                }, new byte[1] { (byte)3 }), new byte[3]
                {
          (byte) 91,
          (byte) 52,
          (byte) 93
                }, new byte[1] { (byte)4 }), new byte[3]
                {
          (byte) 91,
          (byte) 53,
          (byte) 93
                }, new byte[1] { (byte)5 }), new byte[3]
                {
          (byte) 91,
          (byte) 54,
          (byte) 93
                }, new byte[1] { (byte)6 }), new byte[3]
                {
          (byte) 91,
          (byte) 55,
          (byte) 93
                }, new byte[1] { (byte)7 }), new byte[3]
                {
          (byte) 91,
          (byte) 56,
          (byte) 93
                }, new byte[1] { (byte)8 }), new byte[3]
                {
          (byte) 91,
          (byte) 57,
          (byte) 93
                }, new byte[1] { (byte)9 }), new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 48,
          (byte) 93
                }, new byte[1] { (byte)10 }), new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 49,
          (byte) 93
                }, new byte[1] { (byte)11 }), new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 50,
          (byte) 93
                }, new byte[1] { (byte)12 }), new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 51,
          (byte) 93
                }, new byte[1] { (byte)13 }));
            }
            catch (Exception ex)
            {
                 Console.WriteLine(string.Format("An error occurred: {0}", (object)ex.Message), true);
                return "";
            }
        }

        public static string NormalToEscapedChars(Form1 _MainFrm, string input)
        {
            try
            {
                return Encoding.GetEncoding(1252).GetString(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(HandleBytes.Replace(Encoding.GetEncoding(1252).GetBytes(input), new byte[1], new byte[3]
                {
          (byte) 91,
          (byte) 48,
          (byte) 93
                }), new byte[1] { (byte)1 }, new byte[3]
                {
          (byte) 91,
          (byte) 49,
          (byte) 93
                }), new byte[1] { (byte)2 }, new byte[3]
                {
          (byte) 91,
          (byte) 50,
          (byte) 93
                }), new byte[1] { (byte)3 }, new byte[3]
                {
          (byte) 91,
          (byte) 51,
          (byte) 93
                }), new byte[1] { (byte)4 }, new byte[3]
                {
          (byte) 91,
          (byte) 52,
          (byte) 93
                }), new byte[1] { (byte)5 }, new byte[3]
                {
          (byte) 91,
          (byte) 53,
          (byte) 93
                }), new byte[1] { (byte)6 }, new byte[3]
                {
          (byte) 91,
          (byte) 54,
          (byte) 93
                }), new byte[1] { (byte)7 }, new byte[3]
                {
          (byte) 91,
          (byte) 55,
          (byte) 93
                }), new byte[1] { (byte)8 }, new byte[3]
                {
          (byte) 91,
          (byte) 56,
          (byte) 93
                }), new byte[1] { (byte)9 }, new byte[3]
                {
          (byte) 91,
          (byte) 57,
          (byte) 93
                }), new byte[1] { (byte)10 }, new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 48,
          (byte) 93
                }), new byte[1] { (byte)11 }, new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 49,
          (byte) 93
                }), new byte[1] { (byte)12 }, new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 50,
          (byte) 93
                }), new byte[1] { (byte)13 }, new byte[4]
                {
          (byte) 91,
          (byte) 49,
          (byte) 51,
          (byte) 93
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("An error occurred: {0}", (object)ex.Message), true);
                return "";
            }
        }
    }
}
