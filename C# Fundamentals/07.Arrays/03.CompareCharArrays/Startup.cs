using System;

namespace _03.CompareCharArrays
{
    public class Startup
    {
        public static void Main()
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();

            int value = firstString.CompareTo(secondString);

            if (value > 0)
            {
                Console.WriteLine(">");
            }
            else if (value < 0)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
            
        }
    }
}
