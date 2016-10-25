using System;

namespace _15.PrimeNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                var sqrtValue = Math.Sqrt(number);
                bool isPrime = true;
                for (int j = 2; j <= sqrtValue; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            
        }
    }
}
