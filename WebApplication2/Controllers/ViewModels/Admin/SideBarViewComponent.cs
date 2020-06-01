using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers.ViewModels.Admin
{
    [ViewComponent(Name ="SideBar")]
    public class SideBarViewComponent : ViewComponent
    {
        private IEnumerable<string> options = new string[] {"Products",
                                                            "Users", 
                                                            "Orders",
                                                            "Admins"};
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(options);
        }


    }
}