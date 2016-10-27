using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DiamondTrolls
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //first line
            Console.WriteLine(new string('.', (n + 1) / 2) + new string('*', n) + new string('.', (n + 1) / 2));

            int outDots = (n * 2 + 1 - 3) / 3;
            int inDots = (n * 2 + 1 - 3) / 3;

            while (outDots * 4 + 3 > n * 2 + 1)
            {
                outDots--;
                inDots--;
            }


            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', outDots) + "*" + new string('.', inDots)
                                    + "*" + new string('.', inDots) + "*" + new string('.', outDots));
                outDots--;
                inDots++;
            }

            Console.WriteLine(new string('*', n * 2 + 1));


            outDots++;
            inDots--;
            //(6 + ((N – 3) / 2) * 3)
            int height = 6 + ((n - 3) / 2) * 3;

            for (int i = 0; i < height - 3 - n / 2; i++)
            {
                Console.WriteLine(new string('.', outDots) + "*" + new string('.', inDots)
                                   + "*" + new string('.', inDots) + "*" + new string('.', outDots));
                outDots++;
                inDots--;
            }

            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
        }
    }
}
