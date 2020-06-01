using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.Admin.Entities
{
    public class AProducts
    {
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<ProductSize> sizes { get; set; }
        public Product choosenProduct { get; set; }
        public Product editedProduct { get; set; }
        public ProductSize editedSize { get; set; }
    }

}
