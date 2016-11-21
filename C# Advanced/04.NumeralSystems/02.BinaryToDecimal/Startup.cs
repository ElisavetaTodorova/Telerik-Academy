using System;
using System.Numerics;

namespace _02.BinaryToDecimal
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numberInBinary = Console.ReadLine();
            Console.WriteLine(FromBinaryToDecimal(numberInBinary));
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
    }
}
