using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels.Admin;
using WebApplication2.Models.ViewModels.Admin.Entities;

namespace WebApplication2.Controllers.ViewModels.Admin
{
    public class AdminController : Controller
    {
        private const int pPageSize = 2;
        private const int intialPage = 1;
        private bool isCreation = true;
        private readonly ShopDatabaseContext db;
        private readonly AProducts aProducts;
        private static string search="";
        private static WebApplication2.Models.Helpers.PagingInformation pPageInfor;
        private static string[] pSortParams = new string[] { "name_desc", "sup_desc" , "price_desc" ,"cat_desc", "quantity_desc", "size_desc" };


        private const int uPageSize = 2;
        private readonly AUsers aUsers;
        private static WebApplication2.Models.Helpers.PagingInformation uPageInfor;
        private static string[] uSortParams = new string[] { "id_asc", "name_asc", "email.asc", "fullname_asc", "open_asc", "close_asc", "stars_asc", "created_asc" };

        private const int oPageSize = 2, iPageSize = 2, cPageSize=2, yPageSize=2;
        private readonly AOrders aOrders;
        private static WebApplication2.Models.Helpers.PagingInformation oPageInfor;
        private static string[] oSortParams = new string[] { "cCustomer_asc", "cCreated_asc", "discard_asc", "oCustomer_asc", "oCreated_asc", "ordered_asc", "status_asc", "total_asc" };

        private const int aPageSize = 2;
        private readonly AAdmins aAdmins;
        private static WebApplication2.Models.Helpers.PagingInformation aPageInfor;
        private static string[] aSortParams = new string[] { "id_asc", "name_asc", "email.asc", "fullname_asc", "open_asc", "close_asc", "stars_asc", "created_asc" };

        private const int proPageSize = 2;
        private readonly APromotion aPromotion;

        private const int nPageSize = 2;
        private readonly ANews aNews;
        
