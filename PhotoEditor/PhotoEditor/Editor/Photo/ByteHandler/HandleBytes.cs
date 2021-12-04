using System.Collections.Generic;
namespace PhotoEditor.Editor.Photo.ByteHandler
{
    public class HandleBytes
    {
        public static byte[] Replace(byte[] input, byte[] pattern, byte[] replacement)
        {
            if (pattern.Length == 0)
                return input;
            List<byte> byteList = new List<byte>();
            int index1;
            for (index1 = 0; index1 <= input.Length - pattern.Length; ++index1)
            {
                bool flag = true;
                for (int index2 = 0; index2 < pattern.Length; ++index2)
                {
                    if (input[index1 + index2] != pattern[index2])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    byteList.AddRange(replacement);
                    index1 += pattern.Length - 1;
                }
                else
                    byteList.Add(input[index1]);
            }
            for (; index1 < input.Length; ++index1)
                byteList.Add(input[index1]);
            return byteList.ToArray();
        }
    }
}

