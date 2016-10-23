using System;
namespace _01.AllocateArray
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i * 5;
            }

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
