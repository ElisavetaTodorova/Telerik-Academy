using System;
using System.Linq;

namespace _06.FirstLargerThanNeighbours
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(LargerThanNeighbours(numbers));
        }

        private static int LargerThanNeighbours(int[] numbers)
        {
            int index = -1;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    return i;
                }
            }

            return index;
        }
    }
}
