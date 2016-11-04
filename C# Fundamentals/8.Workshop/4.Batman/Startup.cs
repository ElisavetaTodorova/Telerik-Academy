using System;

namespace _4.Batman
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            int spaces = 0;
            int charsCount = n;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string(' ', spaces) + new string(c, charsCount) + new string(' ', n) + new string(c, charsCount));
                spaces++;
                charsCount--;
            }

            Console.WriteLine(new string(' ', spaces) + new string(c, charsCount) + new string(' ', (n - 3) / 2) + c + " " + c + new string(' ', (n - 3) / 2) + new string(c, charsCount));

            spaces++;
            charsCount--;

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine(new string(' ', spaces) + new string(c, 2 * charsCount + n));
            }

            spaces = n + 1;
            charsCount = n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', spaces) + new string(c,charsCount));
                charsCount -= 2;
                spaces++;
            }
        }
    }
}
