using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class News
    {
        public string id { get; set; }
        public string admin { get; set; }
        public DateTime created { get; set; }
        [DataType(DataType.MultilineText)]
        public string content {get;set;}
        public string type { get; set; }
    }
}
