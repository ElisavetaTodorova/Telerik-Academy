using System;

namespace _3.Excpression
{
    public class Startup
    {
        public static void Main()
        {
            var excpression = Console.ReadLine();

            decimal excpressionResult = 0;
            char currentOperator = '+';
            decimal bracketValue = 0;
            char bracketOperator = '+';
            bool inBracket = false;

            foreach (var ch in excpression)
            {
                if (ch == '(')
                {
                    inBracket = true;
                    continue;
                }

                if (ch == ')')
                {
                    inBracket = false;
                    switch (currentOperator)
                    {
                        case '+': excpressionResult += bracketValue; break;
                        case '-': excpressionResult -= bracketValue; break;
                        case '*': excpressionResult *= bracketValue; break;
                        case '/': excpressionResult /= bracketValue; break;
                    }
                    bracketOperator = '+';
                    bracketValue = 0;
                    continue;
                }

                if (char.IsDigit(ch))
                {
                    if (inBracket)
                    {
                        switch (bracketOperator)
                        {
                            case '+': bracketValue += ch - '0'; break;
                            case '-': bracketValue -= ch - '0'; break;
                            case '*': bracketValue *= ch - '0'; break;
                            case '/': bracketValue /= ch - '0'; break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': excpressionResult += ch - '0'; break;
                            case '-': excpressionResult -= ch - '0'; break;
                            case '*': excpressionResult *= ch - '0'; break;
                            case '/': excpressionResult /= ch - '0'; break;
                        }
                    }
                }
                else
                {
                    if (inBracket)
                    {
                        bracketOperator = ch;
                    }
                    else
                    {
                        currentOperator = ch;
                    }
                }
            }

            Console.WriteLine("{0:F2}", excpressionResult);

        }
    }
}
