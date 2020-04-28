using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Address
    {
        public string id { get; set; }
        public string customer { get; set; }
        public string detail { get; set; }
        public string phone { get; set; }
        public bool isDefaultAddress { get; set; }
        public bool isHomeAddress { get; set; }
    }
}
