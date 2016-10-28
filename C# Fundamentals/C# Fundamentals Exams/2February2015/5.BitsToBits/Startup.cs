using System;
using System.Text;

namespace _5.BitsToBits
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var num = long.Parse(Console.ReadLine());
                sb.Append(Convert.ToString(num, 2).PadLeft(30, '0'));
            }

            int zeroCount = 1;
            int maxZeroCount = 0;
            int onesCount = 1;
            int maxOnesCount = 0;

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == sb[i + 1])
                {
                    if (sb[i] == '1')
                    {
                        onesCount++;
                    }
                    else
                    {
                        zeroCount++;
                    }
                }
                else
                {
                    maxOnesCount = Math.Max(maxOnesCount, onesCount);
                    maxZeroCount = Math.Max(maxZeroCount, zeroCount);

                    onesCount = 1;
                    zeroCount = 1;
                }
            }

            if (sb[sb.Length - 1] == sb[sb.Length - 2] && (zeroCount > maxZeroCount || onesCount > maxOnesCount))
            {
                if (sb[sb.Length - 1] == '1')
                {
                    maxOnesCount++;
                }
                else
                {
                    maxZeroCount++;
                }
            }

            Console.WriteLine(maxZeroCount);
            Console.WriteLine(maxOnesCount);
        }
    }
}
