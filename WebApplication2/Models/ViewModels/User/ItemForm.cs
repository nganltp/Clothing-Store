using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class ItemForm
    {
        
        public int product { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public List<ProductSize> sizes { get; set; }
        public string size { get; set; }
    }
}
