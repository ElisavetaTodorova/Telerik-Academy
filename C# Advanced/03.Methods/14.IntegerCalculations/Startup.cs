using System;
using System.Linq;

namespace _14.IntegerCalculations
{
    class Startup
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var max = array.Max();
            var min = array.Min();
            var average = array.Average();
            var sum = array.Sum();
            var product = Product(array);

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("{0:F2}", average);
            Console.WriteLine(sum);
            Console.WriteLine(product);


        }

        private static long Product(int[] array)
        {
            long result = 1;


            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            return result;
        }
    }
}
