using System;

namespace System
{
    public static class RandomStringExtension
    {
        /// <summary>
        /// D / d : Digital (0-9)
        /// C / c : Upper case / Lower case char (A-z)
        /// S / s : Symbol (!@#$%^&*)
        /// A / a : Any char and digital ( Upper / Lower )
        ///   *   : Any char and digital
        ///   !   : And char, digital and symbol
        /// </summary>
        /// <param name="random"></param>
        /// <param name="format"></param>
        /// <param name="acceptSymbol"></param>
        /// <returns></returns>
        public static string NextString(this Random random,string format,string acceptSymbol = null)
        {
            var returnString = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var digitals = "0123456789";
            var symbols = !string.IsNullOrEmpty(acceptSymbol) ? acceptSymbol : "!@#$%^&*_-+=~";

            foreach (var chr in format)
            {
                returnString += createRandomChar(chr);
            }
            return returnString;

            char createRandomChar(char command)
            { 
                switch(command)
                { 
                    case 'D' : case 'd' :
                        return GetSingleCharInString(digitals);
                    case 'C' :
                        return GetSingleCharInString(chars);
                    case 'c' :
                        return GetSingleCharInString(chars.ToLower());
                    case 'S' : case 's' :
                        return GetSingleCharInString(symbols);
                    case 'A' :
                        return GetSingleCharInString(chars + digitals);
                    case 'a' :
                        return GetSingleCharInString(chars.ToLower() + digitals);
                    case '*' :
                        return GetSingleCharInString(chars + chars.ToLower() + digitals + digitals);//Digits shouuld be twice times because char is twice time
                    case '!':
                        return GetSingleCharInString(chars + chars.ToLower() + digitals + digitals + acceptSymbol + acceptSymbol);
                    default :
                        return command;

                }

                char GetSingleCharInString(string str)
                {
                    return str[random.Next(str.Length)];
                }
            }
        }
    }
}
