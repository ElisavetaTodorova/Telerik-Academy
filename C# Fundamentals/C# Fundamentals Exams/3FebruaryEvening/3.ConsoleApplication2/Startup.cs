using System;
using System.Numerics;

namespace _3.ConsoleApplication2
{
    class Startup
    {
        static void Main()
        {
            BigInteger globalMultiplication = 1;

            int index = 0;

            while (true)
            {
                BigInteger currentMultiplication = 1;

                var line = Console.ReadLine();


                if (line == "END")
                {
                    break;
                }


                long number = long.Parse(line);

                if (index == 10)
                {
                    Console.WriteLine(globalMultiplication);
                    globalMultiplication = 1;
                }

                if(index % 2 == 0)
                {
                    while (number > 0)
                    {
                        var digit = number % 10;

                        if (digit != 0)
                        {
                            currentMultiplication *= digit;
                        }

                        number /= 10;
                    }
                }

                globalMultiplication *= currentMultiplication;
                index++;


            }

            Console.WriteLine(globalMultiplication);
        }
    }
}
