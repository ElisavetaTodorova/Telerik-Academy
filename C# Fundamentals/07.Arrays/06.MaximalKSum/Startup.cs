using System;

namespace _06.MaximalKSum
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            int numbersLength = numbers.Length;
            int maxSum = 0;
            for (int i = 1; i <= k; i++)
            {
                maxSum += numbers[numbersLength - i];
            }

            Console.WriteLine(maxSum);
        }
    }
}
