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
        public string id { get; set; }
        public string username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string fullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime birth { get; set; }
        public bool gender { get; set; }
        public string type { get; set; }
        public DateTime closed { get; set; }
        public DateTime created { get; set; }
        

    }
}
