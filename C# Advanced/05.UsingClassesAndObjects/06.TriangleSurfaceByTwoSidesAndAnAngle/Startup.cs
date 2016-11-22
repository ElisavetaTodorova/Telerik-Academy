using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleSurfaceByTwoSidesAndAnAngle
{
    class Startup
    {
        static void Main()
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            var triangle = new Triangle(firstSide, secondSide, angle);

            Console.WriteLine("{0:F2}", triangle.CalculateSurface());
        }
    }

    class Triangle
    {
        private double firstSide;
        private double secondSide;
        private double angle;

        public Triangle(double firstSide, double secondSide, double angle)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.angle = (angle * Math.PI) / 180;
        }

        public double CalculateSurface()
        {
            var area = (this.firstSide * this.secondSide * Math.Sin(this.angle)) / 2;

            return area;
        }

    }
}
