using System;

namespace System
{
    public static class RandomStringExtension
    {
        /// <summary>
        /// D / a : Digital (0-9)
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
            return "Hello";

            char createRandomChar(char command)
            { 
                switch(command)
                { 
                    case 'A':
                        return 
                        
                }
            }
        }
    }
}
