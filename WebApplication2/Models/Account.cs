using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Account
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string fullName { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public DateTime birth { get; set; }
        public bool gender { get; set; }
        public string type { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [DataType(DataType.DateTime)]
        public DateTime closed { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [DataType(DataType.DateTime)]
        public DateTime created { get; set; }
        

    }
}
