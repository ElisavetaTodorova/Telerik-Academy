using System;

namespace _02.CompareArrays
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var firstArray = new int[n];
            var secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool areEaqual = true;

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEaqual = false;
                    break;
                }
            }

            Console.WriteLine(areEaqual ? "Equal" : "Not equal");
        }
    }
}
