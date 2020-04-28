using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Order
    {
        public string id { get; set; }
        public string customer { get; set; }
        public string promotion { get; set; }
        [DataType(DataType.Date)]
        public DateTime ordered { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public int total { get; set; }
    }
}
