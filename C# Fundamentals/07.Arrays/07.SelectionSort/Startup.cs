using System;

namespace _07.SelectionSort
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

            for (int i = 0; i < n; i++)
            {
                int minElement = numbers[i];
                for (int j = i + 1; j < n; j++)
                {
                    if(minElement > numbers[j])
                    {
                        minElement = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = minElement;
                    }
                }
            }

            Console.WriteLine(string.Join("\r\n",numbers));
        }
    }
}
