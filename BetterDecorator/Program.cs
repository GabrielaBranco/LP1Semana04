using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Main method, where the code is executed
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string decoString = args[0];
            char decoChar = char.Parse(args[1]);
            int decoint = int.Parse(args[2]);

            Console.WriteLine( Decor(decoString, decoChar, decoint));
        }
        /// <summary>
        /// Adorns the string based on a character chosen by the user, 
        /// this character is displayed the number of times the user entered.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        private static string Decor ( string s , char dec, int o)
        {
            string deco = new string(dec, o); // (char, number of times it repeats)
            return $"{deco} {s} {deco}";
        }
    }
}
