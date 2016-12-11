using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GreedyDwarf
{
    class Program
    {
        static void Main()
        {
            var valley = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse).ToArray();
          

            int n = int.Parse(Console.ReadLine());

            var maxCoints = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var pattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse).ToArray();
                int index = 0;
                int pathIndex = 0;
                var currentCoints = 0;
                var used = new bool[valley.Length];

                while (true)
                {
                    if (index < 0 || index > valley.Length - 1)
                    {
                        maxCoints = Math.Max(maxCoints, currentCoints);
                        break;
                    }

                    if (used[index])
                    {
                        maxCoints = Math.Max(maxCoints, currentCoints);
                        break;
                    }

                    currentCoints += valley[index];
                    used[index] = true;

                    index += pattern[pathIndex];

                    pathIndex++;
                    pathIndex %= pattern.Length;
                }

                maxCoints = Math.Max(maxCoints, currentCoints);

            }

            Console.WriteLine(maxCoints);
        }
    }
}
