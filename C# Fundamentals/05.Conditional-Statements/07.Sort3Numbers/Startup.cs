using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sort3Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            numbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
