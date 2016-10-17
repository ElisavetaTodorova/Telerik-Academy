using System;

namespace _01.OddOrEven
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("even " + n);
            }
            else
            {
                Console.WriteLine("odd " + n);
            }
        }
    }
}
