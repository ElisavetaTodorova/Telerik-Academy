using System;
namespace _08.BinaryShort
{
    class Startup
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(ToShortInBinary(n));
        }
        
        private static string ToShortInBinary(short n)
        {
            var result = "";

            for (int i = 0; i < 16; i++)
            {
                var bit = n & 1;
                result = bit + result;
                n >>= 1;

            }

            return result;
        }
        
    }
}
