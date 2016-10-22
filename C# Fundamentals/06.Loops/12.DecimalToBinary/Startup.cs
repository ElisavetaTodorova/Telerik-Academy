using System;

namespace _12.DecimalToBinary
{
    public class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(number));
        }

        private static string DecimalToBinary(int number)
        {
            var result = "";
            do
            {
                var currentByte = number % 2;
                result = currentByte + result;
                number /= 2;

            } while (number != 0);
            return result;
        }
    }
}
