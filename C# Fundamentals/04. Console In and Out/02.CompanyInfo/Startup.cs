using System;

namespace _02.CompanyInfo
{
    public class Startup
    {
        public static void Main()
        {
            var companyName = Console.ReadLine();
            var companyAddress = Console.ReadLine();
            var phoneNumber = Console.ReadLine();
            var faxNumber = Console.ReadLine();
            var webSite = Console.ReadLine();
            var managerFirstName = Console.ReadLine();
            var managerLastName = Console.ReadLine();
            var managerAge = Console.ReadLine();
            var managerPhone = Console.ReadLine();
            
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber == "" ? "(no fax)" : faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
