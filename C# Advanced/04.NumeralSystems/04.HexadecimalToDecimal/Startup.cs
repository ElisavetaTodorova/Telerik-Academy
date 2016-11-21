using System;
using System.Numerics;

namespace _04.HexadecimalToDecimal
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numberInHexadecimal = Console.ReadLine();
            Console.WriteLine(FromHexadecimlToDecimal(numberInHexadecimal));

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
    }
}
