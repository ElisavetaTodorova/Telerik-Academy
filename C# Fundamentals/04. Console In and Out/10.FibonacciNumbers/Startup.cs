using System;
using System.Collections.Generic;

namespace _10.FibonacciNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new LinkedList<int>();

            if (n == 1)
            {
                Console.WriteLine(0);
                return;
            }
            var firstNumber = 0;
            var secondNumber = 1;

            numbers.AddLast(firstNumber);
            numbers.AddLast(firstNumber);

            for (int i = 2; i < n; i++)
            {
                var numberToAdd = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = numberToAdd;

                numbers.AddLast(numberToAdd);
            }

            Console.WriteLine(String.Join(", ", numbers));
            
        }
    }
}
