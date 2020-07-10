using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class PersonalAccountVM
    {
        public Customer customer { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string new_password { get; set; }
        public int date { get; set; }
        public string month { get; set; }
        public int year { get; set; }
        public string gender { get; set; }

        public int id { get; set; }
    }
}
