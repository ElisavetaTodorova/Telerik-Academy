using System;

namespace _4.Cube
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n - 1) + new string(':', n));
            Console.WriteLine(new string(' ', n - 2) + ":" + new string('/', n - 2) + "::");


            int xCount = 1;
            int spaceCount = n - 3;
            int slashCount = n - 2;
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string(' ', spaceCount) + ":" + new string('/', slashCount) + ":" + new string('X', xCount) + ":");
                xCount++;
                spaceCount--;
            }

            Console.WriteLine(new string(':', n) + new string('X', xCount) + ":");

            for (int i = 0; i < n - 2; i++)
            {
                xCount--;
                Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('X', xCount) + ":");
            }

            Console.WriteLine(new string(':', n));
        }
    }
}
