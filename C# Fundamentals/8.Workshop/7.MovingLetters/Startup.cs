using System;
using System.Text;

namespace _7.MovingLetters
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var result = new StringBuilder();

            var maxLenght = 0;

            foreach (var word in input)
            {
                if (word.Length > maxLenght)
                {
                    maxLenght = word.Length;
                }
            }

            for (int i = 0; i < maxLenght; i++)
            {
                foreach (var word in input)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[word.Length - 1 - i]);

                    }
                }
            }

            int resultLength = result.Length;

            for (int i = 0; i < result.Length; i++)
            {
                char currentLetter = result[i];

                int x = (currentLetter > 91 ? currentLetter - 96 : currentLetter - 64);
                int positionToInsert = (x + i) % resultLength;

                result.Remove(i, 1);

                result.Insert(positionToInsert, currentLetter);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
