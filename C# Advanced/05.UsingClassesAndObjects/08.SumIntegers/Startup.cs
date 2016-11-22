using System;
using System.Linq;

namespace _08.SumIntegers
{
    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
