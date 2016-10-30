using System;
using System.Numerics;
using System.Collections.Generic;

namespace _3.Maslan
{
    public class Startup
    {
        static int countOfTransformations = 0;


        public static void Main()
        {
            var veryBigNumber = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Transformate(veryBigNumber));

        }

        private static string Transformate(BigInteger number)
        {

            if (countOfTransformations == 10)
            {
                return number.ToString();
            }

            if (number / 10 == 0)
            {
                return countOfTransformations + "\r\n" + number;
            }
            else
            {
                List<long> sums = new List<long>();
                number /= 10;
                while (true)
                {

                    string numberAsString = number.ToString();

                    int sum = 0;

                    for (int i = 0; i < numberAsString.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += numberAsString[i] - 48;
                        }
                    }

                    if(sum != 0)
                    {
                        sums.Add(sum);
                    }

                    number /= 10;

                    if (number == 0)
                    {
                        countOfTransformations++;
                        BigInteger multiplication = 1;

                        foreach (var item in sums)
                        {
                            multiplication *= item;
                        }

                        return Transformate(multiplication);

                    }
                }
            }

        }
    }
}
