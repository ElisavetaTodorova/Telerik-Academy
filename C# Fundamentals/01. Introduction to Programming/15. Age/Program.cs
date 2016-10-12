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
            DateTime userBirthday = DateTime.Parse(Console.ReadLine());
            int usersAge = GetAge(userBirthday);
            int usersAgeAfterTenYears = usersAge + 10;
            Console.WriteLine(usersAge);
            Console.WriteLine(usersAgeAfterTenYears);

        }

        public static int GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
    }
}
