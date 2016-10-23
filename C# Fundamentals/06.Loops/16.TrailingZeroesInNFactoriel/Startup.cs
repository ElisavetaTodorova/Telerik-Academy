using System;

namespace _16.TrailingZeroesInNFactoriel
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroes(n));

        }

        private static int TrailingZeroes(int factoriel)
        {
            int result = 0;
            int factor = 1;
            int zeroes = factoriel;

            while(zeroes > 0)
            {
                factor *= 5;
                zeroes = factoriel / factor;
                result += zeroes;
            }
            return result;
        }
    }
}
