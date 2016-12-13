using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GSM
{
    public class MobilePhone
    {
        private static MobilePhone iphone4S = new MobilePhone("4S", "Apple");

        public MobilePhone(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = null;
            this.Display = null;
            this.Battery = null;
            this.Calls = new List<Call>();
        }

        public static MobilePhone Iphone4S
        {
            get
            {
                return iphone4S;
            }
        }

        public List<Call> Calls { get; private set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public double Price { get; set; }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public override string ToString()
        {
            string display = null;
            string battery = null;

            if (this.Display != null)
            {
                display = this.Display.ToString();
            }

            if (this.Battery != null)
            {
                battery = this.Battery.ToString();
            }
            return string.Format("Model: {0}\r\nManufacturer: {1}\r\nPrice: {2}\r\nOwner: {3}\r\nBattery: {4}\r\nDisplay: {5}", this.Model
                                                              , this.Manufacturer, this.Price
                                                              , this.Owner, battery
                                                              , display);
        }

        public void AddCall(Call call)
        {
            this.Calls.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.Calls.Remove(call);
        }

        public double CallPrice(double price)
        {
            double result = 0.0;

            foreach (var call in Calls)
            {
                result += call.Duration * price;
            }

            return result;
        }

        public void ClearCalls()
        {
            this.Calls.Clear();
        }
    }
}
