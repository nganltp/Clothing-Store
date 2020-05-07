using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels.Admin.Entities;

namespace WebApplication2.Controllers.ViewModels.Admin
{
    public class AdminController : Controller
    {
        private const int pageSize = 2;
        private const int intialPage = 1;
        private bool isCreation = true;
        private readonly ShopDatabaseContext db;
        private readonly AProducts aProducts;
        private static string search="";
        private static WebApplication2.Models.Helpers.PagingInformation pageInfor;
        private static string[] sortParams = new string[] { "name_desc", "sup_desc" , "price_desc" ,"cat_desc" };
        public AdminController(ShopDatabaseContext context)
        {
            this.db = context;
            this.aProducts = new AProducts()
            {
                products = db.Product.ToList(),
                choosenProduct = db.Product.Where(p => p.id == 0).FirstOrDefault()
            };
            pageInfor = new Models.Helpers.PagingInformation(aProducts.products.Count(), intialPage, pageSize);
        }
        public IActionResult Index()
        {
            return View();
        }
        /*[HttpPost]
        public IActionResult Products(int? id)
        {
            aProducts.choosenProduct = aProducts.products.Where(p => p.id == id).FirstOrDefault();
            return View(this.aProducts);
        }*/
        public IActionResult Products(int id, string func, string searchString="",  int pagSz=2, int pagId=1, string sortOrder = "#")
        {
            /*IEnumerable<Product> products = this.aProducts.products;
            */
            /*if (!String.IsNullOrEmpty(searchString))
            {
                search = searchString;   
            }*/
            search = searchString;
            pageInfor.pageIndex = pagId;
            pageInfor.pageSize = pagSz;
            updateList(id, func, sortOrder);
            ViewBag.totalPages = pageInfor.totalPages;

            /*products = products.Where(s => s.name.Contains(search)
                                                || s.supplier.Contains(search));
           */



            ;/*
            ViewBag.pi = pageInfor.pageIndex;
            ViewBag.ps = pageInfor.pageSize;*/
            /*ViewBag.name = sortParams[0];
            ViewBag.sup = sortParams[1];
            ViewBag.price = sortParams[2];
            ViewBag.cat = sortParams[3];
*/
            /*if (func == "details")
            {
                this.aProducts.choosenProduct = db.Product.Where(p => p.id == id).FirstOrDefault();
            }
            if (func == "edit")
            {
                this.isCreation = false;
                this.aProducts.editedProduct = db.Product.Where(p => p.id == id).FirstOrDefault();
            } else if (func == "create")
            {
                this.isCreation = true;
                this.aProducts.editedProduct = new Product();
            }*/
            ViewBag.isCreation = this.isCreation?"creation":"edit";
            return View(this.aProducts);
        }        
        private void updateList(int id, string func, string sortOrder="#")
        {
            IEnumerable<Product> products = this.aProducts.products;
            products = products.Where(s => s.name.Contains(search)
                                                || s.supplier.Contains(search));
            for (int i = 0; i < sortParams.Length; i++)
            {
                if (sortParams[i].Contains(sortOrder))
                {
                    sortParams[i] = sortOrder + (sortParams[i].Contains("_asc") ? "_desc" : "_asc");
                    switch (sortParams[i])
                    {
                        case "cat_desc":
                            products = products.OrderByDescending(p => p.category);
                            break;
                        case "cat_asc":
                            products = products.OrderBy(p => p.category);
                            break;
                        case "sup_desc":
                            products = products.OrderByDescending(p => p.supplier);
                            break;
                        case "sup_asc":
                            products = products.OrderBy(p => p.supplier);
                            break;
                        case "price_desc":
                            products = products.OrderByDescending(p => p.price);
                            break;
                        case "price_asc":
                            products = products.OrderBy(p => p.price);
                            break;
                        case "name_desc":
                            products = products.OrderByDescending(p => p.name);
                            break;
                        case "name_asc":
                            products = products.OrderBy(p => p.name);
                            break;
                    }
                }
            }
            this.aProducts.products = products.Skip((pageInfor.pageIndex - 1) * pageInfor.pageSize).Take(pageInfor.pageSize);
            if (func == "details")
            {
                this.aProducts.choosenProduct = db.Product.Where(p => p.id == id).FirstOrDefault();
            }
            if (func == "edit")
            {
                this.isCreation = false;
                this.aProducts.editedProduct = db.Product.FirstOrDefault(p => p.id == id);
            } else if (func == "create")
            {
                this.isCreation = true;
                this.aProducts.editedProduct = new Product();
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Products([Bind("id,name,supplier,summary,description,price,category")] Product product)
        {
            /*if (this.isCreation)
            {
                if (ModelState.IsValid)
                {
                    db.Add(product);
                    db.SaveChanges();

                }
            }
            else 
            {*/
                /*if (id == product.id)
                {
                    
                    Product pd = db.Product.FirstOrDefault(p => p.id == id);
                    db.Entry(pd).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

                    try
                    {

                        db.Update(product);
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw;
                    }
                }*/
            // }

            ViewBag.pName = product.name;
            ViewBag.Id=product.id;
            updateList(1,"");
            return View(this.aProducts);
        }

    }
}