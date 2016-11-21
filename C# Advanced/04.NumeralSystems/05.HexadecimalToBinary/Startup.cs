using System;
using System.Numerics;

namespace _05.HexadecimalToBinary
{
    class Startup
    {
        static void Main()
        {
            var number = Console.ReadLine();

            Console.WriteLine(FromDecimalToBinary(FromHexadecimlToDecimal(number)));
        }

        private static BigInteger FromHexadecimlToDecimal(string number)
        {
            BigInteger result = 0;


            foreach (var digit in number)
            {
                result = result * 16 + (digit < 64 ? digit - '0' : digit - 55);
            }
            return result;

        }


        private static string FromDecimalToBinary(BigInteger n)
        {
            var result = "";

            while (n > 0)
            {
                var bit = n % 2;
                result = bit + result;
                n /= 2;
            }

            return result.ToString();
        }
    }
}
