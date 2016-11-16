using System;
using System.Numerics;

namespace _2.Secrets
{
    class Startup
    {
        static void Main()
        {
            var number = BigInteger.Parse(Console.ReadLine());

            if (number < 0)
            {
                number *= -1;
            }

            int n = 1;
            BigInteger specialSum = 0;
            var numberAsString = number.ToString();
            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                if (n % 2 == 0)
                {
                    specialSum += (numberAsString[i] - 48) * (numberAsString[i] - 48) * n;
                }
                else
                {
                    specialSum += (numberAsString[i] - 48) * n * n;
                }

                n++;
            }

            BigInteger seaqunceLength = specialSum % 10;

            Console.WriteLine(specialSum);

            if (seaqunceLength == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                var position = (specialSum % 26) + 1;

                for (int i = 0; i < seaqunceLength; i++)
                {
                    if (position > 26)
                    {
                        position = 1;
                        Console.Write((char)(position + 64));
                    }
                    else
                    {
                        Console.Write((char)(position + 64));
                    }

                    position++;
                }
            }

        }


    }
}
