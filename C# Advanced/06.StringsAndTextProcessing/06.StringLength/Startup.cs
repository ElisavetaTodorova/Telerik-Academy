using System;

namespace _06.StringLength
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
