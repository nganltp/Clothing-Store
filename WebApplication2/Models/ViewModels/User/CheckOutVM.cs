using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class CheckOutVM
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string company_name { get; set; }
        public string country { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string mobile_phone { get; set; }
        public string payment { get; set; }
        public string note { get; set; }
        public List<Product> order_items { get; set; }
        public List<Image> images { get; set; }
        public List<ItemForm> itemForms { get; set; }
        public int total { get; set; }

    }
}
