using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = CalculateFactoriel(2 * n) / (CalculateFactoriel(n + 1) * CalculateFactoriel(n));
            Console.WriteLine(result);
        }

        private static BigInteger CalculateFactoriel(int n)
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
