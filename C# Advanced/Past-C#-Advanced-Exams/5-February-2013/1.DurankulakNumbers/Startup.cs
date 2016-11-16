using System;
using System.Collections.Generic;
using System.Numerics;

namespace _1.DurankulakNumbers
{
    class Startup
    {
        static void Main()
        {
            var text = Console.ReadLine();

            Console.WriteLine(FromDaranculacToDecimal(text));


        }

        private static BigInteger FromDaranculacToDecimal(string text)
        {
            BigInteger result = 0;


            var index = 0;

            var resultNumbers = new List<int>();

            while (index < text.Length)
            {
                var cuurentNumber = 0;
                //Upper case letter
                if (text[index] < 91)
                {
                    cuurentNumber = text[index] - 65;
                }
                //Lower case letter
                else
                {
                    cuurentNumber = (text[index] - 96) * 26 + text[++index] - 65;
                }

                resultNumbers.Add(cuurentNumber);
                index++;
            }

            foreach (var num in resultNumbers)
            {
                result = result * 168 + num;
            }
            return result;
        }
    }
}
