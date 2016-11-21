using System;
using System.Numerics;

namespace _03.DecimalToHexadecimal
{
    class Startup
    {
        static void Main(string[] args)
        {
            var number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(FromDecimalToHexadecimal(number));

        }

        private static string FromDecimalToHexadecimal(BigInteger number)
        {
            var result = "";

            while (number > 0)
            {
                var bit = number % 16;

                if (bit > 9)
                {
                    result = (char)(bit + 55) + result;
                }
                else
                {
                    result = bit + result;
                }
                number /= 16;
            }
            return result;
        }
    }
}
