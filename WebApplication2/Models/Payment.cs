using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Payment
    {
        public string id { get; set; }
        public string order { get; set; }
        [DataType(DataType.Date)]
        public DateTime paid { get; set; }
        public string payer { get; set; }
        public string method { get; set; }
        public string note { get; set; }
    }
}
