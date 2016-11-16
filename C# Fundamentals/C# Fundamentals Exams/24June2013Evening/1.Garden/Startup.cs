using System;

namespace _1.Garden
{
    class Startup
    {
        static void Main()
        {

            var tomatoPrice = 0.5;
            var cucumberPrice = 0.4;
            var potatoPrice = 0.25;
            var carrotPrice = 0.6;
            var cabbagePrice = 0.3;
            var beansPrice = 0.4;

            var tomatoAmount = int.Parse(Console.ReadLine());
            var tomatoArea = int.Parse(Console.ReadLine());
            var cucumberAmount = int.Parse(Console.ReadLine());
            var cucumberArea = int.Parse(Console.ReadLine());
            var potatoAmount = int.Parse(Console.ReadLine());
            var potatoArea = int.Parse(Console.ReadLine());
            var carrotAmount = int.Parse(Console.ReadLine());
            var carrotArea = int.Parse(Console.ReadLine());
            var cabbageAmount = int.Parse(Console.ReadLine());
            var cabbageArea = int.Parse(Console.ReadLine());
            var beansAmount = int.Parse(Console.ReadLine());

            var totalCost = tomatoAmount * tomatoPrice + cucumberAmount * cucumberPrice + potatoAmount * potatoPrice +
                           carrotAmount * carrotPrice + cabbageAmount * cabbagePrice + beansAmount * beansPrice;

            var totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

            Console.WriteLine("Total costs: {0:F2}", totalCost);

            if (totalArea > 250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea == 250)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Beans area: {0}", 250 - totalArea);
            }
        }
    }
}
