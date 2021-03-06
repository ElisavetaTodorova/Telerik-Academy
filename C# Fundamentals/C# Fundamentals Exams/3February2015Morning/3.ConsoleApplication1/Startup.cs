﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace _3.ConsoleApplication1
{
    class Startup
    {
        static void Main()
        {
            BigInteger globalMultiplication = 1;
            int index = 0;

            while (true)
            {
                BigInteger multiplication = 1;
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                if (index == 10)
                {
                    Console.WriteLine(globalMultiplication);
                    globalMultiplication = 1;
                }

                var number = long.Parse(line);

                if (index % 2 != 0)
                {
                    while (number > 0)
                    {
                        var digit = number % 10;
                        if (digit != 0)
                        {
                            multiplication *= digit;
                        }
                        
                        number /= 10;
                    }

                    globalMultiplication *= multiplication;
                }

                index++;
            }

            Console.WriteLine(globalMultiplication);
        }
    }
}
