using System;

namespace _03.Circle
{
    public class Startup
    {
        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            var perimeter = 2 * Math.PI * r;
            var area = Math.PI * r * r;

            Console.WriteLine("{0:F2} {1:F2}",perimeter, area);
        }
    }
}
