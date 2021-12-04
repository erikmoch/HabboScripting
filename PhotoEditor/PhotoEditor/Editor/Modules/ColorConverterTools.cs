using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Editor.Modules
{
    public static class ColorConverterTools
    {
        private static Random random = new Random();
        public static Color InvertMeAColour(Color ColourToInvert) => Color.FromArgb((int)~ColourToInvert.R, (int)~ColourToInvert.G, (int)~ColourToInvert.B);    
        public static Color GetRandomColor() => Color.FromArgb(ColorConverterTools.random.Next(0, (int)byte.MaxValue), ColorConverterTools.random.Next(0, (int)byte.MaxValue), ColorConverterTools.random.Next(0, (int)byte.MaxValue));
        public static Color AccessToColor(int accesscode) => ColorTranslator.FromHtml(string.Format("#{0}", (object)Convert.ToInt32(accesscode).ToString("X").PadLeft(6, '0')));

        public static int ColorToAccess(Color color) => Convert.ToInt32(ColorConverterTools.ColorToHex(color), 16);

        public static string ColorToHex(Color color)
        {
            byte num = color.R;
            string str1 = num.ToString("X2");
            num = color.G;
            string str2 = num.ToString("X2");
            num = color.B;
            string str3 = num.ToString("X2");
            return str1 + str2 + str3;
        }

    }
}
