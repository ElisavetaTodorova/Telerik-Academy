using System;

namespace _1.Money
{
    public class Startup
    {
        public static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());

            var totalSheets = n * s;
            var reams = totalSheets / 400;

            var totalMoney = reams * p;

            Console.WriteLine("{0:F3}", totalMoney); 
        }
    }
}
