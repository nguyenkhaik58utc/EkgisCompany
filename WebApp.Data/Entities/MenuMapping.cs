using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    class MenuMapping
    {
        public int menu_mapping_id { get; set; }
        public int menu_id { get; set; }
        public int role_id { get; set; }
        public int menu_flag { get; set; }
    }
}
