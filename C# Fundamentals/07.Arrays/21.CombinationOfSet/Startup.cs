using System;

namespace _21.CombinationOfSet
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var array = new int[n];
            var helper = new int[k];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            GenerateCombinationsNoRepetitions(array, helper, 0, 0,k ,n);

        }

        static void GenerateCombinationsNoRepetitions(int [] array , int[] helper, int index, int start, int k, int n)
        {
            if (index >= k)
            {
                PrintVariations(array, helper);
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    helper[index] = i;
                    GenerateCombinationsNoRepetitions(array , helper , index + 1, i + 1, k,n);
                }
            }
        }

        static void PrintVariations(int [] objects, int [] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {

                    Console.Write(objects[arr[i]] + ", ");
                }
                else
                {
                    Console.WriteLine(objects[arr[i]] + "}");
                }
            }
        }
    }
}
