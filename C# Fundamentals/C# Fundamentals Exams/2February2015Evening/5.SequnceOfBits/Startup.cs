using System;
using System.Text;

namespace _5.SequnceOfBits
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                sb.Append(Convert.ToString(number, 2).PadLeft(30, '0').Substring(0, 30));
            }

            var maxOneCount = 0;
            var curOneCount = 0;
            var maxZeroCount = 0;
            var curZeroCount = 0;

            foreach (var symbol in sb.ToString())
            {
                if (symbol == '1')
                {
                    curOneCount++;
                }
                else
                {
                    maxOneCount = Math.Max(curOneCount, maxOneCount);
                    curOneCount = 0;
                }

                if (symbol == '0')
                {
                    curZeroCount++;
                }
                else
                {
                    maxZeroCount = Math.Max(curZeroCount, maxZeroCount);
                    curZeroCount = 0;
                }
            }

            maxZeroCount = Math.Max(curZeroCount, maxZeroCount);
            maxOneCount = Math.Max(curOneCount, maxOneCount);

            Console.WriteLine(maxOneCount);
            Console.WriteLine(maxZeroCount);

        }
    }
}
