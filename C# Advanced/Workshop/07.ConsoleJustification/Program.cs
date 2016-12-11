using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.ConsoleJustification
{
    class Program
    {
        static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var lineWidth = int.Parse(Console.ReadLine());

            var pattern = "\\s+";

            var totalWords = new List<string>();
            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine();
                var words = Regex.Split(input, pattern);

                foreach (var item in words)
                {
                    totalWords.Add(item);
                }
            }

            var result = new StringBuilder();
            var current = new StringBuilder();
            var index = 0;

            while (true)
            {
                if (index > totalWords.Count - 1)
                {
                    break;
                }

                while (true)
                {
                    current.Append(totalWords[index]);

                    index++;

                    if (index > totalWords.Count - 1)
                    {
                        break;
                    }

                    if (current.Length > lineWidth)
                    {
                        index--;
                        current.Length = current.Length - totalWords[index].Length;


                    }
                }
            }


        }
    }
}
