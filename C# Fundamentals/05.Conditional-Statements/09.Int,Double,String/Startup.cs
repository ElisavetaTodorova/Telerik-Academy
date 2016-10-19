using System;

namespace _09.Int_Double_String
{
    public class Startup
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            if (type == "integer")
            {
                var value = int.Parse(Console.ReadLine());
                Console.WriteLine(++value);
            }
            else if (type == "real")
            {
                var value = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", ++value);
            }
            else
            {
                var value = Console.ReadLine();
                Console.WriteLine(value + "*");
            }

        }
    }
}
