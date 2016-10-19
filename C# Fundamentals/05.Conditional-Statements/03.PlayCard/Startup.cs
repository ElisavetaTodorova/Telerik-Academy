using System;
using System.Collections.Generic;

namespace _03.PlayCard
{
    public class Startup
    {
        public static void Main()
        {
            var card = Console.ReadLine();

            var list = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            var isCardValid = list.Contains(card);

            if (isCardValid)
            {
                Console.WriteLine("yes {0}", card);
            }
            else
            {
                Console.WriteLine("no {0}", card);
            }

        }
    }
}
