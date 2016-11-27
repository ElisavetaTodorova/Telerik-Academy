using System;
using System.Text.RegularExpressions;

namespace _04.Sub_stringInText
{
    class Startup
    {
        static void Main()
        {
            var serachedString = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();

            //  var count = Regex.Matches(Regex.Escape(text), serachedString).Count;
            var count = 0;
            var startIndex = 0;

            while (startIndex < text.Length)
            {
                int currentIndex = text.IndexOf(serachedString, startIndex);

                if (currentIndex != -1)
                {
                    count++;
                    startIndex = currentIndex + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
