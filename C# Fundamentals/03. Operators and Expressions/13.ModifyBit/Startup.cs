using System;

namespace _13.ModifyBit
{
    public class Startup
    {
        public static void Main()
        {
            var n = ulong.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            ulong mask = 1;
            

            if (b == 0)
            {

                Console.WriteLine(n & ~(mask << p));
            }
            else
            {
                Console.WriteLine(n | mask << p);
            }
        }

    }
}

