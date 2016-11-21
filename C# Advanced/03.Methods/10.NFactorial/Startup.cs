using System;
using System.Numerics;

namespace _10.NFactorial
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }

        private static BigInteger Factoriel(int n)
        {
            BigInteger result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
