using System;
using System.Linq;
namespace _03.MMSA
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("min={0:F2}", arrayOfNumbers.Min());
            Console.WriteLine("max={0:F2}", arrayOfNumbers.Max());
            Console.WriteLine("sum={0:F2}", arrayOfNumbers.Sum());
            Console.WriteLine("avrg={0:F2}", arrayOfNumbers.Average());

        }
    }
}
