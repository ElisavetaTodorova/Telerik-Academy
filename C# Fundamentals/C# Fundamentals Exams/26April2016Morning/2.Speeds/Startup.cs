using System;

namespace _2.Speeds
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int longistSeaqunceOfCars = 0;
            long maxSum = 0;

            int groupSpeed = int.Parse(Console.ReadLine());
            int cuurrentCount = 1;
            long currentSum = groupSpeed;
            for (int i = 1; i < n; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed > groupSpeed)
                {
                    currentSum += speed;
                    cuurrentCount++;
                }
                else
                {
                    if(cuurrentCount >= longistSeaqunceOfCars)
                    {
                      

                        if (cuurrentCount == longistSeaqunceOfCars)
                        {
                            maxSum = Math.Max(currentSum, maxSum);
                        }
                        else
                        {
                            maxSum = currentSum;
                        }

                        longistSeaqunceOfCars = cuurrentCount;

                    }

                    groupSpeed = speed;
                    cuurrentCount = 1;
                    currentSum = speed;

                }
            }

            if (cuurrentCount > longistSeaqunceOfCars)
            {
                maxSum = Math.Max(currentSum, maxSum);
            }

            if (cuurrentCount == longistSeaqunceOfCars)
            {
                maxSum = Math.Max(currentSum, maxSum);
            }

            Console.WriteLine(maxSum);
        }
    }
}
