using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.ParseTags
{
    class Startup
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var indexes = new Queue<int>();

           // var text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            var oppentingTagIndex = 0;
            var closingTagIndex = 0;
            var openingTag = "<upcase>";
            var closingTag = "</upcase>";

            //finding all the indexes
            while (oppentingTagIndex < text.Length && closingTagIndex < text.Length)
            {
                var curentOpeningTagIndex = text.IndexOf(openingTag, oppentingTagIndex);
                var currentClosingTagIndex = text.IndexOf(closingTag, closingTagIndex);

                if (curentOpeningTagIndex != -1 && currentClosingTagIndex != -1)
                {
                    indexes.Enqueue(curentOpeningTagIndex);
                    indexes.Enqueue(currentClosingTagIndex);

                    oppentingTagIndex = curentOpeningTagIndex + 1;
                    closingTagIndex = currentClosingTagIndex + 1;

                }
                else
                {
                    break;
                }
            }


            var prevousIndex = 0;

            var result = new StringBuilder();

            while (indexes.Count > 0)
            {
                var first = indexes.Dequeue();
                var buforeTage = text.Substring(prevousIndex, first - prevousIndex);

                var upperStartIndex = first + 8;

                var after = indexes.Dequeue();

                var upPart = text.Substring(upperStartIndex, after - upperStartIndex).ToUpper();

                result.Append(buforeTage);
                result.Append(upPart);

                prevousIndex = after + 9;
            }

            if (prevousIndex < text.Length - 1)
            {
                var last = text.Substring(prevousIndex, text.Length - prevousIndex);
                result.Append(last);
            }

            Console.WriteLine(result);

        }
    }
}
