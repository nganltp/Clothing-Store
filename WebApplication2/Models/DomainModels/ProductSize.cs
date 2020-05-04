using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ProductSize
    {
        [Key]
        public int id { get; set; }
        public int product { get; set; }
        public string size { get; set; }
        public string quantity { get; set; }

    }
}
