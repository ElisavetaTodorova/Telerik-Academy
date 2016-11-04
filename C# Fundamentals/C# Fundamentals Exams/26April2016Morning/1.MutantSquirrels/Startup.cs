using System;

namespace _1.MutantSquirrels
{
    class Startup
    {
        static void Main()
        {
            var t = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
            var n = double.Parse(Console.ReadLine());

            var result = t * b * s * n;

            if (result % 2 == 0)
            {
                result *= 376439;
            }
            else
            {
                result /= 7;
            }

            Console.WriteLine("{0:F3}", result);
        }
    }
}
