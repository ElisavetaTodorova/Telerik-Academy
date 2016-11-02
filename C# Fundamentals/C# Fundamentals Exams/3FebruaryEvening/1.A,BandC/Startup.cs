using System;
using System.Linq;

namespace _1.A_BandC
{
    class Startup
    {
        static void Main()
        {
            var numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine("{0:F3}", numbers.Average());
        }
    }
}
