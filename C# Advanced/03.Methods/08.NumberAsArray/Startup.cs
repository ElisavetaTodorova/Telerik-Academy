using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumberAsArray
{
    class Startup
    {
        static void Main()
        {
            var arraySizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int firstArraySize = arraySizes[0];
            int secondArraySize = arraySizes[1];

            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var latgerSize = firstArraySize > secondArraySize ? firstArraySize : secondArraySize;

            var sumedArray = new int[latgerSize];

            int rest = 0;
            for (int i = 0; i < latgerSize; i++)
            {
                int firstNumber = 0;
                int seconNumber = 0;
                if (i < firstArraySize)
                {
                    firstNumber = firstArray[i];
                }

                if (i < secondArraySize)
                {
                    seconNumber = secondArray[i];
                }

                int sum = firstNumber + seconNumber;

                sumedArray[i] = sum % 10 + rest;

                rest = sum / 10;
            }

            Console.WriteLine(string.Join(" ", sumedArray));

        }
    }
}
