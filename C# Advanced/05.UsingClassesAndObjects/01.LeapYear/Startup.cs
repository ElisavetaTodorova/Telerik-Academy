using System;

namespace _01.LeapYear
{
    class Startup
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            var isLeapYear = DateTime.IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
