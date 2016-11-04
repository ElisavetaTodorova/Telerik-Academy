using System;
namespace _1.BirdsAndFeathers
{
    class Startup
    {
        static void Main()
        {
            var b = double.Parse(Console.ReadLine());
            var f = double.Parse(Console.ReadLine());

            var feathersPerBird = f / b;

            if (b % 2 == 0)
            {
                feathersPerBird *= 123123123123;
            }
            else
            {
                feathersPerBird /= 317;
            }

            Console.WriteLine("{0:F4}", feathersPerBird);
        }
    }
}
