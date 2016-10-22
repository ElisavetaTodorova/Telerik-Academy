using System;

namespace _09.MatrixOfNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            //Solution with nested loops
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        //Solution without nested loops
        private static void Print(int n)
        {
            int startUpNumber = 1;
            for (int i = 1; i <= n * n; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(startUpNumber);
                    startUpNumber = i / n + 1;
                }
                else
                {
                    Console.Write(startUpNumber++ + " ");
                }
            }
        }
    }
}
