using System;

namespace _14.BitExchange
{
    public class Startup
    {
        public static void Main()
        {
            var n = uint.Parse(Console.ReadLine());
            uint mask = 1;

            var third = (n & (mask << 3)) >> 3;
            var forth = (n & (mask << 4)) >> 4;
            var fifth = (n & (mask << 5)) >> 5;

            var twenyFourt = (n & (mask << 24)) >> 24;
            var twenyFifth = (n & (mask << 25)) >> 25;
            var twenySixth = (n & (mask << 26)) >> 26;

            // 0 - n & ~(mask << p)
            // 1 - (n | mask << p)

            n = third == 0 ? n & ~(mask << 24) : (n | mask << 24);
            n = forth == 0 ? n & ~(mask << 25) : (n | mask << 25);
            n = fifth == 0 ? n & ~(mask << 26) : (n | mask << 26);
            n = twenyFourt == 0 ? n & ~(mask << 3) : (n | mask << 3);
            n = twenyFifth == 0 ? n & ~(mask << 4) : (n | mask << 4);
            n = twenySixth == 0 ? n & ~(mask << 5) : (n | mask << 5);

            Console.WriteLine(n);
           
        }
    }
}
