using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Promotion
    {
        public string id { get; set; }
        public string admin { get; set; }
        [DataType(DataType.Date)]
        public DateTime created { get; set; }
        [DataType(DataType.Date)]
        public DateTime due { get; set; }
        public string by { get; set; }
        public float discount { get; set; }
        [DataType(DataType.MultilineText)]
        public string description { get; set; }
    }
}
