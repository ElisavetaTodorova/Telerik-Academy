using System;

namespace _13.DecimalToHex
{
    public class Startup
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(n));
        }

        private static string DecimalToHex(long number)
        {
            string result = "";
            var chars = "0123456789ABCDEF".ToCharArray();

            do
            {
                var current = chars[number % 16];
                result = current + result;
                number /= 16;
            } while (number != 0);

            return result;
        }
    }
}
