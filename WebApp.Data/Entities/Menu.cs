using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    class Menu
    {
        public int menu_id { get; set; }
        public string menu_name { get; set; }
        public string menu_url { get; set; }
        public int menu_flag { get; set; }
        public string menu_screen { get; set; }
    }
}
