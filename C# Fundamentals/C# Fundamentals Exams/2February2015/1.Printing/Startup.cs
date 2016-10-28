using System;

namespace _1.Printing
{
    public class Startup
    {
        public static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());

            var totalSheetsOfPaper = n * s;
            var reams = totalSheetsOfPaper / 500;

            var moneyToSafe = reams * p;

            Console.WriteLine("{0:F2}", moneyToSafe);
        }
    }
}
