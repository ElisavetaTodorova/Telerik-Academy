using System;

namespace _02.BonusScore
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n >= 7 && n <= 9)
            {
                Console.WriteLine(n * 1000);
            }
            else if (n >= 4 && n <= 6)
            {
                Console.WriteLine(n * 100);
            }
            else if (n >= 1 && n <= 3)
            {
                Console.WriteLine(n * 10);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
