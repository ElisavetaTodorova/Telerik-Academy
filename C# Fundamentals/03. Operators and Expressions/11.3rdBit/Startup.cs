using System;

namespace _11._3rdBit
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var thirdBit = (n & (1 << 3)) >> 3;
            Console.WriteLine(thirdBit);
        }
    }
}
