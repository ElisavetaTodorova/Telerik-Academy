using System;
namespace _5.BobyAvocado
{
    class Startup
    {
        static void Main()
        {
            var n = uint.Parse(Console.ReadLine());
            var numberOfComs = int.Parse(Console.ReadLine());

            int maxCount = -1;
            long maxNumber = 0;

            for (int i = 0; i < numberOfComs; i++)
            {
                var com = uint.Parse(Console.ReadLine());
                uint temp = com;

                if ((com & n) == 0)
                {
                    int currentCountOfOnes = 0;

                    while (com > 0)
                    {
                        uint bit = (com & 1);

                        if (bit == 1)
                        {
                            currentCountOfOnes++;
                        }

                        com >>= 1;
                    }

                    if (currentCountOfOnes > maxCount)
                    {
                        maxCount = currentCountOfOnes;
                        maxNumber = temp;
                    }
                }
            }

            Console.WriteLine(maxNumber);

        }
    }
}
