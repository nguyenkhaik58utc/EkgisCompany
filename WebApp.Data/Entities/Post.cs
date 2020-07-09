using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    class Post
    {
        public int Post_ID { get; set; }
        public string theme { get; set; }
        public string content { get; set; }
        public string Urlfile { get; set; }
        public int Employee_ID { get; set; }
    }
}
