using System;
using System.Linq;

namespace _02.GetLargestNumber
{
    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(GetLargestNumber(numbers));
        }

        private static int GetLargestNumber(int[] numbers)
        {
            return numbers.Max();
        } 
    }
}
