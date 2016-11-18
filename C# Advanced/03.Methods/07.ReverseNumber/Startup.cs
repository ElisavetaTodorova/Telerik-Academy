using System;
namespace _07.ReverseNumber
{
    class Startup
    {
        static void Main()
        {
            var number = Console.ReadLine().ToCharArray();

            Array.Reverse(number);

            Console.WriteLine(new string(number));
        }
    }
}
