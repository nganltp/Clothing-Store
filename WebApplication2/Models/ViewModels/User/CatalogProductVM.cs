using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class CatalogProductVM
    {
        public List<CatalogProduct> products { get; set; }
        public string category { get; set; }
        public string size { get; set; }
        public int price { get; set; }
    }
}
