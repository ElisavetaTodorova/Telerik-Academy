using System;

namespace _14.HexToDecimal
{
    public class Startup
    {
        public static void Main()
        {
            var numberInHex = Console.ReadLine();
            Console.WriteLine(HexToDecimal(numberInHex));

        }

        private static long HexToDecimal(string number)
        {
            long result = 0;

            foreach (var digit in number)
            {
                result = result * 16 + digit - (digit < 65 ? 48 : 55);

            }
            return result;
        }
    }
}
