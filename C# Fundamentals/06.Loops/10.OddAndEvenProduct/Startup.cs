using System;
using System.Linq;

namespace _10.OddAndEvenProduct
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ')
                                            .Select(int.Parse)
                                            .ToArray();
            long oddProduct = 1;
            long evenProduct = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= numbers[i];
                }
                else
                {
                    evenProduct *= numbers[i];
                }
            }

            Console.WriteLine(evenProduct == oddProduct ? "yes " + evenProduct : "no " + oddProduct + " " + evenProduct);
        }
    }
}
