using System;
using System.Linq;
namespace _1.ThreeNumbers
{
    class Startup
    {
        static void Main()
        {
            var arr = new long[3];

            for (int i = 0; i < 3; i++)
            {
                long number = long.Parse(Console.ReadLine());
                arr[i] = number;
            }

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine("{0:F2}", arr.Average());
        }

    }
}
