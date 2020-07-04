using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class CatalogProductVM
    {
        public List<CatalogProduct> products { get; set; }
        public string category;
        public string size;
        public int price;
    }
}
