using System;
namespace _06.QuadraticEquation
{
    public class Startup
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var determinante = b * b - (4 * a * c);

            if (determinante < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (determinante == 0)
            {
                var root = (-b) / (2 * a);
                Console.WriteLine("{0:F2}", root);
            }
            else
            {
                var firstRoot = ((-b) + Math.Sqrt(determinante)) / (2 * a);
                var secondRoot = ((-b) - Math.Sqrt(determinante)) / (2 * a);

                if (firstRoot < secondRoot)
                {
                    Console.WriteLine("{0:F2}", firstRoot);
                    Console.WriteLine("{0:F2}", secondRoot);
                }
                else
                {
                    Console.WriteLine("{0:F2}", secondRoot);
                    Console.WriteLine("{0:F2}", firstRoot);
                }
            }
        }
    }
}
