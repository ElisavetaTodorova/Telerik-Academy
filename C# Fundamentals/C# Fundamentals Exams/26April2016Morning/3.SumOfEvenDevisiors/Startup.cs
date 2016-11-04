using System;
namespace _3.SumOfEvenDevisiors
{
    class Startup
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0 && i % j == 0)
                        {
                            sum += j;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
