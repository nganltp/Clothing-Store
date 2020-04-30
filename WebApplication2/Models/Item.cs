using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication2.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        [Display(Name="product")]
        public int product { get; set; }
        public int cart { get; set; }
        public int order { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    }
}
