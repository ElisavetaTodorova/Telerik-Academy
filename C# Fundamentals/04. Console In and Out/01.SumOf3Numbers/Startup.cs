using System;

namespace _01.SumOf3Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var sum = a + b + c;

            Console.WriteLine(sum);

        }
    }
}
