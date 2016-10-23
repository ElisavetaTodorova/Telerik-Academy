using System;
namespace _09.FrequentNumber
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            int mostFrequentNumber = 0;
            int maxCount = 0;
            int currentCount = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        mostFrequentNumber = numbers[i];

                    }
                    currentCount = 1;
                }
            }

            Console.WriteLine("{0} ({1} times)", mostFrequentNumber, maxCount);
        }

        //TODO: Debug it later
        private static int getPopularElement(int[] a)
        {
            int count = 1, tempCount;
            int popular = a[0];
            int temp = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                temp = a[i];
                tempCount = 0;
                for (int j = 1; j < a.Length; j++)
                {
                    if (temp == a[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    popular = temp;
                    count = tempCount;
                }
            }
            return popular;
        }
    }
}
