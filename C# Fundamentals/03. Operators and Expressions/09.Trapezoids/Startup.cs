using System;

namespace _09.Trapezoids
{
    class Startup
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = ((a + b) / 2) * h;

            Console.WriteLine("{0:F7}", area);
        }
    }
}
