using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class Startup
    {
        static void Main()
        {
           
            var word = Console.ReadLine();
            var input = Console.ReadLine();

            word = " " + word + " ";

            var sentenses = input.Split('.');

            var result = new List<string>();

            foreach (var sentence in sentenses)
            {
                var index = sentence.IndexOf(word);

                if (index != -1)
                {
                    result.Add(sentence);
                }
            }

            Console.WriteLine(string.Join(".", result) + ".");
        }
    }
}
