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
                var num = int.Parse(Console.ReadLine());
                var str = Convert.ToString(num, 2).PadLeft(30, '0').Substring(0, 30);
                sb.Append(str);
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

            ////Console.WriteLine(maxZeroCount);
            ////Console.WriteLine(maxOnesCount);

            ////onesCount = 1;
            ////zeroCount = 1;
            ////maxOnesCount = 0;
            ////maxZeroCount = 0;
            //for (int i = 0; i < sb.Length - 1; i++)
            //{
            //    if (sb[i] == sb[i + 1])
            //    {
            //        if (sb[i] == '1')
            //        {
            //            onesCount++;
            //        }
            //        else
            //        {
            //            zeroCount++;
            //        }
            //    }
            //    else
            //    {
            //        if (sb[i] == '1')
            //        {
            //            maxOnesCount = Math.Max(maxOnesCount, onesCount);
            //            onesCount = 1;
            //        }
            //        else
            //        {
            //            maxZeroCount = Math.Max(maxZeroCount, zeroCount);
            //            zeroCount = 1;
            //        }
            //    }
            //}

            maxZeroCount = Math.Max(zeroCount, maxZeroCount);
            maxOnesCount = Math.Max(onesCount, maxOnesCount);
            Console.WriteLine(maxZeroCount);
            Console.WriteLine(maxOnesCount);
        }
    }
}
