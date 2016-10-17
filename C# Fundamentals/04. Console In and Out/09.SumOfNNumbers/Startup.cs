using System;

namespace _09.SumOfNNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
