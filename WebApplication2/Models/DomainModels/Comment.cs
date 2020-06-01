using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public int account { get; set; }
        public int product { get; set; }
        public int stars { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [DataType(DataType.DateTime)]
        public DateTime created { get; set; }
    }
}
