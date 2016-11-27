using System;
using System.Text;

namespace _10.UnicodeCharacters
{
    class Startup
    {
        static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (var item in str)
            {
                result.Append(GetEscapeSequence(item));
            }

            Console.WriteLine(result);

        }

        private static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
