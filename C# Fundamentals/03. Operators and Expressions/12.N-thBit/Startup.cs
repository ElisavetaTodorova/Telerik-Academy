using System;

namespace _12.N_thBit
{
    public class Startup
    {
        public static void Main()
        {
            var p = long.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var nthBit = (p & (1 << n)) >> n;

            Console.WriteLine(nthBit);
        }
    }
}
