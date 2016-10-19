using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BiggestOf3
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                var number = double.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine(numbers.Max());
        }
    }
}
