using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInMatrix
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

            int maxCount = 0;
            int currentCount = 1;
            //checking the rows
            for (int i = 0; i < array.GetLength(0); i++)
            {
                currentCount = 1;
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] == array[i, j + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (maxCount < currentCount)
                        {
                            maxCount = currentCount;
                        }

                        currentCount = 1;
                    }
                }
            }
            //by cols
            for (int i = 0; i < array.GetLength(1); i++)
            {
                 currentCount = 1;
                for (int j = 0; j < array.GetLength(0) - 1; j++)
                {
                    if (array[j, i] == array[j + 1, i])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (maxCount < currentCount)
                        {
                            maxCount = currentCount;
                        }

                        currentCount = 1;
                    }
                }
            }
            //diagonal
            string bestString = "";
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    currentCount = 1;
                    for (int row = i, col = j; row < array.GetLength(0) - 1 && col < array.GetLength(1) - 1; row++, col++)
                    {
                        if (array[row, col] == array[row + 1, col + 1])
                        {
                            currentCount++;
                        }
                        else
                        {
                            currentCount = 1;
                            break;
                        }

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            bestString = array[row, col];
                        }
                    }
                }

            }

        }
    }
}
