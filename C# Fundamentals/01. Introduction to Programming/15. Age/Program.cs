using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var param = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
            var day = param[1];
            var mounth = param[0];
            var year = param[2];
            var userBirthDate = new DateTime(year, mounth, day);
            var currentDate = DateTime.Now;
            int age = 0;
            if (currentDate.Month > userBirthDate.Month)
            {
                age = currentDate.Year - userBirthDate.Year;
                Console.WriteLine(age);
            }
            else if (currentDate.Month == userBirthDate.Month && currentDate.Day >= userBirthDate.Day)
            {
                age = currentDate.Year - userBirthDate.Year;
                Console.WriteLine(age);
            }
            else if (currentDate.Month == userBirthDate.Month && currentDate.Day < userBirthDate.Day)
            {
                age = currentDate.Year - userBirthDate.Year - 1;
                Console.WriteLine(age);
            }
            else
            {
                age = currentDate.Year - userBirthDate.Year - 1;
                Console.WriteLine(age);
            }
            Console.WriteLine(age + 10);

        }
    }
}
