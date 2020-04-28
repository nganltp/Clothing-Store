﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class ShoppingCart
    {
        public string id { get; set; }
        public string customer { get; set; }
        [DataType(DataType.Date)]
        public DateTime created { get; set; }
        [DataType(DataType.Date)]
        public DateTime discard { get; set; }
       
    }
}
