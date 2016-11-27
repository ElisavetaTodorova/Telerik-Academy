using System;

namespace _03.CorrectBrackets
{
    class Startup
    {
        static void Main()
        {
            var expression = Console.ReadLine();
            var bracketConut = 0;
            var isValidExpression = true;

            for (int i = 0; i < expression.Length; i++)
            {
                var currentSymbol = expression[i];

                if (currentSymbol == '(')
                {
                    bracketConut++;
                }
                else if (currentSymbol == ')')
                {
                    bracketConut--;
                }

                if (bracketConut < 0)
                {
                    isValidExpression = false;
                    break;
                }
            }

            if (isValidExpression && bracketConut == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
