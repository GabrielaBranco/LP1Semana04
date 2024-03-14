using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence:");
            string numberInput = Console.ReadLine();
            int n = int.Parse(numberInput);

            Console.WriteLine(GetSpecial(n));
        }

        private static int GetSpecial(int n)
        {
            int result;

            if (n == 0)
            {
                result = 0;
            }
            else if (n == 1)
            {
                result = 1;
            }
            else
            {
                result = GetSpecial(n - 1) +  2 * GetSpecial(n - 2);
            }

            return result;
        }
    }
}
