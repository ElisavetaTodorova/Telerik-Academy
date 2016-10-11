using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        //Fix it later
        static void Main(string[] args)
        {
            DateTime userBirthday = DateTime.Parse(Console.ReadLine());
            DateTime timeToday = DateTime.Today;
            long period = timeToday.Subtract(userBirthday).Ticks;
            int years = new DateTime(period).Year - 1;
            Console.WriteLine(years);
            int futureYears = years + 10;
            Console.WriteLine(futureYears);

        }
    }
}
