using System;
using System.Numerics;

namespace _06.BinaryToHexadecimal
{
    class Startup
    {
        static void Main()
        {
            var number = Console.ReadLine();

            Console.WriteLine(FromDecimalToHexadecimal(FromBinaryToDecimal(number)));
        }

        private static BigInteger FromBinaryToDecimal(string number)
        {
            BigInteger result = 0;

            foreach (var digit in number)
            {
                result = result * 2 + digit - '0';
            }

            return result;
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
