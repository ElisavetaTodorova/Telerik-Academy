using System;

namespace _04.Rectangles
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var area = width * height;
            var perimeter = 2 * width + 2 * height;

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);

        }
    }
}
