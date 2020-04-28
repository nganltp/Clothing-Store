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
        public string id { get; set; }
        [Display(Name="product")]
        public string product { get; set; }
        public string cart { get; set; }
        public string order { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    }
}
