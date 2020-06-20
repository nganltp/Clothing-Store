using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class HomeViewModel
    {
        public IEnumerable<Image> MenImages { get; set; }

        public IEnumerable<Image> WomenImages { get; set; }

        public ShoppingCart cart { get; set; }

        public IEnumerable<Product> products { get; set; }

        public IEnumerable<Item> items { get; set; }

        public IEnumerable<Image> images { get; set; }

        public Customer customer { get; set; }
    }
}
