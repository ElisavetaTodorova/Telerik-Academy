using System;

namespace _01.ExchangeNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} {1}", b, a);
            }
        }
    }
}
