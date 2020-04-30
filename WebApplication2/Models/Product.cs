using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string supplier { get; set; }
        public string summary { get; set; }
        [DataType(DataType.MultilineText)]
        public string description { get; set; }
        public string price { get; set; }
        public string category { get; set; }
    }
}
