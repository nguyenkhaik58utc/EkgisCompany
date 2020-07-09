using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    class TimeKeeping
    {
        public int Time_ID { get; set; }
        public int Employee_ID { get; set; }
        public DateTime Timekeeping_Date { get; set; }
        public TimeSpan time1 { get; set; }
        public TimeSpan time2 { get; set; }
        public TimeSpan time3 { get; set; }
        public TimeSpan time4 { get; set; }
        public TimeSpan time5 { get; set; }
        public TimeSpan time6 { get; set; }

    }
}
