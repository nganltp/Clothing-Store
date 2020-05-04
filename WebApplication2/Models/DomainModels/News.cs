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
        [Key]
        public int id { get; set; }
        public int admin { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [DataType(DataType.DateTime)]
        public DateTime created { get; set; }
        [DataType(DataType.MultilineText)]
        public string content {get;set;}
        public string type { get; set; }
    }
}
