using System;

namespace _01.GSM
{
    class GSMTest
    {
        public static void Main(string[] args)
        {
            MobilePhone nokia = new MobilePhone("Lumia", "nokia");

            nokia.Owner = "Pesho";
            nokia.Price = 1000.0;
            nokia.Display = new Display(5.2, 35000000);
            nokia.Battery = new Battery("x6", BatteryType.LiIon);

            Call call = new Call(new DateTime(2016, 8, 25), 54.4, 0884325123);

            nokia.AddCall(call);
            nokia.RemoveCall(call);

            Console.WriteLine(nokia.CallPrice(0.37));

            Console.WriteLine(nokia.ToString());
        }
    }
}
