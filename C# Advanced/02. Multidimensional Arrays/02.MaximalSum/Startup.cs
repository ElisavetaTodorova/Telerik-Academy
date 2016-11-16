using System;
using System.Linq;

namespace _02.MaximalSum
{
    class Startup
    {
        static void Main()
        {
            var dimentions = Console.ReadLine().Split(' ')
                                               .Select(int.Parse)
                                               .ToArray();
            int m = dimentions[0];
            int n = dimentions[1];

            var array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                var currentNumbers = Console.ReadLine().Split(' ')
                                               .Select(int.Parse)
                                               .ToArray();

                for (int j = 0; j < n; j++)
                {
                    array[i, j] = currentNumbers[j];
                }
            }

            int maxSum = int.MinValue;
            for (int row = 0; row <= m - 3; row++)
            {
                for (int col = 0; col <= n - 3; col++)
                {
                   var currentSum = array[row, col] + array[row, col + 1] + array[row, col + 2]
                        + array[row + 1, col] + array[row + 1, col + 1] + array[row + 1, col + 2]
                        + array[row + 2, col] + array[row + 2, col + 1] + array[row + 2, col + 2];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                }


            }

            Console.WriteLine(maxSum);
        }
    }
}
