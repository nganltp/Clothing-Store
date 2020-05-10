using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.Admin
{
    public class APromotion
    {
        public IEnumerable<Promotion> promotions { get; set; }
        public Promotion choosenPromotion { get; set; }
        public Promotion editedPromotion { get; set; }
    }
}
