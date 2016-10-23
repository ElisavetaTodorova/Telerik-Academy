using System;

namespace _12.IndexOfLetters
{
   public class Startup
    {
        public static void Main()
        {
            var word = Console.ReadLine();

            var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (var letter in word)
            {
                Console.WriteLine(Array.IndexOf(letters, letter));
            }
        }
    }
}
