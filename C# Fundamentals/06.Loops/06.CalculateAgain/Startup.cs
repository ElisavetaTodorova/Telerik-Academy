using System;
using System.Numerics;

namespace _06.CalculateAgain
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;
            int j = 2;
            for (int i = 2; i <= n || j <= k; i++, j++)
            {
                if (i <= n)
                {
                    nFactoriel *= i;
                }

                if (j <= k)
                {
                    kFactoriel *= j;
                }
            }

            Console.WriteLine(nFactoriel / kFactoriel);
        }
    }
}
