using System;
using System.Text;

namespace _23.SeriesOfLetters
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var previousChar = input[0];
            var result = new StringBuilder();


            for (int i = 1; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (previousChar != currentChar)
                {
                    result.Append(previousChar);
                }

                previousChar = currentChar;
            }

            if (previousChar != result[result.Length - 1])
            {
                result.Append(previousChar);
            }

            Console.WriteLine(result);
        }
    }
}
