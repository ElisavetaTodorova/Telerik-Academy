using System;

namespace _04.NumberComparer
{
    public class Startup
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine(a > b ? a : b);
        }
    }
}
