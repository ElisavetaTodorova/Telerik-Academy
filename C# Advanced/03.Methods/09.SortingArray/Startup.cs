using System;
using System.Linq;

namespace _09.SortingArray
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ')
                                          .Select(int.Parse)
                                          .ToArray();

            Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static int FindMaximalElement(int[] array, int startIndex)
        {
            int result = int.MinValue;
            int index = 0;
            for (int i = 0; i < array.Length - startIndex; i++)
            {
                if (result < array[i])
                {
                    result = array[i];
                    index = i;
                }
            }
            return index;
        }

        private static void Sort(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                var index = FindMaximalElement(array, i);
                var maxElement = array[index];
                var index2 = array.Length - i - 1;
                if (array[index2] < maxElement)
                {
                    var temp = array[index2];
                    array[index2] = maxElement;
                    array[index] = temp;
                }
            }
        }
    }
}
