using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    class Employee
    {
        public int Employee_ID { get; set; }
        public string User_emp { get; set; }
        public string Employee_Name { get; set; }
        public string Department { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public String Sex { get; set; }
        public string Images { get; set; }
        public string Address_emp { get; set; }
        public string Email_Address { get; set; }
        public string Phone_Number { get; set; }
    }
}
