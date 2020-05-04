using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Address
    {
        [Key]
        public int id { get; set; }
        public int customer { get; set; }
        public string detail { get; set; }
        public string phone { get; set; }
        public bool isDefaultAddress { get; set; }
        public bool isHomeAddress { get; set; }
    }
}
