using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.Admin
{
    public class AOrders
    {
        public IEnumerable<ShoppingCart> shoppingCarts { get; set; }
        public IEnumerable<Item> items { get; set; }
        public IEnumerable<Order> orders { get; set; }
        public IEnumerable<Payment> payments { get; set; }

        public ShoppingCart choosenCart { get; set; }
        public Order choosenOrder { get; set; }
        
    }
}
