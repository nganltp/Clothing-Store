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
        [Key]
        public int id { get; set; }
        public int customer { get; set; }
        public int promotion { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [DataType(DataType.DateTime)]
        public DateTime ordered { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public int total { get; set; }
    }
}
