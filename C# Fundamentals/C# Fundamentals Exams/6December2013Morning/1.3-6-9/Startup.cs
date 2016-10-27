using System;

namespace _1._3_6_9
{
    public class Startup
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            double r = 0.0;

            if(b == 3)
            {
                r = a + c;
            }
            else if (b == 6)
            {
                r = a * c;
            }
            else
            {
                r = a % c;
            }

            if(r % 3 == 0)
            {
                Console.WriteLine(r / 3);
            }
            else
            {
                Console.WriteLine(r % 3);
            }

            Console.WriteLine(r);
        }
    }
}
