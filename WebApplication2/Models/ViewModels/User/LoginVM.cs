using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class LoginVM
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isLoggedIn { get; set; }
    }
}
