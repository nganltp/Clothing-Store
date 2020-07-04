using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels.User;

namespace WebApplication2.Controllers.ViewModels.User
{
    public class UserController : Controller
    {
        private List<CatalogProduct> catalogproducts; // ds catalogp

        private List<Product> products;
        private List<ProductSize> productSizes;
        private List<Image> images;

        private bool isStart = true;
        private CatalogProductVM catalog; //ds catalogproductVM
        //private List<Product> cartProducts = new List<Product>();

        private ShoppingCart cart;
        private readonly ShopDatabaseContext db;

        public UserController(ShopDatabaseContext context)
        {
            this.db = context;
            products = db.Product.ToList();
            productSizes = db.ProductSize.ToList();
            images = db.Image.ToList();

            catalog = new CatalogProductVM();
            catalogproducts = new List<CatalogProduct>();
            cart = new ShoppingCart();

            initCatalog(products, productSizes, images);
        }

        private void initCatalog(IEnumerable<Product> products, IEnumerable<ProductSize> productSizes, IEnumerable<Image> images)

        {
            CatalogProduct catalogproduct;
            List<ProductSize> _size;
            List<Image> _image;
            catalogproducts.Clear();
            List<int> size_product = new List<int>();
            foreach (ProductSize s in productSizes)
            {
                size_product.Add(s.product);
            }
            string cat, subcat;
            foreach (Product p in products)
            {
                if (size_product.Contains(p.id))
                {
                    _size = productSizes.Where(s => s.product == p.id).ToList();
                    _image = images.Where(i => i.whose == (1000 + p.id)).ToList();
                    cat = p.category.Split('_')[0].ToUpper();
                    subcat = p.category.Split('_')[1].ToUpper();
                    catalogproduct = new CatalogProduct()
                    {
                        product = p,
                        productsizes = _size,
                        images = _image,
                        category = cat,
                        subCategory = subcat
                    };

                    catalogproducts.Add(catalogproduct);
                }
                this.catalog.products = catalogproducts;
                
                
            }
            if (isStart == true)
                {
                    this.catalog.wishProducts = new List<Product>();
                    this.catalog.cartProducts = new List<Product>();
                    isStart = false;
                }
        }


