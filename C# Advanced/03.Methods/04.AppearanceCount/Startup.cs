using System;
using System.Linq;
namespace _04.AppearanceCount
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int searchedNimber = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCount(numbers, searchedNimber));
        }

        private static int AppearanceCount(int[] numbers, int searchedNumber)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (searchedNumber == numbers[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
