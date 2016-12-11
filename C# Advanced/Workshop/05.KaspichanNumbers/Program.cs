using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.KaspichanNumbers
{
    class Program
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            var result = "";

            while (number > 0)
            {
                var smallLetter = number % 256;
                var bigLetter = number % 256;

                result = (char)((bigLetter % 26) + 65) + result;

                if (smallLetter / 26 != 0)
                {
                    result = (char)((smallLetter / 26) + 96) + result;
                }

                number /= 256;
            }

            Console.WriteLine(result);


        }
    }
}
