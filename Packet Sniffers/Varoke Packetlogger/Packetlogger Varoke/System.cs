using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packetlogger_Varoke
{
    class GeneralSystem
    {
        public static bool IsValidString(string inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
            {
                return false;
            }

            for (int i = 0; i < inputStr.Length; i++)
            {
                string s = inputStr[i].ToString();
                if (s == "." || s == "," || s == ";" || s == ":" || s == "<" || s == ">" || s == "@" || s == @"\" || s == "/")
                {
                    return true;
                }
                else if (!(IsLetter(s)))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidInt(string inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
            {
                return false;
            }

            for (int i = 0; i < inputStr.Length; i++)
            {
                string s = inputStr[i].ToString();
                if (!(char.IsNumber(inputStr[i])))
                {
                    return false;
                }
            }

            return true;
        }


        public static bool IsValidName(string inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
            {
                return false;
            }

            for (int i = 0; i < inputStr.Length; i++)
            {
                string s = inputStr[i].ToString();
                if (s == "." || s == "," || s == ";" || s == ":" || s == "<" || s == ">" || s == "@" || s == @"\" || s == "/" || s == "#")
                {
                    return true;
                }
                else if (!(IsLetter(s)) && !(char.IsNumber(inputStr[i])))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsLetter(string s)
        {
            s = s.ToLower();
            if (s == "a" || s == "b" || s == "c" || s == "d" || s == "e" || s == "f" || s == "g"
                 || s == "h" || s == "i" || s == "j" || s == "k" || s == "l" || s == "m" || s == "n" || s == "ñ"
                 || s == "o" || s == "p" || s == "q" || s == "r" || s == "s" || s == "t" || s == "u" || s == "v"
                 || s == "w" || s == "x" || s == "y" || s == "z" || s == "¡" || s == "!" || s == "¿" || s == "?" || s == "á"
                 || s == "é" || s == "í" || s == "ó" || s == "ú" || s == "|" || s == "#" || s == "-" || s == "_" ||
                    s == "[" || s == " " || s == "]")
                return true;
            else
                return false;
        }
    }
}
