using System;

namespace _04.TriangleSurfaceBySideAndAltitude
{
    class Startup
    {
        static void Main()
        {
            var sideLength = double.Parse(Console.ReadLine());
            var altitude = double.Parse(Console.ReadLine());

            var triangle = new Triangle(sideLength, altitude);

            Console.WriteLine("{0:F2}", triangle.CalculateSurface());
        }

        
    }

    class Triangle
    {
        private double sideLength;
        private double altitude;

        public Triangle(double sideLength, double altitude)
        {
            this.sideLength = sideLength;
            this.altitude = altitude;
        }

        public double CalculateSurface()
        {
            return (sideLength * altitude) / 2;
        }
    }
}
