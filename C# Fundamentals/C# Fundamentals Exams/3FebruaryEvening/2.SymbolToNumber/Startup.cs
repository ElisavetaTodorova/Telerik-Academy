using System;

namespace _2.SymbolToNumber
{
    class Startup
    {
        static void Main()
        {
            int secretNumber = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                double result = 0;
                if(text[i] == '@')
                {
                    break;
                }

                if (char.IsLetter(text[i]))
                {
                    result = text[i] * secretNumber + 1000;
                }
                else if (char.IsDigit(text[i]))
                {
                    result = text[i] + secretNumber + 500;
                }
                else
                {
                    result = text[i] - secretNumber;
                }

                if (i % 2 ==0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
