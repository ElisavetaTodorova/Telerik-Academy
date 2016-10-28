using System;

namespace _2.TextToNumber
{
    public class Startup
    {
        public static void Main()
        {
            var module = int.Parse(Console.ReadLine());
            long result = 0;
            while (true)
            {
                var currentText = Console.ReadLine().ToUpper();

                foreach (var symbol in currentText)
                {
                    if (symbol == '@')
                    {
                        Console.WriteLine(result);
                        return;
                    }
                    else if (char.IsDigit(symbol))
                    {
                        result *= (symbol - '0');
                    }
                    else if (char.IsLetter(symbol))
                    {
                        result += symbol - 65;
                    }
                    else
                    {
                        result %= module;     
                    }
                }

            }
        }
    }
}
