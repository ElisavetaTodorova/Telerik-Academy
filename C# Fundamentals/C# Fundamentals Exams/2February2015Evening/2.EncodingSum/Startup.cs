using System;
namespace _2.EncodingSum
{
    public class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var text = Console.ReadLine().ToUpper();

            var result = 0;

            foreach (var symbol in text)
            {

                if(symbol== '@')
                {
                    break;
                }

                if (char.IsDigit(symbol))
                {
                    result *= (symbol - '0');
                }
                else if (char.IsLetter(symbol))
                {
                    result += symbol - 65;
                }
                else
                {
                    result %= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
