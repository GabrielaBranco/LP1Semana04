using System;

namespace BetterDecorator
{
    /// <summary>
    /// Adorns the string based on a character chosen by the user, 
    /// this character is displayed the number of times the user entered.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method, where the code is executed.
        /// If the arguments are not specified 
        /// the method Decor is called with premade parameters
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if(args.Length < 3)
            {
                Console.WriteLine(Decor("User did not specify args!", '=', 3));
            }
            else
            {
                string decoString = args[0];
                char decoChar = char.Parse(args[1]);
                int decoint = int.Parse(args[2]);

                Console.WriteLine( Decor(decoString, decoChar, decoint));
            }
        }
        
        /// <summary>
        /// The code takes the string s and decorates with the char dec, that is
        /// shown a number of times defined by the int o
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        private static string Decor ( string s , char dec, int o)
        {
            string deco = new string(dec, o);//(char, number of times it repeats)
            return $"{deco} {s} {deco}";
        }
    }
}
