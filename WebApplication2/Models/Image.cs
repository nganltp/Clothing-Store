using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Image
    {
        public string id { get; set; }
        public string whose {get;set;}
        public string content { get; set; }
        public string format { get; set; }
        [DataType(DataType.Date)]
        public DateTime created { get; set; }
    }
}
