using System;
using System.Collections.Generic;
using System.Numerics;

namespace _3.ConsoleApplication1
{
    class Startup
    {
        static void Main()
        {
            var number = Console.ReadLine();
            var list = new List<string>();

            while (number != "END")
            {
                list.Add(number);
                number = Console.ReadLine();
            }

            int x = 0;

            int count = list.Count / 10;

            if (count == 0)
            {
                BigInteger multiplication = 1;

                for (int i = 0; i < list.Count; i++)
                {
                    BigInteger currentMultiplication = 1;

                    if (i % 2 != 0)
                    {

                        for (int j = 0; j < list[i].Length; j++)
                        {
                            if (list[i][j] != '0')
                            {
                                currentMultiplication *= (list[i][j] - 48);
                            }
                        }


                        multiplication *= currentMultiplication;
                    }

                }

                Console.WriteLine(multiplication);


            }
            else if (count > 1)
            {
                //while loop
                int start = 0;
                int end = 10;
                int totalCapacity = list.Count;
                totalCapacity -= 10;

                while (start < list.Count && totalCapacity >= 0)
                {

                    BigInteger multiplication = 1;

                    for (int i = start; i < end; i++)
                    {


                        if (i % 2 != 0)
                        {
                            BigInteger currentMultiplication = 1;

                            for (int j = 0; j < list[i].Length; j++)
                            {
                                if (list[i][j] != '0')
                                {
                                    currentMultiplication *= (list[i][j] - 48);
                                }
                            }

                            multiplication *= currentMultiplication;

                        }


                    }

                    if (totalCapacity - 10 < 0)
                    {
                        start = end;
                        end = list.Count;
                        totalCapacity -= end - start;
                    }
                    else
                    {
                        start = end;
                        end += 10;
                        totalCapacity -= 10;
                    }


                    Console.WriteLine(multiplication);

                }

            }
            else if (count == 1)
            {
                BigInteger multiplication = 1;

                for (int i = 0; i < 10; i++)
                {
                    BigInteger currentMultiplication = 1;

                    if (i % 2 != 0)
                    {

                        for (int j = 0; j < list[i].Length; j++)
                        {
                            if (list[i][j] != '0')
                            {
                                currentMultiplication *= (list[i][j] - 48);
                            }
                        }


                        multiplication *= currentMultiplication;
                    }


                }

                Console.WriteLine(multiplication);

                multiplication = 1;
                for (int i = 10; i < list.Count; i++)
                {
                    BigInteger currentMultiplication = 1;

                    if (i % 2 != 0)
                    {

                        for (int j = 0; j < list[i].Length; j++)
                        {
                            if (list[i][j] != '0')
                            {
                                currentMultiplication *= (list[i][j] - 48);
                            }
                        }

                        multiplication *= currentMultiplication;
                    }

                }

                Console.WriteLine(multiplication);
            }




        }
    }
}
