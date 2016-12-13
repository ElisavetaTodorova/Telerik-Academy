

namespace _01.GSM
{
    public class Battery
    {
        public Battery(string model, BatteryType batteryType)
        {
            this.Model = model;
            this.BatteryType = batteryType;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
        }

        public string Model { get; private set; }

        public int HoursIdle { get; set; }

        public int HoursTalk { get; set; }

        public BatteryType BatteryType { get; private set; }

        public override string ToString()
        {
            return string.Format("Model: {0}, Hours idle: {1}, Hours talk: {2} ,Battery type: {3}",
                                                this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType);
        }



    }
}
