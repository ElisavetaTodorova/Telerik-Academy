using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GSM
{
    public class Call
    {
        public Call(DateTime date, double duration, long dialedPhone)
        {
            this.DateAndTime = date;
            this.Duration = duration;
            this.DialedPhone = dialedPhone;
        }

        public DateTime DateAndTime { get; set; }

        public double Duration { get; set; }

        public long DialedPhone { get; set; }


    }
}
