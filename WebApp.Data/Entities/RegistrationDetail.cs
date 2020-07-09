using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    class RegistrationDetail
    {
        public int OT_ID { get; set; }
        public DateTime Registration_Date { get; set; }
        public TimeSpan Time_Start { get; set; }
        public TimeSpan Time_Finish { get; set; }
        public string Reason { get; set; }
        public string Reason_For_Cancel { get; set; }
        public int Status_flag { get; set; }
    }
}
