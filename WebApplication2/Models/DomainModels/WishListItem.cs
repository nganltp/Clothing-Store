using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class WishListItem
    {
        [Key]
        public int id { get; set; }

        public int idListWish { get; set; }

        public int idProduct { get; set; }
    }
}
