using System;

namespace _07.SumOf5Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());

            var sum = a + b + c + d + e;

            Console.WriteLine(sum);
        }
    }
}
