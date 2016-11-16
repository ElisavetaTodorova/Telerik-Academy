using System;

namespace _01.FillTheMatrix
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            int[,] matrix = new int[n, n];

            switch (type)
            {
                case "a":
                    matrix = GetMatrixOfTypeA(n);
                    break;
                case "b":
                    matrix = GetMatrixOfTypeB(n);
                    break;
                case "c":
                    matrix = GetMatrixOfTypeC(n);
                    break;
                case "d":
                    matrix = GetSpiralMatrix(n);
                    break;
            }

            PrintMatrix(matrix);
        }

        private static int[,] GetMatrixOfTypeA(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i + 1 + (n * j);
                }
            }
            return matrix;
        }

        private static int[,] GetMatrixOfTypeB(int n)
        {
            int[,] matrix = new int[n, n];

            int currentNumber = 1;

            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = currentNumber++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = currentNumber++;
                    }
                }
            }
            return matrix;
        }

        private static int[,] GetMatrixOfTypeC(int n)
        {
            int[,] matrix = new int[n, n];
            int count = 0;
            int currentNumber = 1;

            for (int i = 0; i < n * 2; i++)
            {
                if (i < n)
                {
                    int startRow = n - 1 - count;
                    int startCol = 0;

                    for (int j = 0; j <= count; j++)
                    {
                        matrix[startRow, startCol] = currentNumber++;
                        startRow++;
                        startCol++;
                    }
                    count++;
                }
                else
                {
                    int startRow = 0;
                    int startCol = n - count + 1;
                    for (int j = 0; j < count - 1; j++)
                    {
                        matrix[startRow, startCol] = currentNumber++;
                        startRow++;
                        startCol++;
                    }
                    count--;
                }
            }
           
            return matrix;
        }


        private static int[,] GetSpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int positionX = n / 2; // The middle of the matrix
            int positionY = n % 2 == 0 ? (n / 2) - 1 : (n / 2);


            int direction = 0; // The initial direction is "down"
            int stepsCount = 1; // Perform 1 step in current direction
            int stepPosition = 0; // 0 steps already performed
            int stepChange = 0; // Steps count changes after 2 steps

            for (int i = n * n; i >= 1; i--)
            {
                // Fill the current cell with the current value
                matrix[positionY, positionX] = i;

                // Check for direction / step changes
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepsCount++;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }



                // Move to the next cell in the current direction
                switch (direction)
                {
                    case 0:
                        positionY++;
                        break;
                    case 1:
                        positionX--;
                        break;
                    case 2:
                        positionY--;
                        break;
                    case 3:
                        positionX++;
                        break;
                }
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }

            }
        }
    }
}
