using System;

namespace _08.PrimeCheck
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var isPrime = true;

            var sqrtValue = Math.Sqrt(n);

            for (int i = 2; i <= sqrtValue; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime && n > 1 ? "true" : "false");
        }
    }
}
