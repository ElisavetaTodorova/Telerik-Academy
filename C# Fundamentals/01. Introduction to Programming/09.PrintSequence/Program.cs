using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(number * (-1));
                }
                number++;
            }
        }
    }
}
