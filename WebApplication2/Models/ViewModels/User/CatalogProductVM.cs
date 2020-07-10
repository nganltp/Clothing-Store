using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class CatalogProductVM
    {
        public List<CatalogProduct> products { get; set; }
        public List<string> size_filters { get; set; }
        public List<int> price_filters { get; set; }
        public List<string> category_filters { get; set; }

        public List<Product> wish_product { get; set; }
        public List<Product> cart_product { get; set; }
        public List<Product> detail_product { get; set; }
        public List<Image> cart_images { get; set; }
        public List<Image> wish_images { get; set; }
        public List<Image> detail_images { get; set; }
        
        public List<ItemForm> items { get; set; }
        public string sort { get; set; }
    }
}
