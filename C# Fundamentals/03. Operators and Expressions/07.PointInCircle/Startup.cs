using System;

namespace _07.PointInCircle
{
    class Startup
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var result = Math.Sqrt(x * x + y * y);

            if (result <= 2)
            {
                Console.WriteLine("yes {0:F2}", result);
            }
            else
            {
                Console.WriteLine("no {0:F2}", result);
            }
        }
    }
}
