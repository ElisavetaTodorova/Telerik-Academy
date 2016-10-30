using System;

namespace _4.Cube3D
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(':', n));

            var verticaLinesCount = 0;

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('|', verticaLinesCount) + ":");
                verticaLinesCount++;
            }

            Console.WriteLine(new string(':', n) + new string('|', verticaLinesCount) + ":");

            var spacesCount = 1;
            verticaLinesCount--;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string(' ', spacesCount) + ":" + new string('-', n - 2) + ":" + new string('|', verticaLinesCount) + ":");
                verticaLinesCount--;
                spacesCount++;
            }

            Console.WriteLine(new string(' ', spacesCount) + new string(':', n));
        }
    }
}
