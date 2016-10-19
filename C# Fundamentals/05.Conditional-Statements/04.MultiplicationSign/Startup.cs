using System;

namespace _04.MultiplicationSign
{
    public class Startup
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var product = a * b * c;

            if (product == 0)
            {
                Console.WriteLine(0);
            }
            else if (product < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
