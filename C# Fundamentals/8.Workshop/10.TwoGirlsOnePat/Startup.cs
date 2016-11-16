using System;
using System.Numerics;

namespace _10.TwoGirlsOnePat
{
    class Startup
    {
        static void Main()
        {

            var input = Console.ReadLine().Split(' ');
            var flowers = new long[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                flowers[i] = long.Parse(input[i]);
            }
            BigInteger mollyFlowers = 0;
            BigInteger dollyFlowers = 0;

            bool mollyStepOnEmptyCell = false;
            bool dollyStepOnEmptyCell = false;
            long lenght = flowers.Length;
            long mollyPosition = 0;
            long dollyPosition = flowers.Length - 1;
            long mollyOldPosition = 0;
            long dollyOldPosition = 0;



            while (!dollyStepOnEmptyCell && !mollyStepOnEmptyCell)
            {

                if (dollyPosition == mollyPosition)
                {
                    if (flowers[dollyPosition] == 0)
                    {
                        dollyStepOnEmptyCell = true;
                        mollyStepOnEmptyCell = true;
                        break;
                    }
                    else if (flowers[dollyPosition] % 2 == 0)
                    {
                        dollyFlowers += flowers[dollyPosition] / 2;
                        mollyFlowers += flowers[mollyPosition] / 2;
                        dollyOldPosition = dollyPosition;
                        mollyPosition = (flowers[mollyPosition] + mollyPosition) % lenght;
                        dollyPosition = (dollyPosition - flowers[dollyPosition]) % lenght;

                        flowers[mollyOldPosition] = 0;

                        if (dollyPosition < 0)
                        {

                            dollyPosition += lenght;
                        }


                    }
                    else
                    {
                        dollyFlowers += flowers[dollyPosition] / 2;
                        mollyFlowers += flowers[mollyPosition] / 2;
                        dollyOldPosition = dollyPosition;
                        mollyPosition = (flowers[mollyPosition] + mollyPosition) % lenght;
                        dollyPosition = (dollyPosition - flowers[dollyPosition]) % lenght;
                        flowers[dollyOldPosition] = 1;

                        if (dollyPosition < 0)
                        {

                            dollyPosition += lenght;


                        }

                    }
                }
                else
                {
                    if (flowers[dollyPosition] == 0)
                    {
                        dollyStepOnEmptyCell = true;
                    }
                    if (flowers[mollyPosition] == 0)
                    {
                        mollyStepOnEmptyCell = true;
                    }
                    mollyFlowers += flowers[mollyPosition];
                    dollyFlowers += flowers[dollyPosition];
                    mollyOldPosition = mollyPosition;
                    dollyOldPosition = dollyPosition;
                    mollyPosition = (flowers[mollyPosition] + mollyPosition) % lenght;
                    dollyPosition = (dollyPosition - flowers[dollyPosition]) % lenght;
                    flowers[mollyOldPosition] = 0;
                    flowers[dollyOldPosition] = 0;


                    if (dollyPosition < 0)
                    {

                        dollyPosition += lenght;


                    }

                }


            }
            if (mollyStepOnEmptyCell && dollyStepOnEmptyCell)
            {
                Console.WriteLine("Draw");
            }
            else if (mollyStepOnEmptyCell)
            {
                Console.WriteLine("Dolly");
            }
            else
            {
                Console.WriteLine("Molly");
            }
            Console.WriteLine(mollyFlowers + " " + dollyFlowers);


        }
    }
}
