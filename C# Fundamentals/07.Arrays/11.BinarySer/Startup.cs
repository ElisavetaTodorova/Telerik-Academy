using System;

namespace _11.BinarySearch
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[] sortedNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                sortedNumbers[i] = int.Parse(Console.ReadLine());
            }

            int searchedNumber = int.Parse(Console.ReadLine());

            int middleEllement = sortedNumbers[n / 2];

            int index = -1;

            if (middleEllement > searchedNumber)
            {
                for (int i = 0; i <= n / 2; i++)
                {
                    if (searchedNumber == sortedNumbers[i])
                    {
                        index = i;
                        break;
                    }
                }
            }
            else if (middleEllement < searchedNumber)
            {
                for (int i = n / 2; i < n; i++)
                {
                    if (searchedNumber == sortedNumbers[i])
                    {
                        index = i;
                        break;
                    }
                }
            }
            else
            {
                index = n / 2;
            }

            Console.WriteLine(index);
        }
    }
}
