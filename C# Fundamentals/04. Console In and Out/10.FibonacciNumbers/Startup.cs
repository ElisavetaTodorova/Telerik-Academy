using System;
using System.Collections.Generic;
using System.Numerics;

namespace _10.FibonacciNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new LinkedList<BigInteger>();

            if (n == 1)
            {
                Console.WriteLine(0);
                return;
            }
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;

            numbers.AddLast(firstNumber);
            numbers.AddLast(secondNumber);

            for (int i = 2; i < n; i++)
            {
                BigInteger numberToAdd = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = numberToAdd;

                numbers.AddLast(numberToAdd);
            }

            Console.WriteLine(String.Join(", ", numbers));
            
        }
    }
}
