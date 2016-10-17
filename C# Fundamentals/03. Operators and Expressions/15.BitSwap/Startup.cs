using System;
namespace _15.BitSwap
{
    public class Startup
    {
        public static void Main()
        {
            var n = uint.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var q = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            uint mask = 1;
            for (int i = 0; i < k; i++)
            {
                var currentPBit = (n & (mask << p)) >> p;
                var currentQBit = (n & (mask << q)) >> q;
                
                if (currentPBit == 0)
                {
                    n &= ~(mask << q);
                }
                else
                {
                    n |= (n | mask << q);
                }

                if (currentQBit == 0)
                {
                    n &= ~(mask << p);
                }
                else
                {
                    n = (n | mask << p);
                }

                p++;
                q++;
            }
            Console.WriteLine(n);

        }
    }
}
