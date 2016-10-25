using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.VariationOfSet
{
    public class Startup
    {
        //const int n = 10;
        //const int k = 3;
        //static string[] objects = new string[n]
        //{
        //"banana", "apple", "orange", "strawberry", "raspberry",
        //"apricot", "cherry", "lemon", "grapes", "melon"
        //};
        //static int[] arr = new int[k];

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var array = new int[n];
            var helper = new int[k];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            GenerateVariationsWithRepetitions(helper, array, 0, n, k);
        }

        static void GenerateVariationsWithRepetitions(int[] helper, int[] objcts, int index, int n, int k)
        {
            if (index >= k)
            {
                PrintVariations(helper, objcts);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    helper[index] = i;
                    GenerateVariationsWithRepetitions(helper, objcts, index + 1, n, k);
                }
            }
        }

        static void PrintVariations(int[] arr, int[] objects)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i != arr.Length - 1)
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
