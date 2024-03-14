using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string decoString = args[0];
            char decoChar = char.Parse(args[1]);
            int decoint = int.Parse(args[2]);

            Console.WriteLine( Decor(decoString, decoChar, decoint));
        }
        private static string Decor ( string s , char dec, int o)
        {
            string deco = new string(dec, o);
            return $"{deco} {s} {deco}";
        }
    }
}
