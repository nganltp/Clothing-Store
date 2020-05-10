using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.Admin
{
    public class AUsers
    {
        public IEnumerable<Address> addresses { get; set; }
        public IEnumerable<Customer> customers { get; set; }
        public IEnumerable<Comment> comments { get; set; }

        public Customer choosenCustomer { get; set; }
        public Customer editedCustomer { get; set; }
        public Comment choosenComment { get; set; }
    }
}
