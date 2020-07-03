using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class CatalogProduct
    {
        public Product product { get; set; }

        public List<Image> images { get; set; }

        public List<ProductSize> productsizes { get; set; }

        public string category { get; set; }

        public string subCategory { get; set; }

    }
}
