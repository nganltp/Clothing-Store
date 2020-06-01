using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
namespace WebApplication2.Models.ViewModels.Admin
{
    public class AAdmins
    {
        public IEnumerable<WebApplication2.Models.Admin> admins { get; set; }
        public WebApplication2.Models.Admin choosenAdmin{ get; set; }
        public WebApplication2.Models.Admin editedAdmin { get; set; }
    }
}
