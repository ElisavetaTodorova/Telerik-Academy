using System;

namespace _11.BinaryToDecimal
{
    public class Startup
    {
        public static void Main()
        {
            var binaryNumber = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binaryNumber));
        }

        private static int BinaryToDecimal(string number)
        {
            int result = 0;

            foreach (var digit in number)
            {
                result = result * 2 + digit - 48;
            }
            return result;
        }
    }
}
