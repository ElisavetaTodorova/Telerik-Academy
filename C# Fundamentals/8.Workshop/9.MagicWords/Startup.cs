using System;
using System.Collections.Generic;
using System.Text;


namespace _9.MagicWords
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<string>();
            int maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();

                list.Add(word);

                maxLength = Math.Max(maxLength, word.Length);
            }

            for (int i = 0; i < n; i++)
            {
                var word = list[i];
                int newIndex = word.Length % (n + 1);

                list.Insert(newIndex, word);

                if (newIndex < i)
                {
                    list.RemoveAt(i + 1);
                }
                else
                {
                    list.RemoveAt(i);
                }

            }

            var result = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    var word = list[j];
                    if (i < word.Length)
                    {
                       result.Append(word[i]);
                    }
                }

            }

            Console.WriteLine(result.ToString());
        }
    }
}
