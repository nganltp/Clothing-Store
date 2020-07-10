using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.User
{
    public class PersonalAddressVM
    {
        //public Customer customer { get; set; }
        public List<Address> addresses { get; set; }
        public string company_name { get; set; }
        public string country { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string ZIPcode { get; set; }
        public string mobile_phone { get; set; }

    }
}