        public IActionResult Catalog(String dresses, String leggings, String bloudseAndshirts,
                String coatsAndjackets, String hoodiesAndsweats, String denim, String jeans, String jumpersAndcardigans,
                string size, int price, string deletion,
                string cart, string cartRemove, string wish, string wishRemove)
        {
            string old_size = catalog.size;
            string old_category = catalog.category;
            int old_price = catalog.price;
            bool c_size = false, c_cat = false, c_price = false;

            if (deletion != null && deletion != "")
            {
                if (deletion == "category")
                {
                    catalog.category = "";
                    c_cat = true;
                }
                if (deletion == "size")
                {
                    catalog.size = "";
                    c_size = true;
                }
                if (deletion == "price")
                {
                    catalog.price = 0;
                    c_price = true;
                }
            }

            products = db.Product.ToList();
            productSizes = db.ProductSize.ToList();

            /*string cat=catalog.category*/
            ;
            //string sz = catalog.size;
            //int pr = catalog.price;
            if (dresses != null && dresses != "")
            {
                products = products.Where(p => p.category.Contains(dresses)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;

            }
            if (leggings != null && leggings != "")
            {
                products = products.Where(p => p.category.Contains(leggings)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;


            }
            if (bloudseAndshirts != null && bloudseAndshirts != "")
            {
                products = products.Where(p => p.category.Contains(bloudseAndshirts)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;


            }
            if (coatsAndjackets != null && coatsAndjackets != "")
            {
                products = products.Where(p => p.category.Contains(coatsAndjackets)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;


            }
            if (hoodiesAndsweats != null && hoodiesAndsweats != "")
            {
                products = products.Where(p => p.category.Contains(hoodiesAndsweats)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;


            }
            if (denim != null && denim != "")
            {
                products = products.Where(p => p.category.Contains(denim)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;


            }
            if (jumpersAndcardigans != null && jumpersAndcardigans != "")
            {
                products = products.Where(p => p.category.Contains(jumpersAndcardigans)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;


            }
            if (jeans != null && jeans != "")
            {
                products = products.Where(p => p.category.Contains(jeans)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;

            }



            if (price == 1)
            {
                products = products.Where(p => Convert.ToInt32(p.price) >= 10 && Convert.ToInt32(p.price) <= 49).ToList();
                this.catalog.price = price;
                c_price = true;
            }
            else if (price == 2)
            {
                products = products.Where(p => Convert.ToInt32(p.price) >= 50 && Convert.ToInt32(p.price) <= 99).ToList();
                this.catalog.price = price;
                c_price = true;

            }
            else if (price == 3)
            {
                products = products.Where(p => Convert.ToInt32(p.price) >= 100 && Convert.ToInt32(p.price) <= 199).ToList();
                this.catalog.price = price;
                c_price = true;

            }
            else if (price == 4)
            {
                products = products.Where(p => Convert.ToInt32(p.price) >= 200).ToList();
                this.catalog.price = price;
                c_price = true;

            }

            if (size == "S" || size == "M" || size == "L" || size == "XL" || size == "2XL" || size == "One Size")
            {
                productSizes = productSizes.Where(s => s.size == size).ToList();
                this.catalog.size = size;
                c_size = true;

            }



            initCatalog(products, productSizes, images);
            if (c_price == false)
            {
                this.catalog.price = old_price;
            }
            if (c_size == false)
            {
                this.catalog.size = old_size;
            }
            if (c_cat == false)
            {
                this.catalog.category = old_category;
            }

            if(cart != null && cart != "") {
                Product pd = this.catalog.products.Where(p => p.product.id == Convert.ToInt32(cart)).FirstOrDefault().product;

                ////Item cd = new Item()
                ////{
                ////    product = pd.id,
                ////    cart = 
                ////};
                //this.catalog.cartProducts.Add(pd);
                //this.catalog.cartTotal +=pd.price;
                Item cp = new Item()
                {
                    product = pd.id,
                    cart = 1,
                    price = pd.price,
                    quantity = 1
                };
                db.Item.Add(cp);
                db.SaveChanges();

                this.catalog.items = db.Item.Where(i => i.cart == 1).ToList();
                List<int> pIds = new List<int>();
                foreach(var i in this.catalog.items)
                {
                    if (!pIds.Contains(i.product))
                    {
                        pIds.Add(i.product);
                    }
                }
                this.catalog.cartTotal = 0;
                foreach(var p in this.catalog.products)
                {
                    if (pIds.Contains(p.product.id))
                    {
                        this.catalog.cartProducts.Add(p.product);
                        this.catalog.cartTotal += p.product.price;

                    }
                }

            }
            if (cartRemove != null && cartRemove != "")
            {
                Product pd = this.catalog.products.Where(p => p.product.id == Convert.ToInt32(cartRemove)).FirstOrDefault().product;

                ////Item cd = new Item()
                ////{
                ////    product = pd.id,
                ////    cart = 
                ////};
                //this.catalog.cartProducts.Add(pd);
                //this.catalog.cartTotal +=pd.price;
                Item cp = db.Item.Where(i => i.product == pd.id).FirstOrDefault();
                db.Item.Remove(cp);
                db.SaveChanges();

                this.catalog.items = db.Item.Where(i => (i.cart == 1 && i.cart==1)).ToList();
                List<int> pIds = new List<int>();
                foreach (var i in this.catalog.items)
                {
                    if (!pIds.Contains(i.product))
                    {
                        pIds.Add(i.product);
                    }
                }
                this.catalog.cartTotal = 0;
                foreach (var p in this.catalog.products)
                {
                    if (pIds.Contains(p.product.id))
                    {
                        this.catalog.cartProducts.Add(p.product);
                        this.catalog.cartTotal += p.product.price;

                    }
                }
            }

            if (wish != null && wish != "")
            {
                Product pd = this.catalog.products.Where(p => p.product.id == Convert.ToInt32(wish)).FirstOrDefault().product;

                ////Item cd = new Item()
                ////{
                ////    product = pd.id,
                ////    cart = 
                ////};
                //this.catalog.cartProducts.Add(pd);
                //this.catalog.cartTotal +=pd.price;
                Item cp = new Item()
                {
                    product = pd.id,
                    order = 1,
                    price = pd.price,
                    quantity = 1
                };
                db.Item.Add(cp);
                db.SaveChanges();

                this.catalog.items = db.Item.Where(i => i.order == 1).ToList();
                List<int> pIds = new List<int>();
                foreach (var i in this.catalog.items)
                {
                    if (!pIds.Contains(i.product))
                    {
                        pIds.Add(i.product);
                    }
                }
                this.catalog.wishTotal = 0;
                foreach (var p in this.catalog.products)
                {
                    if (pIds.Contains(p.product.id))
                    {
                        this.catalog.wishProducts.Add(p.product);
                        this.catalog.wishTotal += p.product.price;

                    }
                }
            }
            if (wishRemove != null && wishRemove != "")
            {
                Product pd = this.catalog.products.Where(p => p.product.id == Convert.ToInt32(wishRemove)).FirstOrDefault().product;

                ////Item cd = new Item()
                ////{
                ////    product = pd.id,
                ////    cart = 
                ////};
                //this.catalog.cartProducts.Add(pd);
                //this.catalog.cartTotal +item=pd.price;
                Item cp = db.Item.Where(i => (i.product == pd.id && i.order == 1)).FirstOrDefault();
                db.Item.Remove(cp);
                db.SaveChanges();

                this.catalog.items = db.Item.Where(i => i.cart == 1).ToList();
                List<int> pIds = new List<int>();
                foreach (var i in this.catalog.items)
                {
                    if (!pIds.Contains(i.product) && i.order == 1)
                    {
                        pIds.Add(i.product);
                    }
                }
                this.catalog.wishTotal = 0;
                foreach (var p in this.catalog.products)
                {
                    if (pIds.Contains(p.product.id))
                    {
                        this.catalog.wishProducts.Add(p.product);
                        this.catalog.wishTotal += p.product.price;

                    }
                }


            }


            return View(this.catalog);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
    }
}
