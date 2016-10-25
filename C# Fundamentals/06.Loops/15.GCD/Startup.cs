using System;
using System.Linq;

namespace _15.GCD
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];
            Console.WriteLine(GCD(firstNumber, secondNumber));
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
                return b;
            else
                return a;
        }
    }
}
