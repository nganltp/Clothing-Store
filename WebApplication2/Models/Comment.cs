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
        public string id { get; set; }
        public string account { get; set; }
        public string product { get; set; }
        public int stars { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        [DataType(DataType.Date)]
        public DateTime created { get; set; }
    }
}
