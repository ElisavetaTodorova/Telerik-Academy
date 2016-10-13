using System;

namespace _14.PrinttheASCIITable
{
    class Program
    {
        static void Main()
        {
            for (int i = 33; i < 127; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
