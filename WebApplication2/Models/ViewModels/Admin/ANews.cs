using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.Admin
{
    public class ANews
    {
        public IEnumerable<News> news { get; set; }
        public News choosenNews { get; set; }
        public News editedNews { get; set; }
    }
}
