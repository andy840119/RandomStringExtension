using System;

namespace RandomStringExtension.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Introduce
            // D / a : Digital (0-9)
            // C / c : Upper case / Lower case char (A-z)
            // S / s : Symbol (!@#$%^&*)
            // A / a : Any char and digital ( Upper / Lower )
            //   *   : Any char and digital
            //   !   : And char, digital and symbol

            //Example : AD-57B2
            DisplayExampleRandomString("CC-AAAA");

            //Example : 82463251
            DisplayExampleRandomString("DDDDDDDD");

            //Example : dkgyleba
            DisplayExampleRandomString("aaaaaaaa");

            //Example : 2$#kED3B
            DisplayExampleRandomString("!!!!!!!!");

            //Example : +=--+++=
            DisplayExampleRandomStringWithAcceptSymbol("SSSSSSSS", "+=-");

            //Try yourself
            while (true)
            { 
                var format = Console.ReadLine();

                if (string.IsNullOrEmpty(format))
                    break;

                DisplayExampleRandomString(format);
            }

            void DisplayExampleRandomString(string str)
            {
                Console.WriteLine(@"rnd.NextString(""" + str + @""")");
                Console.WriteLine(rnd.NextString(str));
                Console.WriteLine("======================");
            }

            void DisplayExampleRandomStringWithAcceptSymbol(string str,string acceptSymbol)
            {
                Console.WriteLine(@"rnd.NextString(""" + str + @""",""" + acceptSymbol + @""")");
                Console.WriteLine(rnd.NextString(str, acceptSymbol));
                Console.WriteLine("======================");
            }
        }
    }
}
