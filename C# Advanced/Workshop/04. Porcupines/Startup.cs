using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Porcupines
{
    class Startup
    {
        static int[][] terrain;
        static int baseRowCount;
        static int porcupinePoints;

        static void Main()
        {
            //reading input
            int baseColumCount = int.Parse(Console.ReadLine());
            baseRowCount = int.Parse(Console.ReadLine());
            var porcupineCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rabbitCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            terrain = new int[baseRowCount][];

            //fill terrain
            FillTarrain(baseRowCount, baseColumCount);
            porcupinePoints = 0;
            var rabbitPoits = 0;

            var porcupineRow = porcupineCoordinates[0];
            var porcupineCol = porcupineCoordinates[1];

            var rabbitRow = rabbitCoordinates[0];
            var rabbitCol = rabbitCoordinates[1];

            rabbitPoits += terrain[rabbitRow][rabbitCol];
            terrain[rabbitRow][rabbitCol] = 0;
            porcupinePoints += terrain[porcupineRow][porcupineCol];
            terrain[porcupineRow][porcupineCol] = 0;

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(' ').ToArray();

                var unitType = tokens[0];
                var direction = tokens[1];
                var steps = int.Parse(tokens[2]);



                if (unitType == "R")
                {
                    var newRow = 0;
                    if (direction == "T" || direction == "B")
                    {
                        newRow = ChangeRow(direction, rabbitRow, rabbitCol, steps);

                        if (newRow == porcupineRow && rabbitCol == porcupineCol)
                        {
                            newRow = ChangeRow(direction, rabbitRow, rabbitCol, steps - 1);

                        }
                        rabbitPoits += terrain[newRow][rabbitCol];
                        terrain[newRow][rabbitCol] = 0;


                        rabbitRow = newRow;
                    }
                    else
                    {
                        var newCol = ChangeCol(direction, rabbitCol, rabbitRow, steps);

                        if (rabbitRow == porcupineRow && newCol == porcupineCol)
                        {
                            newCol = ChangeCol(direction, rabbitCol, rabbitRow, steps - 1);
                        }

                        rabbitPoits += terrain[rabbitRow][newCol];
                        terrain[rabbitRow][newCol] = 0;

                        rabbitCol = newCol;

                    }
                }
                else
                {

                    if (direction == "T" || direction == "B")
                    {
                        var newRow = ChangeRow(direction, porcupineRow, porcupineCol, steps);

                        if (newRow == rabbitRow && porcupineCol == rabbitCol)
                        {
                            newRow = ChangeRowAndCollect(direction, porcupineRow, porcupineCol, steps - 1);
                        }
                        else
                        {
                            newRow = ChangeRowAndCollect(direction, porcupineRow, porcupineCol, steps);
                        }

                        porcupineRow = newRow;
                    }
                    else
                    {
                        var newCol = ChangeCol(direction, porcupineCol, porcupineRow, steps);

                        if (porcupineRow == rabbitRow && newCol == rabbitCol)
                        {
                            newCol = ChangeColAndCollect(direction, porcupineCol, porcupineRow, steps - 1);
                        }

                        newCol = ChangeColAndCollect(direction, porcupineCol, porcupineRow, steps);

                        porcupineCol = newCol;

                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(rabbitPoits);
            Console.WriteLine(porcupinePoints);


        }

        private static int ChangeRow(string direction, int starRow, int col, int stepCount)
        {
            int newRow = starRow;

            var step = direction == "T" ? -1 : 1;
            newRow += step;
            while (stepCount > 0)
            {
                if (terrain[newRow].Length > col)
                {
                    stepCount--;
                    newRow += step;

                }
                else
                {

                    newRow += step;
                }

                if (newRow < 0)
                {
                    newRow += baseRowCount;
                }

                newRow %= baseRowCount;
            }

            return newRow;
        }


        private static int ChangeRowAndCollect(string direction, int starRow, int col, int stepCount)
        {
            int newRow = starRow;

            var step = direction == "T" ? -1 : 1;



            while (stepCount > 0)
            {
                bool hasCol = false;
                if (terrain[newRow].Length > col)
                {
                    hasCol = true;
                    stepCount--;
                    newRow += step;

                }
                else
                {

                    newRow += step;
                }

                if (newRow < 0)
                {
                    newRow += baseRowCount;
                }


                if (hasCol)
                {
                    porcupinePoints += terrain[newRow][col];
                    terrain[newRow][col] = 0;
                }
                newRow %= baseRowCount;

            }

            //if (newRow == starRow)
            //{
            //    porcupinePoints += terrain[newRow][col];
            //    terrain[newRow][col] = 0;
            //}

            return newRow;
        }

        private static int ChangeCol(string dirrection, int startCol, int row, int stepsCount)
        {
            int newCol = startCol;

            var step = dirrection == "L" ? -1 : 1;

            for (int i = 0; i < stepsCount; i++)
            {
                newCol += step;

                if (newCol < 0)
                {
                    newCol += terrain[row].Length;
                }

                newCol %= terrain[row].Length;

            }
            return newCol;
        }

        private static int ChangeColAndCollect(string dirrection, int startCol, int row, int stepsCount)
        {
            int newCol = startCol;

            var step = dirrection == "L" ? -1 : 1;

            for (int i = 0; i < stepsCount; i++)
            {
                newCol += step;

                if (newCol < 0)
                {
                    newCol += terrain[row].Length;
                }

                newCol %= terrain[row].Length;

                porcupinePoints += terrain[row][newCol];
                terrain[row][newCol] = 0;

            }
            return newCol;
        }


        private static void FillTarrain(int row, int collumCount)
        {
            for (int i = 0; i < row / 2; i++)
            {
                terrain[i] = new int[(i + 1) * collumCount];

                for (int j = 0; j < (i + 1) * collumCount; j++)
                {
                    terrain[i][j] = (i + 1) * (j + 1);
                }


            }

            var rowStart = row / 2 + 1;
            for (int i = row / 2; i > 0; i--)
            {
                terrain[rowStart - 1] = new int[(i) * collumCount];
                for (int j = 0; j < (i) * collumCount; j++)
                {
                    terrain[rowStart - 1][j] = rowStart * (j + 1);
                }


                rowStart++;

            }


            for (int i = 0; i < terrain.GetLength(0); i++)
            {
                for (int j = 0; j < terrain[i].Length; j++)
                {
                    Console.Write(terrain[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
