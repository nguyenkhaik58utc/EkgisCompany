using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    public class Account
    {
        public int Account_ID { get; set; }
        public string User_emp { get; set; }
        public string Password_emp { get; set; }
        public int Role_ID { get; set; }
    }
}
