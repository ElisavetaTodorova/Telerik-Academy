using System;
using System.Collections.Generic;

namespace _18.RemoveElementsFromArray
{
    //TODO: Fit it not all the tests pass.
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var arrayOfNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            var helper = new List<int>();

            var currentIndex = -1;

            for (int i = 0; i < n - 1; i++)
            {
                if (arrayOfNumbers[i] <= arrayOfNumbers[i + 1])
                {
                    helper.Add(arrayOfNumbers[i]);
                    currentIndex++;
                }
                else
                {
                    if (i != n - 2 && helper.Capacity != 0)
                    {
                        if (helper[currentIndex] == arrayOfNumbers[i])
                        {
                            helper.Remove(currentIndex--);
                        }

                    }
                }
            }

            if(arrayOfNumbers[n - 1] < helper[currentIndex])
            {
                helper.Add(arrayOfNumbers[n - 2]);
            }
            if (arrayOfNumbers[n - 2] < arrayOfNumbers[n - 1])
            {
                helper.Add(arrayOfNumbers[n - 1]);
            }
            Console.WriteLine(n - helper.Count);
        }
    }
}
