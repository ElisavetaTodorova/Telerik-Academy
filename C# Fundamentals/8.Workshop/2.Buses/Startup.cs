using System;

namespace _2.Buses
{
    class Startup
    {
        static void Main()
        {
            int numberOfBuses = int.Parse(Console.ReadLine());

            int groupSpeed = int.Parse(Console.ReadLine());
            int groupConut = 1;

            for (int i = 1; i < numberOfBuses; i++)
            {
                int currentSpeed = int.Parse(Console.ReadLine());

                if (currentSpeed <= groupSpeed)
                {
                    groupSpeed = currentSpeed;
                    groupConut++;

                }
            }

            Console.WriteLine(groupConut);
        }
    }
}
