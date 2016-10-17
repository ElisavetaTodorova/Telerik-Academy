using System;

namespace _05.ThirdDigit
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var remainder = (n % 1000) / 100;

            if(remainder == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + remainder);
            }
        }
    }
}
