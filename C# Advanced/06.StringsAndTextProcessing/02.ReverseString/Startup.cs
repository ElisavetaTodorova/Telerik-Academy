using System;

namespace _02.ReverseString
{
    class Startup
    {
        static void Main()
        {
            var str = Console.ReadLine();

            var result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            Console.WriteLine(result);
        }
    }
}
