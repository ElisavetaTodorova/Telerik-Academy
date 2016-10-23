using System;

namespace _05.MaximumIncreasingSeaqunce
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

            int maxSeaqunceLength = 0;
            int currentSeaqunceLength = 1;

            for (int i = 0; i < n - 1; i++)
            {
                if(numbers[i] < numbers[i + 1])
                {
                    currentSeaqunceLength++;
                }
                else
                {
                    maxSeaqunceLength = Math.Max(currentSeaqunceLength, maxSeaqunceLength);
                    currentSeaqunceLength = 1;
                }
            }

            Console.WriteLine(maxSeaqunceLength);
        }
    }
}
