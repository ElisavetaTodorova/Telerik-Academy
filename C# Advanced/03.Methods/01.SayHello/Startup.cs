using System;

namespace _01.SayHello
{
    class Startup
    {
        static void Main()
        {
            var name = Console.ReadLine();
            SayHello(name);
        }

        private static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
