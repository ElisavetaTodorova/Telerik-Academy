using System;
using System.Numerics;

namespace _07.OneSystemToAnyOther
{
    class Startup
    {
        static void Main()
        {
            var s = int.Parse(Console.ReadLine());
            var n = Console.ReadLine();
            var d = int.Parse(Console.ReadLine());

            Console.WriteLine(FromDecimalToAny(FromAnyToDecimal(n, s),d));
        }

        private static BigInteger FromAnyToDecimal(string number, int b)
        {
            BigInteger result = 0;

            foreach (var digit in number)
            {
                result = result * b + (digit < 64 ? digit - '0' : digit - 55);
            }

            return result;
        }

        private static string FromDecimalToAny(BigInteger number, int b)
        {
            var result = "";

            while (number > 0)
            {
                var bit = number % b;

                if (bit > 9)
                {
                    result = (char)(bit + 55) + result;
                }
                else
                {
                    result = bit + result;
                }
                number /= b;
            }
            return result;
        }
    }
}
