using System;

namespace _10.PointCircleRectangle
{
    class Startup
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var valueToBeInTheCircle = Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)));
            bool inCircle = valueToBeInTheCircle <= 1.5;

            bool inRectangle = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);
            Console.WriteLine("{0} circle {1} rectangle", inCircle ? "inside" : "outside", inRectangle ? "inside" : "outside");
        }
    }
}
