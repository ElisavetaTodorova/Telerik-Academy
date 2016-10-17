using System;

namespace _08.NumbersFrom1ToN
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
