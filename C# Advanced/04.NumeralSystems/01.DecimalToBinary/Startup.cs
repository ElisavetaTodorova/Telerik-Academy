using System;
using System.Numerics;
using System.Text;
namespace _01.DecimalToBinary
{
    class Startup
    {
        static void Main()
        {
            var n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(FromDecimalToBinary(n));
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
