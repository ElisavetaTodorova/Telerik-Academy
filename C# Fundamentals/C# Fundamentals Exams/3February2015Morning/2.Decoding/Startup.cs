using System;

namespace _2.Decoding
{
    class Startup
    {
        static void Main()
        {
            var SALT = int.Parse(Console.ReadLine());
            var text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                double result = 0.0;

                if (text[i] == '@')
                {
                    break;
                }
                else if (char.IsDigit(text[i]))
                {
                    result += text[i] + SALT + 500;
                }
                else if (char.IsLetter(text[i]))
                {
                    result += text[i] * SALT + 1000;
                }
                else
                {
                    result += text[i] - SALT;
                }

                if(i % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", result / 100);
                }
                else
                {
                    Console.WriteLine(result * 100);
                }
            }
        }
    }
}
