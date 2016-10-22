using System;

namespace _04.PrintDesk
{
    public class Startup
    {
        public static void Main()
        {
            var cardSuits = new string[] { "spades", "clubs", "hearts", "diamonds" };
            var cardFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < cardFaces.Length; i++)
            {
                for (int j = 0; j < cardSuits.Length; j++)
                {
                    if (j < cardSuits.Length - 1)
                    {
                        Console.Write("{0} of {1}, ", cardFaces[i], cardSuits[j]);
                    }
                    else
                    {
                        Console.WriteLine("{0} of {1}", cardFaces[i], cardSuits[j]);
                    }

                }
                
            }
        }
    }
}
