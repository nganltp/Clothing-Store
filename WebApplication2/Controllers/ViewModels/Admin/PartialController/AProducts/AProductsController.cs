using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels.Admin.Entities;

namespace WebApplication2.Controllers.ViewModels.Admin.PartialController.Products
{
    public class AProductsController : Controller
    {
        private ShopDatabaseContext db;
        private AProducts aProducts;
        public AProductsController(ShopDatabaseContext _db)
        {
            db = _db;
            aProducts.products = db.Product.ToList();
            aProducts.choosenProduct = new Product() { id = 0 };
        }
        public PartialViewResult List()
        {
            return PartialView(aProducts.products);
        }
        public PartialViewResult Create()
        {
            return PartialView();
        }
        public PartialViewResult Details(int? id)
        {
            if (id == null)
            {
                return PartialView(new Product() { id = 0 });
            }

            var product = db.Product.Where(m => m.id == id).FirstOrDefault();
            if (product!= null) { aProducts.choosenProduct = product; }

            return PartialView(aProducts.choosenProduct);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public PartialViewResult Create([Bind("id,name,supplier,summary,description,price,category")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                // await _context.SaveChangesAsync();
                // return Create();
            }
            return Create();
        }

    }
}