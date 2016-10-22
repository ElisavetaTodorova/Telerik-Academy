using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Calculate_
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());

            double sum = 1.0;

            for (int i = 1; i <= n; i++)
            {
                sum += CalculateFactoriel(i) / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}",sum);

        }

        private static long CalculateFactoriel(int n)
        {
            long result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
