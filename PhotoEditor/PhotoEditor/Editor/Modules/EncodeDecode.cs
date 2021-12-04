using Sulakore.Protocol;
using System;
using System.Text;

namespace PhotoEditor.Editor.Modules
{
    public class EncodeDecode
    {
        public string EncodeInt32(int value) => Encode(BigEndian.GetBytes, value);
        public string EncodeUInt16(ushort value) => Encode(BigEndian.GetBytes, value);
        protected virtual string Encode<T>(Func<T, byte[]> encoder, T value) => ToString(encoder(value));
        public ushort DecodeUInt16(string value) => Decode(BigEndian.ToUInt16, value);
        public int DecodeInt32(string value) => Decode(BigEndian.ToInt32, value);
        public static string ToString(byte[] data)
        {
            string result = Encoding.Default.GetString(data);
            for (int i = 0; i <= 13; i++)
            {
                result = result.Replace(
                    ((char)i).ToString(), "[" + i + "]");
            }
            return result;
        }
        protected virtual T Decode<T>(Func<byte[], int, T> decoder, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default(T);
            byte[] bytes = HMessage.ToBytes(value);
            return decoder(bytes, 0);
        }
    }
}
