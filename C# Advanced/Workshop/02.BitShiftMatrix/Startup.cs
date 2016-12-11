using System;
using System.Linq;
using System.Numerics;

namespace _02.BitShiftMatrix
{
    class Startup
    {
        static void Main()
        {
            int matrixRow = int.Parse(Console.ReadLine());
            int matrixCol = int.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());

            var moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var matrix = new BigInteger[matrixRow, matrixCol];
            FillMatrix(matrix, matrixRow, matrixCol);

            var coef = Math.Max(matrixCol, matrixRow);

            var strartRow = matrixRow - 1;
            var startCol = 0;

            BigInteger sum = 0;

            foreach (var move in moves)
            {
                int currentRow = move / coef;
                int currentCol = move % coef;

                if (currentCol > startCol)
                {
                    for (int i = startCol; i <= currentCol; i++)
                    {
                        sum += matrix[strartRow, i];
                        matrix[strartRow, i] = 0;
                    }
                }
                else
                {
                    for (int i = startCol; i >= currentCol; i--)
                    {
                        sum += matrix[strartRow, i];
                        matrix[strartRow, i] = 0;
                    }
                }

                if (currentRow > strartRow)
                {
                    for (int i = strartRow; i <= currentRow; i++)
                    {
                        sum += matrix[i, currentCol];
                        matrix[i, currentCol] = 0;
                    }
                }
                else
                {
                    for (int i = strartRow; i >= currentRow; i--)
                    {
                        sum += matrix[i, currentCol];
                        matrix[i, currentCol] = 0;
                    }
                }

                strartRow = currentRow;
                startCol = currentCol;
            }

            Console.WriteLine(sum);


        }

        private static void FillMatrix(BigInteger[,] matrix, int row, int col)
        {
            BigInteger one = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = one << (row - 1 - i + j);
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