        public AdminController(ShopDatabaseContext context)
        {
            this.db = context;
            this.aProducts = new AProducts()
            {
                products = db.Product.ToList(),
                choosenProduct = db.Product.Where(p => p.id == 0).FirstOrDefault()
            };
            pPageInfor = new Models.Helpers.PagingInformation(aProducts.products.Count(), intialPage, pPageSize);
            this.aUsers = new AUsers()
            {
                customers = db.Customer.ToList(),
                addresses = db.Address.ToList(),
                comments = db.Comment.ToList(),
            };
            this.aOrders = new AOrders()
            {
                orders = db.Order,
                shoppingCarts = db.ShoppingCart,
                items = db.Item,
                payments = db.Payment
            };
            this.aAdmins = new AAdmins()
            {
                admins = db.Admin,
                choosenAdmin = new Models.Admin(),
                editedAdmin = new Models.Admin() 
            };
            uPageInfor = new Models.Helpers.PagingInformation(aUsers.customers.Count(), intialPage, uPageSize);
            this.aPromotion = new APromotion()
            {
                promotions = db.Promotion,
                choosenPromotion = new Models.Promotion(),
                editedPromotion = new Models.Promotion()
            };
            this.aNews = new ANews()
            {
                news = db.News,
                choosenNews = new Models.News(),
                editedNews = new Models.News()
            };
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products(int id, int sizeId, string func, int sizeAlter = 0, string searchString="",  int pagSz=2, int pageId=1, string sortOrder = "#")
        {
            search = searchString;
            pPageInfor.pageIndex = pageId;
            pPageInfor.pageSize = pagSz;
            updateProductList(id, sizeId, func, sizeAlter, sortOrder);

            ViewBag.totalPages = pPageInfor.totalPages;
            ViewBag.isCreation = this.isCreation?"Creation":"Edition";

            return View(this.aProducts);
        }        
        private void updateProductList(int id, int sizeId, string func, int sizeAlter = 0, string sortOrder="#")
        {
            IEnumerable<Product> products = this.db.Product;
            products = products.Where(s => s.name.Contains(search)
                                                || s.supplier.Contains(search));
            IEnumerable<ProductSize> sizes = this.db.ProductSize;
            sizes = sizes.Where(s => s.product == this.aProducts.choosenProduct.id);
            for (int i = 0; i < pSortParams.Length; i++)
            {
                if (pSortParams[i].Contains(sortOrder))
                {
                    pSortParams[i] = sortOrder + (pSortParams[i].Contains("_asc") ? "_desc" : "_asc");
                    switch (pSortParams[i])
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
                        case "size_desc":
                            sizes = sizes.OrderByDescending(p => p.size);
                            break;
                        case "size_asc":
                            sizes = sizes.OrderBy(p => p.size);
                            break;
                        case "quantity_desc":
                            sizes = sizes.OrderByDescending(p => p.quantity);
                            break;
                        case "quantity_asc":
                            sizes = sizes.OrderBy(p => p.quantity);
                            break;
                    }
                }
            }
            this.aProducts.products = products.Skip((pPageInfor.pageIndex - 1) * pPageInfor.pageSize).Take(pPageInfor.pageSize);
            this.aProducts.sizes = sizes;

            if (func == "details")
            {
                this.aProducts.choosenProduct = db.Product.Where(p => p.id == id).FirstOrDefault();
                this.aProducts.sizes = db.ProductSize.Where(s => s.product == this.aProducts.choosenProduct.id);
                this.aProducts.editedSize = new ProductSize();
            }
            if (sizeId!=0 && sizeAlter!=0)
            {
                ProductSize sz = db.ProductSize.FirstOrDefault(s => s.id == sizeId);
                db.Entry(sz).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                sz.quantity = Convert.ToString((int.Parse(sz.quantity) + sizeAlter));
                db.Update(sz);
                db.SaveChanges();
            } 

            if (func == "edit")
            {
                this.isCreation = false;
                this.aProducts.editedProduct = db.Product.FirstOrDefault(p => p.id == id);
            } else if (func == "delete")
            {
                Product pd = db.Product.FirstOrDefault(p => p.id == id);
                db.Product.Remove(pd);
                db.SaveChanges();
            }else
            {
                this.isCreation = true;
                this.aProducts.editedProduct = new Product() { id = 0 };
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Products(AProducts aProduct)
        {           
            Product product = new Product();
            product = aProduct.editedProduct;
            if (ModelState.IsValid)
            {
                if (aProduct.editedProduct!=null && !String.IsNullOrEmpty(aProduct.editedProduct.name))
                {
                    if (aProduct.editedProduct.id == 0)
                    {
                        db.Product.Add(product);
                    }
                    else
                    {
                        Product pd = db.Product.FirstOrDefault();
                        db.Entry(pd).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        db.SaveChanges();
                        db.Product.Update(product);
                    }
                }
                if(!String.IsNullOrEmpty(aProduct.editedSize.size))
                {
                    ProductSize size = aProduct.editedSize;
                    // size.product = this.aProducts.choosenProduct.id;
                    db.ProductSize.Add(size);
                    ViewBag.Id=aProduct.editedSize.size;

                }
            }
            
            db.SaveChanges();            
            updateProductList(1,0,"create");
            ModelState.Clear();

            // ViewBag.pName = aProduct.editedProduct.name;
            // ViewBag.Id=aProduct.editedProduct.id;
            ViewBag.totalPages = pPageInfor.totalPages;
            ViewBag.isCreation = this.isCreation ? "Create" : "Edit";

            return View(this.aProducts);
        }

        public ViewResult Users(int id, string func, int pageId,string searchString="",string sortOrder="")
        {
            search = searchString;
            uPageInfor.pageIndex = pageId;
            updateUserList(id, func, pageId, sortOrder);

            ViewBag.totalPages = Math.Ceiling(this.aUsers.customers.Count()/(double)uPageSize);

            return View(this.aUsers);
        }
        private void updateUserList(int id,string func, int pageId, string sortOrder)
        {
            
            IEnumerable<Customer> customers = this.db.Customer;
            customers = customers.Where(s => s.username.Contains(search)
                                                || s.email.Contains(search));
            IEnumerable<Comment> comments = this.db.Comment;
            if (id != 0)
            {
                comments = comments.Where(s => s.account == id);
            }
            IEnumerable<Address> addresses = this.db.Address;
            if (id != 0)
            {
                addresses = addresses.Where(s => s.customer == id);
            }

            for (int i = 0; i < uSortParams.Length; i++)
            {
                if (uSortParams[i].Contains(sortOrder))
                {
                    uSortParams[i] = sortOrder + (uSortParams[i].Contains("_asc") ? "_desc" : "_asc");
                    switch (uSortParams[i])
                    {
                        case "username_desc":
                            customers = customers.OrderByDescending(p => p.username);
                            break;
                        case "username_asc":
                            customers = customers.OrderBy(p => p.username);
                            break;
                        case "email_desc":
                            customers = customers.OrderByDescending(p => p.email);
                            break;
                        case "email_asc":
                            customers = customers.OrderBy(p => p.email);
                            break;
                        case "fullname_desc":
                            customers = customers.OrderByDescending(p => p.fullName);
                            break;
                        case "fullname_asc":
                            customers = customers.OrderBy(p => p.fullName);
                            break;
                        case "open_desc":
                            customers = customers.OrderByDescending(p => p.created);
                            break;
                        case "open_asc":
                            customers = customers.OrderBy(p => p.created);
                            break;
                        case "closed_desc":
                            customers = customers.OrderByDescending(p => p.closed);
                            break;
                        case "closed_asc":
                            customers = customers.OrderBy(p => p.closed);
                            break;
                        case "stars_desc":
                            comments = comments.OrderByDescending(p => p.stars);
                            break;
                        case "stars_asc":
                            comments = comments.OrderBy(p => p.stars);
                            break;
                        case "created_desc":
                            comments = comments.OrderByDescending(p => p.created);
                            break;
                        case "created_asc":
                            comments = comments.OrderBy(p => p.created);
                            break;
                    }
                }
            }
            this.aUsers.customers = customers.Skip((uPageInfor.pageIndex - 1) * uPageInfor.pageSize).Take(uPageInfor.pageSize);
            this.aUsers.comments = comments;

            if (func == "close")
            {
                Customer cus = db.Customer.FirstOrDefault(c => c.id == id);
                db.Entry(cus).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                cus.closed = DateTime.Now;
                db.Customer.Update(cus);
                db.SaveChanges();
            } else if (func == "open")
            {

                Customer cus = db.Customer.FirstOrDefault(c => c.id == id);
                db.Entry(cus).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                cus.closed =cus.created;
                db.Customer.Update(cus);
                db.SaveChanges();
            }
            else if (func == "details") {
                this.aUsers.choosenCustomer = db.Customer.FirstOrDefault(c => c.id == id);
                this.aUsers.comments = db.Comment.Where(c => c.account == id);
                this.aUsers.addresses = db.Address.Where(a => a.customer == id);
            } 
            else if (func == "delete")
            {
                Customer pd = db.Customer.FirstOrDefault(p => p.id == id);
                db.Customer.Remove(pd);
                db.SaveChanges();
            }
        }
        public ViewResult Orders(int cId,int oId, int iId, string func,int cPageId, int oPageId, int yPageId, int iPageId, int iSrch, int cSrch, int oSrch, string sortOrder="")
        {
            updateOrderList(cId, oId, iId, func, sortOrder, iSrch, cSrch, oSrch );

            ViewBag.sort = sortOrder;
            ViewBag.totalCPage = Math.Ceiling(aOrders.shoppingCarts.Count() / (double)cPageSize);
            ViewBag.totalOPage = Math.Ceiling(aOrders.orders.Count() / (double)oPageSize);
            ViewBag.totalIPage = Math.Ceiling(aOrders.items.Count() / (double)iPageSize);
            ViewBag.totalYPage = Math.Ceiling(aOrders.payments.Count() / (double)yPageSize);

            if (this.aOrders.orders != null)
            {
                this.aOrders.orders = this.aOrders.orders.Skip((oPageId - 1) * oPageSize).Take(oPageSize);
            }
            if (this.aOrders.items != null)
            {
                this.aOrders.items = this.aOrders.items.Skip((iPageId - 1) * iPageSize).Take(iPageSize);

            }
            if (this.aOrders.shoppingCarts != null)
            {
                this.aOrders.shoppingCarts = this.aOrders.shoppingCarts.Skip((cPageId - 1) * cPageSize).Take(cPageSize);
            }
            if (this.aOrders.payments != null)
            {
                this.aOrders.payments = this.aOrders.payments.Skip((yPageId - 1) * yPageSize).Take(yPageSize);
            }

            return View(aOrders);
        }
        
        private void updateOrderList(int cId, int oId, int iId, string func, string sortOrder, int iSrch, int cSrch, int oSrch)
        {

            IEnumerable<Order> orders = db.Order;
            if (oSrch != 0)
            {
                orders = orders.Where(o => o.customer == oSrch);
            }
            IEnumerable<ShoppingCart> shoppingCarts = db.ShoppingCart;
            if (cSrch != 0)
            {
                shoppingCarts = shoppingCarts.Where(c => c.customer == cSrch);
            }
            IEnumerable<Item> items = db.Item;
            if(iSrch!=0)
            {
                items = items.Where(i => i.product == iSrch);
            }
            IEnumerable<Payment> payments = db.Payment;

            if (func == "delete")
            {
                if (cId != 0)
                {
                    ShoppingCart pd = db.ShoppingCart.FirstOrDefault(p => p.id == cId);
                    db.ShoppingCart.Remove(pd);
                    db.SaveChanges();
                }
                else if (oId != 0)
                {
                    Order pd = db.Order.FirstOrDefault(p => p.id == oId);
                    db.Order.Remove(pd);
                    db.SaveChanges();
                }
                else
                {
                    Item pd = db.Item.FirstOrDefault(p => p.id == iId);
                    db.Item.Remove(pd);
                    db.SaveChanges();

                }
            }
            else if (func == "details")
            {
                if (cId != 0)
                {
                    items = db.Item.Where(i => i.cart == cId);
                }
                else
                {
                    items = db.Item.Where(i => i.order == oId);
                    payments = db.Payment.Where(y => y.order == oId);
                }
            }

            for (int i = 0; i < oSortParams.Length; i++)
            {
                if (oSortParams[i].Contains(sortOrder))
                {
                    oSortParams[i] = sortOrder + (oSortParams[i].Contains("_asc") ? "_desc" : "_asc");
                    switch (oSortParams[i])
                    {
                        case "cCustomer_desc":
                            shoppingCarts = shoppingCarts.OrderByDescending(p => p.customer);
                            break;
                        case "cCustomer_asc":
                            shoppingCarts = shoppingCarts.OrderBy(p => p.customer);
                            break;
                        case "cCreated_desc":
                            shoppingCarts = shoppingCarts.OrderByDescending(p => p.created);
                            break;
                        case "cCreated_asc":
                            shoppingCarts = shoppingCarts.OrderBy(p => p.created);
                            break;
                        case "discard_desc":
                            shoppingCarts = shoppingCarts.OrderByDescending(p => p.discard);
                            break;
                        case "discard_asc":
                            shoppingCarts = shoppingCarts.OrderBy(p => p.discard);
                            break;
                        case "oCustomer_desc":
                            orders = orders.OrderByDescending(p => p.customer);
                            break;
                        case "oCustomer_asc":
                            orders = orders.OrderBy(p => p.customer);
                            break;
                        case "ordered_desc":
                            orders = orders.OrderByDescending(p => p.ordered);
                            break;
                        case "ordered_asc":
                            orders = orders.OrderBy(p => p.ordered);
                            break;
                        case "status_desc":
                            orders = orders.OrderByDescending(p => p.status);
                            break;
                        case "status_asc":
                            orders = orders.OrderBy(p => p.status);
                            break;
                        case "total_desc":
                            orders = orders.OrderByDescending(p => p.total);
                            break;
                        case "total_asc":
                            orders = orders.OrderBy(p => p.total);
                            break;
                    }
                }
                
            }
            this.aOrders.orders = orders;
            this.aOrders.shoppingCarts = shoppingCarts;
            this.aOrders.items = items;
            this.aOrders.payments = payments;
        }
        public ViewResult Admins(int id, string func, string aSrch, int pageId, string sortOrder="")
        {
            search = aSrch;
            aPageInfor.pageIndex = pageId;
            updateAdminList(id, func, aSrch, sortOrder);

            ViewBag.totalPages = aPageInfor.totalPages;
            ViewBag.isCreation = this.isCreation ? "Create" : "Edit";

            return View(aAdmins);

        }
        private void updateAdminList(int id, string func, string aSrch, string sortOrder="")
        {
            IEnumerable<Models.Admin> admins = db.Admin;
            if (!String.IsNullOrEmpty(aSrch))
            {
                admins = admins.Where(ad => ad.email == aSrch || ad.username == aSrch);
            }
            for (int i = 0; i < aSortParams.Length; i++)
            {
                if (aSortParams[i].Contains(sortOrder))
                {
                    aSortParams[i] = sortOrder + (aSortParams[i].Contains("_asc") ? "_desc" : "_asc");
                    switch (aSortParams[i])
                    {
                        case "name_desc":
                            admins = admins.OrderByDescending(p => p.username);
                            break;
                        case "name_asc":
                            admins = admins.OrderBy(p => p.username);
                            break;
                        case "email_desc":
                            admins = admins.OrderByDescending(p => p.email);
                            break;
                        case "email_asc":
                            admins = admins.OrderBy(p => p.email);
                            break;
                        case "open_desc":
                            admins = admins.OrderByDescending(p => p.closed);
                            break;
                        case "open_asc":
                            admins = admins.OrderBy(p => p.closed);
                            break;
                        case "closed_desc":
                            admins = admins.OrderByDescending(p => p.created);
                            break;
                        case "closed_asc":
                            admins = admins.OrderBy(p => p.created);
                            break;
                    }
                }
            }
            if (func == "close")
            {
                Models.Admin ad = db.Admin.FirstOrDefault(a => a.id == id);
                db.Entry(ad).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                ad.closed = DateTime.Now;
                db.Admin.Update(ad);
                db.SaveChanges();
            }else if (func == "open")
            {
                Models.Admin ad = db.Admin.FirstOrDefault(a => a.id == id);
                db.Entry(ad).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                ad.closed = ad.created;
                db.Admin.Update(ad);
                db.SaveChanges();
            }
            else if (func == "details")
            {
                ViewBag.isDetails = "true";
                this.aAdmins.choosenAdmin = db.Admin.FirstOrDefault(a => a.id == id);
            } else if (func == "Edit")
            {
                ViewBag.isDetails = "false";
                this.isCreation = false;
                this.aAdmins.editedAdmin = db.Admin.FirstOrDefault(a => a.id == id);
            }
            if (func == "create")
            {
                ViewBag.isDetails = "false";
                this.isCreation = true;
                this.aAdmins.choosenAdmin = new Models.Admin();

            }
            else
            {
                ViewBag.isDetails = "false";

            }
            this.aAdmins.admins = admins;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Admins(AAdmins admins)
        {
            Models.Admin admin = new Models.Admin();
            admin = admins.editedAdmin;
            if (ModelState.IsValid)
            {
                if (admins.editedAdmin != null && !String.IsNullOrEmpty(admins.editedAdmin.username))
                {
                    if (admins.editedAdmin.id == 0)
                    {
                        db.Admin.Add(admin);
                    }
                    else
                    {
                        Models.Admin pd = db.Admin.FirstOrDefault();
                        db.Entry(pd).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        db.SaveChanges();
                        db.Admin.Update(admin);
                    }
                }
            }

            db.SaveChanges();
            updateAdminList(1, "create", "", "");
            ModelState.Clear();

            // ViewBag.pName = aProduct.editedProduct.name;
            // ViewBag.Id=aProduct.editedProduct.id;
            ViewBag.totalPages = aPageInfor.totalPages;
            ViewBag.isCreation = "Create";

            return View(this.aAdmins);
        }
        public IActionResult Promotion(int id, string search, string func, string sortOrder, int PageId)
        {
            updatePromotionList(id, func, search, PageId);

            ViewBag.totalPage = Math.Ceiling(this.aPromotion.promotions.Count() / (double)proPageSize);

            if (this.aPromotion.promotions != null)
            {
                this.aPromotion.promotions = this.aPromotion.promotions.Skip((PageId - 1) * proPageSize).Take(proPageSize);
            }
            ViewBag.isCreation = this.isCreation ? "Create" : "Edit";
            return View(aPromotion);
        }
        private void updatePromotionList(int id, string func, string search, int PageId)
        {
            IEnumerable<Promotion> promotions = db.Promotion;
            if (search != null)
            {
                promotions = promotions.Where(p => p.admin == Convert.ToInt32(search));
            }
            
            if (func == "details")
            {
                this.aPromotion.choosenPromotion = db.Promotion.FirstOrDefault(p => p.id == id);
            }
            else if (func == "edit")
            {
                this.aPromotion.choosenPromotion = new Promotion();
                this.aPromotion.editedPromotion = db.Promotion.FirstOrDefault(p => p.id == id);
            }
            else if (func == "delete")
            {
                Promotion p = db.Promotion.FirstOrDefault(a => a.id == id);
                db.Promotion.Remove(p);
                db.SaveChanges();
                this.aPromotion.choosenPromotion = new Promotion();
            }
            else
            {
                this.aPromotion.choosenPromotion = new Promotion();
                this.aPromotion.editedPromotion = new Promotion();
            }
            if (this.aPromotion.promotions != null)
            {
                this.aPromotion.promotions = this.aPromotion.promotions.Skip((PageId - 1) * proPageSize).Take(proPageSize);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Promotion(APromotion promotion)
        {
            Models.Promotion pro = new Models.Promotion();
            pro = promotion.editedPromotion;
            if (ModelState.IsValid)
            {
                if (pro != null)
                {
                    if (promotion.editedPromotion.id == 0)
                    {
                        db.Promotion.Add(pro);
                    }
                    else
                    {
                        Models.Promotion pd = db.Promotion.FirstOrDefault();
                        db.Entry(pd).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        db.SaveChanges();
                        db.Promotion.Update(pro);
                    }
                }
            }

            db.SaveChanges();
            updatePromotionList(1, "", "", 1);
            ModelState.Clear();

            // ViewBag.pName = aProduct.editedProduct.name;
            // ViewBag.Id=aProduct.editedProduct.id;
            ViewBag.isCreation = "Create";
            ViewBag.totalPage = Math.Ceiling(this.aPromotion.promotions.Count() / (double)proPageSize);

            return View(this.aPromotion);
        }

        public IActionResult News(int id, string search, string func, string sortOrder, int PageId)
        {
            updateNewsList(id, func, search, PageId);
            ViewBag.count = this.aNews.news.Count();
            ViewBag.totalPage = Math.Ceiling(this.aNews.news.Count() / (double)nPageSize);

            if (this.aNews.news != null)
            {
                this.aNews.news = this.aNews.news.Skip((PageId - 1) * proPageSize).Take(proPageSize);
            }
            ViewBag.isCreation = this.isCreation ? "Create" : "Edit";
            return View(aNews);
        }
        private void updateNewsList(int id, string func, string search, int PageId)
        {
            IEnumerable<News> news = db.News;
            if (search != null)
            {
                news = news.Where(p => p.id == Convert.ToInt32(search));
            }

            if (func == "details")
            {
                this.aNews.choosenNews = db.News.FirstOrDefault(p => p.id == id);
            }
            else if (func == "edit")
            {
                this.aNews.choosenNews = new News();
                this.aNews.editedNews = db.News.FirstOrDefault(p => p.id == id);
            }
            else if (func == "delete")
            {
                News p = db.News.FirstOrDefault(a => a.id == id);
                db.News.Remove(p);
                db.SaveChanges();
                this.aNews.choosenNews = new News();
            }
            else
            {
                this.aNews.choosenNews = new News();
                this.aNews.editedNews = new News();
            }
            this.aNews.news = news;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult News(ANews _news)
        {
            Models.News pro = new Models.News();
            pro = _news.editedNews;
            if (ModelState.IsValid)
            {
                if (pro != null)
                {
                    if (_news.editedNews.id == 0)
                    {
                        db.News.Add(pro);
                    }
                    else
                    {
                        Models.News pd = db.News.FirstOrDefault();
                        db.Entry(pd).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        db.SaveChanges();
                        db.News.Update(pro);
                    }
                }
            }

            db.SaveChanges();
            updateNewsList(1, "", "", 1);
            ModelState.Clear();

            // ViewBag.pName = aProduct.editedProduct.name;
            // ViewBag.Id=aProduct.editedProduct.id;
            ViewBag.isCreation = "Create";
            ViewBag.totalPage = Math.Ceiling(this.aNews.news.Count() / (double)nPageSize);

            return View(this.aNews);
        }
    }
    
}