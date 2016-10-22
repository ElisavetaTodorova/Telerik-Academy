using System;
using System.Numerics;

namespace _07.Calculate3_
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            BigInteger nFactoriel = CalculateFactoriel(n);
            BigInteger kFactoriel = CalculateFactoriel(k);
            BigInteger nMinusKFactoriel = (CalculateFactoriel(n - k));
            BigInteger result = nFactoriel / (kFactoriel * nMinusKFactoriel);

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
