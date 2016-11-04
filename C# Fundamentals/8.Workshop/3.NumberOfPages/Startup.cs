using System;
namespace _3.NumberOfPages
{
    class Startup
    {
        static void Main()
        {
            var numberOfAllPages = int.Parse(Console.ReadLine());

            int count = 0;
            int devider = 10;
            int number = 1;
            int numberOfPages = 1;

            while (numberOfAllPages > 0)
            {
                if (number / devider == 0)
                {
                    count++;
                    numberOfAllPages -= numberOfPages;
                    number++;
                }
                else
                {
                    devider *= 10;
                    numberOfPages++;
                   
                }

            }

            Console.WriteLine(count);
        }
    }
}
