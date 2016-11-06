using System;
using System.Linq;

namespace _6.EvenDifferences
{
    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long sum = 0;

            int i = 1;

            while (i < numbers.Length)
            {
                long absSum = Math.Abs(numbers[i] - numbers[i - 1]);

                if (absSum % 2 == 0)
                {
                    i += 2;
                    sum += absSum;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
