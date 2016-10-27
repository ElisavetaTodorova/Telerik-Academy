using System;
namespace _2.TheHorror
{
    public class Startup
    {
        public static void Main()
        {
            var numberAsString = Console.ReadLine();

            int count = 0;
            var sum = 0;

            for (int i = 0; i < numberAsString.Length; i+=2)
            {
                if(numberAsString[i] < 65)
                {
                    count++;
                    sum += numberAsString[i] - 48;
                }
                
            }

            Console.WriteLine("{0} {1}",count, sum);
        }
    }
}
