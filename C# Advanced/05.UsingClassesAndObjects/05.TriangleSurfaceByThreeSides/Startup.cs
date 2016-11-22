using System;

namespace _05.TriangleSurfaceByThreeSides
{
    class Startup
    {
        static void Main()
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Console.WriteLine("{0:F2}", triangle.CalculateSurface());
        }
    }

    class Triangle
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public double CalculateSurface()
        {
            var perimeter = (this.firstSide + this.secondSide + this.thirdSide) / 2;

            var area = Math.Sqrt(perimeter * (perimeter - this.firstSide) * (perimeter - this.secondSide) * (perimeter - this.thirdSide));

            return area;
        }

    }
}
