using System;
using System.Linq;

namespace _2.JoroTheRabbit
{
    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse).ToArray();

            var bestPath = 0;

            for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
            {
                for (int step = 1; step < numbers.Length; step++)
                {
                    int start = startIndex;

                    int next = (start + step);

                    if (next >= numbers.Length)
                    {
                        next = next - numbers.Length;
                    }

                    int current = 1;

                    while (numbers[start] < numbers[next])
                    {
                        current++;
                        start = next;
                        next = (start + step) % numbers.Length;


                    }

                    if (bestPath < current)
                    {
                        bestPath = current;
                    }
                }
            }

            Console.WriteLine(bestPath);
        }
    }
}
