using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Messages
{
    class Startup
    {
        static void Main()
        {
            var input1 = Console.ReadLine();
            var operation = Console.ReadLine();
            var input2 = Console.ReadLine();

            var codes = new string[] {"cad",
                                      "xoz",
                                      "nop",
                                      "cyk",
                                      "min",
                                      "mar",
                                      "kon",
                                      "iva",
                                      "ogi",
                                      "yan" };

            var input1Codes = new List<string>();
            var input2Codes = new List<string>();

            int input1StartIndex = 0;
            int input2StartIndex = 0;

            while (input1StartIndex < input1.Length)
            {
                input1Codes.Add(input1.Substring(input1StartIndex, 3));
                input1StartIndex += 3;

            }

            while (input2StartIndex < input2.Length)
            {
                input2Codes.Add(input2.Substring(input2StartIndex, 3));
                input2StartIndex += 3;

            }

            var input1Number = new StringBuilder();
            var input2Number = new StringBuilder();

            foreach (var item in input1Codes)
            {
                input1Number.Append(Array.IndexOf(codes, item));
            }

            foreach (var item in input2Codes)
            {
                input2Number.Append(Array.IndexOf(codes, item));
            }

            var firstNumber = BigInteger.Parse(input1Number.ToString());
            var seconNumber = BigInteger.Parse(input2Number.ToString());

            BigInteger numberResult = 0;

            if (operation == "+")
            {
                numberResult = firstNumber + seconNumber;
            }
            else
            {
                numberResult = firstNumber - seconNumber;
            }

            var numberResultAsString = numberResult + "";

            var finalString = new StringBuilder();

            foreach (var item in numberResultAsString)
            {
                var str = codes[item - 48];

                finalString.Append(str);
            }

            Console.WriteLine(finalString.ToString());

        }
    }
}
