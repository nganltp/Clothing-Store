using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        private static List<string> category_filters;
        private static List<string> size_filters;
        private static List<int> price_filters;

        private static List<Product> cart_products;
        private static List<Product> wish_products;
        private static List<ItemForm> cart_items;
        private static List<Product> detail_products;
        private static List<Image> cart_images;
        private static List<Image> wish_images;
        private static List<Image> detail_images;

        private static CatalogProductVM catalog; //ds catalogproductVM
        private LoginVM login = new LoginVM();
        private static PersonalAccountVM account;
        private static PersonalAddressVM address;
        private static CheckOutVM checkOut;

        private readonly ShopDatabaseContext db;
        private static Customer customer;

        public UserController(ShopDatabaseContext context)
        {
            this.db = context;
            products = db.Product.ToList();
            productSizes = db.ProductSize.ToList();
            images = db.Image.ToList();
            if (category_filters == null || category_filters.Count() == 0)
            {
                category_filters = new List<string>();
            }
            if (size_filters == null || size_filters.Count() == 0)
            {
                size_filters = new List<string>();
            }
            if (price_filters == null || price_filters.Count() == 0)
            {
                price_filters = new List<int>();
            }

            if (cart_products == null || cart_products.Count() == 0)
            {
                cart_products = new List<Product>();
            }
            if (cart_items == null || cart_items.Count == 0)
            {
                cart_items = new List<ItemForm>();
            }
            if (wish_products == null || wish_products.Count() == 0)
            {
                wish_products = new List<Product>();
            }
            if (detail_products == null || detail_products.Count() == 0)
            {
                detail_products = new List<Product>();
            }
            if (cart_images == null || cart_images.Count() == 0)
            {
                cart_images = new List<Image>();
            }
            if (wish_images == null || wish_images.Count() == 0)
            {
                wish_images = new List<Image>();
            }
            if (detail_images == null || detail_images.Count() == 0)
            {
                detail_images = new List<Image>();
            }
            if (customer == null)
            {
                account = new PersonalAccountVM()
                {
                    customer = new Customer()
                    {
                        id = 0,
                        username = ""
                    },
                    first_name = "",
                    last_name = "",
                    date = 1,
                    id = 0
                };

                address = new PersonalAddressVM()
                {
                    addresses = new List<Address>(),
                    company_name = "",
                    country = "",
                    address_line_1="",
                    address_line_2="",
                    city="",
                    ZIPcode="",
                    mobile_phone="",
                };
            } else
            {
                account = new PersonalAccountVM()
                {
                    customer = customer,
                    first_name = customer.fullName.Split('_')[0],
                    last_name = customer.fullName.Split('_')[1],
                    id = customer.id
                };
                address = new PersonalAddressVM()
                {
                    addresses = db.Address.Where(a => a.customer == customer.id).ToList(),
                    company_name = "",
                    country = "",
                    address_line_1 = "",
                    address_line_2 = "",
                    city = "",
                    ZIPcode = "",
                    mobile_phone = "",
                };
            }
            if(customer != null && customer.id != 0)
            {
                checkOut = new CheckOutVM();
                checkOut.last_name = customer.fullName.Split('_')[1];
                checkOut.first_name = customer.fullName.Split('_')[0];
                checkOut.email = customer.email;
                checkOut.order_items = new List<Product>();
                checkOut.itemForms = new List<ItemForm>();

                List<Address> adds = db.Address.Where(a => a.customer == customer.id).ToList();
                if (adds.Count!=0 ){
                    Address defa = adds.Where(a => a.isDefaultAddress == true).FirstOrDefault();
                    if (defa == null)
                    {
                        defa = adds[0];
                    }
                    checkOut.company_name = defa.detail.Split('_')[0];
                    checkOut.address_line_1 = defa.detail.Split('_')[1];
                    checkOut.address_line_2 = defa.detail.Split('_')[2];
                    checkOut.city = defa.detail.Split('_')[3];
                    checkOut.country = defa.detail.Split('_')[4];
                    checkOut.mobile_phone = defa.phone;
                }
                
            }
            else
            {
                checkOut = new CheckOutVM();
                checkOut.order_items = new List<Product>();
                checkOut.itemForms = new List<ItemForm>();
            }
            if (customer == null)
            {
                customer = new Customer()
                {
                    fullName="_",
                    id = 0,
                };
            }
            if (login == null)
            {
                login = new LoginVM()
                {
                    username = "",
                    password = "",
                    isLoggedIn = false,
                };
            }
            if(catalog == null)
            {
                catalog = new CatalogProductVM();
                catalog.items = new List<ItemForm>();
            }
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
            }
            catalog.products = catalogproducts;
            if (catalog.sort == "asc-price")
            {
                catalog.products.Sort((a, b) => Convert.ToInt32(a.product.price).CompareTo(Convert.ToInt32(b.product.price)));

            }
            else if (catalog.sort == "desc-price")
            {
                catalog.products.Sort((a, b) => Convert.ToInt32(b.product.price).CompareTo(Convert.ToInt32(a.product.price)));
            }
            else
            {
                catalog.products.Sort((a, b) => a.product.name.CompareTo(b.product.name));
            }
        }


        public IActionResult Catalog(String dresses, String leggings, String bloudseAndshirts,
                    String coatsAndjackets, String hoodiesAndsweats, String denim, String jeans, String jumpersAndcardigans,
                    string size, int price, string deletion, string subcat, string subsize, int subprice, int cpId, int wpId,
                    int cart_remove, int wish_remove, int dpId, string sort)
            {


            if (cart_remove != 0)
            {
                //Product cp = db.Product.Where(p => p.id == cart_remove).FirstOrDefault();
                int ind = cart_products.IndexOf(cart_products.Where(p => p.id == cart_remove).FirstOrDefault());
                cart_products.RemoveAt(ind);
                cart_images.RemoveAt(ind);
                cart_items.RemoveAt(ind);
            }
            if (wish_remove != 0)
            {
                //Product cp = db.Product.Where(p => p.id == wish_remove).FirstOrDefault();
                int ind = wish_products.IndexOf(wish_products.Where(p => p.id == wish_remove).FirstOrDefault());
                wish_products.RemoveAt(ind);
                wish_images.RemoveAt(ind);
            }
            if (cpId != 0)
            {
                //Product cp = db.Product.Where(p => p.id == cpId).FirstOrDefault();
                if (!cart_products.Contains(cart_products.Where(p => p.id == cpId).FirstOrDefault()))
                {
                    cart_products.Add(db.Product.Where(p => p.id == cpId).FirstOrDefault());
                    cart_images.Add(db.Image.Where(p => p.whose == (1000+cpId)).FirstOrDefault());
                    ItemForm iform = new ItemForm()
                    {
                        product = cpId,
                        price = Convert.ToInt32(db.Product.Where(p => p.id == cpId).FirstOrDefault().price),
                        quantity = 1,
                        sizes = db.ProductSize.Where(p => p.product == cpId).ToList(),
                    };
                    cart_items.Add(iform);
            }
        }
            if (wpId != 0)
            {
                //Product wp = db.Product.Where(p => p.id == wpId).FirstOrDefault();
                if (!wish_products.Contains(wish_products.Where(p => p.id == wpId).FirstOrDefault()))
                {
                    wish_products.Add(db.Product.Where(p => p.id == wpId).FirstOrDefault());
                    wish_images.Add(db.Image.Where(p => p.whose == (1000+wpId)).FirstOrDefault());

                }
            }
            if (dpId != 0)
            {
                if (!detail_products.Contains(detail_products.Where(d=>d.id == dpId).FirstOrDefault()))
                {
                    detail_products.Add(db.Product.Where(d => d.id == dpId).FirstOrDefault());
                    detail_images.Add(db.Image.Where(d => d.whose == (1000 + dpId)).FirstOrDefault());
                }
            }
            

            if (deletion != null && deletion != "")
                {
                    if (deletion == "category")
                    {
                        //catalog.category = "";
                        //c_cat = true;
                        category_filters.Remove(subcat.ToLower());
                    }
                    if (deletion == "size")
                    {
                        //catalog.size = "";
                        //c_size = true;
                        size_filters.Remove(subsize);
                    }
                    if (deletion == "price")
                    {
                        //catalog.price = 0;
                        //c_price = true;
                        price_filters.Remove(subprice);
                    }
                }
            if ( price != 0 && !price_filters.Contains(price))
            {
                price_filters.Add(price);
            }
            if (size != null && size!="" && !size_filters.Contains(size))
            {
                size_filters.Add(size);
            }
            if (dresses != null && dresses != "" && !category_filters.Contains(dresses))
            {
                category_filters.Add(dresses);
            }
            List<Product> priced_products = new List<Product>();
            products = new List<Product>();
            productSizes = new List<ProductSize>();

            if (price_filters == null || price_filters.Count() == 0)
            {
                priced_products = db.Product.ToList();
            }
            else
            {
            foreach (var p in price_filters)
            {
                if (p == 1)
                {
                    List<Product> pds = db.Product.Where(s => (Convert.ToInt32(s.price)) >= 10 && (Convert.ToInt32(s.price)) <= 49).ToList();
                    priced_products.AddRange(pds);
                }
                else if (p == 2)
                {
                    List<Product> pds = db.Product.Where(s => (Convert.ToInt32(s.price)) >= 50 && (Convert.ToInt32(s.price)) <= 99).ToList();
                    priced_products.AddRange(pds);
                }
                else if (p == 3)
                {
                    List<Product> pds = db.Product.Where(s => (Convert.ToInt32(s.price)) >= 100 && (Convert.ToInt32(s.price)) <= 199).ToList();
                    priced_products.AddRange(pds);
                }
                else if (p == 4)
                {
                    List<Product> pds = db.Product.Where(s => (Convert.ToInt32(s.price)) >= 200).ToList();
                    priced_products.AddRange(pds);
                }
                
                //catalog.size = size;
            }
            }
            
               
            if (size_filters == null || size_filters.Count() == 0)
            {
                productSizes = db.ProductSize.ToList();
            }
            else
            {
                foreach (string s in size_filters){
                    List<ProductSize> sz = db.ProductSize.Where(_s => _s.size == s).ToList();
                    productSizes.AddRange(sz);
                }
            }
            if (category_filters == null || category_filters.Count() == 0)
            {
                products = priced_products;
            }
            else
            {
                foreach (var c in category_filters)
                {
                    List<Product> _category = priced_products.Where(p => p.category.Contains(c.ToLower())).ToList();
                    products.AddRange(_category);
                }
            }
            

            //

                /*string cat=catalog.category*/
                ;
                //string sz = catalog.size;
                //int pr = catalog.price;
                //if (dresses != null && dresses != "")
                //{
                //    products = products.Where(p => p.category.Contains(dresses)).ToList();
                //    catalog.category = dresses.ToUpper();
                //    category_filters.Add(dresses);

                //}
                if (leggings != null && leggings != "")
                {
                    products = products.Where(p => p.category.Contains(leggings)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

            products = db.Product.ToList();
            productSizes = db.ProductSize.ToList();

                }
                if (bloudseAndshirts != null && bloudseAndshirts != "")
                {
                    products = products.Where(p => p.category.Contains(bloudseAndshirts)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

            }
            if (leggings != null && leggings != "")
            {
                products = products.Where(p => p.category.Contains(leggings)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;

                }
                if (coatsAndjackets != null && coatsAndjackets != "")
                {
                    products = products.Where(p => p.category.Contains(coatsAndjackets)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

            }
            if (bloudseAndshirts != null && bloudseAndshirts != "")
            {
                products = products.Where(p => p.category.Contains(bloudseAndshirts)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;

                }
                if (hoodiesAndsweats != null && hoodiesAndsweats != "")
                {
                    products = products.Where(p => p.category.Contains(hoodiesAndsweats)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

            }
            if (coatsAndjackets != null && coatsAndjackets != "")
            {
                products = products.Where(p => p.category.Contains(coatsAndjackets)).ToList();
                catalog.category = dresses.ToUpper();
                c_cat = true;

                }
                if (denim != null && denim != "")
                {
                    products = products.Where(p => p.category.Contains(denim)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

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
                    products = products.Where(p => p.category.Contains(jumpersAndcardigans)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

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
                    products = products.Where(p => p.category.Contains(jeans)).ToList();
                    //catalog.category = dresses.ToUpper();
                    //c_cat = true;

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

                //if (price == 1)
                //{
                //    products = products.Where(p => Convert.ToInt32(p.price) >= 10 && Convert.ToInt32(p.price) <= 49).ToList();
                //    catalog.price = price;
                //    c_price = true;
                    
                //}
                //else if (price == 2)
                //{
                //    products = products.Where(p => Convert.ToInt32(p.price) >= 50 && Convert.ToInt32(p.price) <= 99).ToList();
                //    catalog.price = price;
                //    c_price = true;

                //}
                //else if (price == 3)
                //{
                //    products = products.Where(p => Convert.ToInt32(p.price) >= 100 && Convert.ToInt32(p.price) <= 199).ToList();
                //    catalog.price = price;
                //    c_price = true;

                //}
                //else if (price == 4)
                //{
                //    products = products.Where(p => Convert.ToInt32(p.price) >= 200).ToList();
                //    catalog.price = price;
                //    c_price = true;

                //}

                //if (size == "S" || size == "M" || size == "L" || size == "XL" || size == "2XL" || size == "One Size")
                //{
                //    productSizes = productSizes.Where(s => s.size == size).ToList();
                //    catalog.size = size;
                //    c_size = true;

                //}



                initCatalog(products, productSizes, images);
            catalog.price_filters = price_filters;
            catalog.size_filters = size_filters;
            catalog.category_filters = category_filters;
            catalog.cart_product = cart_products;
            catalog.wish_product = wish_products;
            catalog.wish_images = wish_images;
            catalog.cart_images = cart_images;
            catalog.detail_images = detail_images;
            catalog.detail_product = detail_products;
            catalog.items = cart_items;

           
            //if (c_price == false)
            //{
            //    catalog.price = old_price;
            //}
            //if (c_size == false)
            //{
            //    catalog.size = old_size;
            //}
            //if (c_cat == false)
            //{
            //    catalog.category = old_category;
            //}
            return View(catalog);
            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Catalog(CatalogProductVM _catatlog)
        {
            if(_catatlog.sort==null || _catatlog.sort == "")
            {
            catalog.items = _catatlog.items;
            checkOut.itemForms = catalog.items;
                return RedirectToAction("Checkout", "User");

            }
            else
            {
                catalog.sort = _catatlog.sort;
                if (catalog.sort == "asc-price")
                {
                    catalog.products.Sort((a, b) => Convert.ToInt32(a.product.price).CompareTo(Convert.ToInt32(b.product.price)));

                }
                else if (catalog.sort == "desc-price")
                {
                    catalog.products.Sort((a, b) => Convert.ToInt32(b.product.price).CompareTo(Convert.ToInt32(a.product.price)));
                }
                else
                {
                    catalog.products.Sort((a, b) => a.product.name.CompareTo(b.product.name));
                }
                return View(catalog);
            }


        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            checkOut.order_items = catalog.cart_product;
            checkOut.itemForms = catalog.items;
            checkOut.images = catalog.cart_images;
            if(checkOut.order_items!=null && checkOut.order_items.Count != 0)
            {
            foreach(Product p in checkOut.order_items)
            {
                checkOut.total += Convert.ToInt32(p.price)*checkOut.itemForms[checkOut.order_items.IndexOf(p)].quantity;
            }
            }
            
            return View(checkOut);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout(CheckOutVM _checkout)
        {
            checkOut = _checkout;
            int idCus, idAdd;
            if(customer==null || customer.id == 0)
            {
                Customer cus = new Customer()
                {
                    fullName = _checkout.first_name + "_" + _checkout.last_name,
                    email = _checkout.email
                };
                db.Customer.Add(cus);
                db.SaveChanges();
                Address add = new Address()
                {
                    customer = cus.id,
                    detail = _checkout.company_name + "_" + _checkout.address_line_1 + "_" + _checkout.address_line_2 + "_" + _checkout.city + "_" + _checkout.country,
                    phone = _checkout.mobile_phone
                };
                db.Address.Add(add);
                db.SaveChanges();
                idCus = cus.id;
                idAdd = add.id;

            }
            else
            {
                idCus = customer.id;
                List<Address> c = db.Address.Where(a => a.customer == customer.id).ToList();
                if (c.Count != 0)
                {
                    Address defa = c.Where(a => a.isDefaultAddress == true).FirstOrDefault();
                    if (defa == null)
                    {
                        idAdd = c[0].id;
                    }
                    else
                    {
                        idAdd = defa.id;
                    }
                }
                else
                {
                    Address add = new Address()
                    {
                        customer = customer.id,
                        detail = _checkout.company_name + "_" + _checkout.address_line_1 + "_" + _checkout.address_line_2 + "_" + _checkout.city + "_" + _checkout.country,
                        phone = _checkout.mobile_phone
                    };
                    db.Address.Add(add);
                    db.SaveChanges();
                    idAdd = add.id;
                }
            }
            Order ord = new Order()
            {
                customer = idCus,
                ordered = DateTime.Now,
                address = idAdd.ToString(),
                total = checkOut.total
            };
            db.Order.Add(ord);
            db.SaveChanges();


            if (checkOut.order_items != null)
            {
                foreach(var p in checkOut.order_items)
                {
                    Item i = new Item();
                    i.order = ord.id;
                    i.product = p.id;
                    i.quantity = checkOut.itemForms[checkOut.order_items.IndexOf(p)].quantity;
                    i.price = Convert.ToInt32(p.price) * i.quantity;
                    db.Item.Add(i);
                    db.SaveChanges();
                }
                
            }

            catalog.cart_product = new List<Product>();
            catalog.cart_images = new List<Image>();
            
            checkOut.images = catalog.cart_images;
            checkOut.order_items = catalog.cart_product;
            
            return RedirectToAction("Order", "User");
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult PersonalAccount()
        {

            return View(account);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PersonalAccount(PersonalAccountVM accountVM)
        {
            Customer c = accountVM.customer;
            string first_name = accountVM.first_name;
            string last_name = accountVM.last_name;
            string new_password = accountVM.new_password;

            int date;
            int month;
            switch (accountVM.month)
            {
                case "January":
                    month = 1;
                    break;
                case "Febuary":
                    month = 2;
                    break;
                case "March":
                    month = 3;
                    break;
                case "April":
                    month = 4;
                    break;
                case "May":
                    month = 5;
                    break;
                case "June":
                    month = 6;
                    break;
                case "July":
                    month = 7;
                    break;
                case "August":
                    month = 8;
                    break;
                case "September":
                    month = 9;
                    break;
                case "October":
                    month = 10;
                    break;
                case "November":
                    month = 11;
                    break;
                case "December":
                default:
                    month = 12;
                    break;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    date = accountVM.date;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (accountVM.date > 30)
                    {
                        date = 30;
                    }
                    else
                    {
                        date = accountVM.date;
                    }
                    break;
                case 2:
                default:
                    if (accountVM.date > 28)
                    {
                        date = 28;
                    }
                    else
                    {
                        date = accountVM.date;
                    }
                    break;
            }
            int year = accountVM.year;
            string gender = accountVM.gender;

            if (ModelState.IsValid)
            {
                if (accountVM.customer != null)
                {
                    

                    if (account.customer.id == 0)
                    {
                        Customer customer = new Customer();
                        customer.fullName = first_name + "_" + last_name;
                        customer.email = c.email;
                        customer.gender = gender == "Male" ? true : false;
                        customer.password = new_password;
                        DateTime birth = new DateTime(year, month, date);
                        customer.birth = birth;
                        customer.created = DateTime.Now;
                    customer.closed = DateTime.Now;
                    customer.username = accountVM.customer.username;
                     db.Customer.Add(customer);
                     db.SaveChanges();


                    }
                    else
                    {
                        Customer customer = db.Customer.Where(_c=>_c.id==account.customer.id).FirstOrDefault();
                        customer.fullName = first_name + "_" + last_name;
                        customer.email = c.email;
                        customer.gender = gender == "Male" ? true : false;
                        if(new_password!="" || new_password != null)
                        {
                            customer.password = new_password;
                        }
                        DateTime birth = new DateTime(year, month, date);
                        customer.birth = birth;
                        customer.created = DateTime.Now;
                        customer.closed = DateTime.Now;
                        customer.username = accountVM.customer.username;
                        Customer cus = db.Customer.FirstOrDefault();
                        db.Entry(cus).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        db.SaveChanges();

                        db.Customer.Update(customer);
                        db.SaveChanges();

                    }

                }
            }
            account.new_password = "";
            return View(account);
        }

      
        public IActionResult PersonalAddress(int isDefault, int remove)
        {
            if (isDefault != 0)
            {
                List<Address> add = db.Address.Where(a => a.customer == customer.id).ToList();
                foreach(var a in add)
                {
                    Address cus = db.Address.FirstOrDefault();
                    db.Entry(cus).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                    db.SaveChanges();
                    if (a.id == isDefault)
                    {
                        a.isDefaultAddress = true;
                        db.Address.Update(a);
                        db.SaveChanges();
                    }
                    else
                    {
                        a.isDefaultAddress = false;
                        db.Address.Update(a);
                        db.SaveChanges();
                    }
                }
            }
            if (remove != 0)
            {
                Address add = db.Address.Where(a => a.id == remove).FirstOrDefault();
                try
                {
                db.Address.Remove(add);
                db.SaveChanges();
                    address.addresses = db.Address.Where(a => a.customer == customer.id).ToList();
                } catch(Exception e)
                {

                    }
                }
                
            }
            return View(address);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PersonalAddress(PersonalAddressVM _address)
        {
            if( _address.city!=null && _address.city != ""
                && _address.company_name != null && _address.company_name != ""
                && _address.country != null && _address.country != ""
                && _address.address_line_1 != null && _address.address_line_1 != ""
                && _address.address_line_2 != null && _address.address_line_2 != ""
                && _address.mobile_phone != null && _address.mobile_phone != ""
                )
            {
                if(customer != null && customer.id != 0)
                {
                    if (ModelState.IsValid)
                    {
                        Address add = new Address();
                        add.customer = customer.id;
                        add.phone = _address.mobile_phone;
                        add.detail = _address.company_name + "_" + _address.address_line_1 + "_" + _address.address_line_2 + "_"
                                    + _address.city+"_"+_address.country;
                        db.Address.Add(add);
                        db.SaveChanges();

                        address.addresses = db.Address.Where(a => a.customer == customer.id).ToList();
                        address.address_line_1 = "";
                        address.address_line_2 = "";
                        address.city = "";
                        address.company_name = "";
                        address.country = "";
                        address.mobile_phone = "";

                        checkOut = new CheckOutVM();
                        checkOut.last_name = customer.fullName.Split('_')[1];
                        checkOut.first_name = customer.fullName.Split('_')[0];
                        checkOut.email = customer.email;

                        List<Address> adds = db.Address.Where(a => a.customer == customer.id).ToList();
                        if (adds.Count != 0)
                        {
                            Address defa = adds.Where(a => a.isDefaultAddress == true).FirstOrDefault();
                            if (defa == null)
                            {
                                defa = adds[0];
                            }
                            checkOut.company_name = defa.detail.Split('_')[0];
                            checkOut.address_line_1 = defa.detail.Split('_')[1];
                            checkOut.address_line_2 = defa.detail.Split('_')[2];
                            checkOut.city = defa.detail.Split('_')[3];
                            checkOut.country = defa.detail.Split('_')[4];
                            checkOut.mobile_phone = defa.phone;
                        }
                    }
                    else
                    {
                        ViewBag.InvalidModelState = true;
                    }
                }
                else
                {
                    ViewBag.MissingAccount = true;
                }
            }
            else
            {
                ViewBag.MissingValues = true;
            }
            return View(address);
        }
        public IActionResult Logout()
        {
            return View(this.login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout(LoginVM _loggin)
        {
            if (ModelState.IsValid)
            {
                if (_loggin.username != null && _loggin.username != ""
                && _loggin.password != null && _loggin.password != "")
                {
                    Customer cus = db.Customer.Where(c => c.username == _loggin.username).FirstOrDefault();
                    if (cus.password == _loggin.password)
                    {
                        this.login.username = "";
                        this.login.password = "";
                        this.login.isLoggedIn = true;
                    }
                }
                else
                {
                    this.login.username = _loggin.username;
                    this.login.password = "";
                    this.login.isLoggedIn = false;
                }
            }
            if (this.login.isLoggedIn)
            {
                customer = db.Customer.Where(c => c.username == _loggin.username).FirstOrDefault();
                if (account == null)
                {
                    account = new PersonalAccountVM();
                }
                account.customer = customer;
                account.first_name = account.customer.fullName.Split('_')[0];
                account.last_name = account.customer.fullName.Split('_')[1];
                account.date = account.customer.birth.Day;
                account.year= account.customer.birth.Year;
                switch (customer.birth.Month)
                {
                    case 1:
                        account.month = "Janurary";
                            break;
                    case 2:
                        account.month = "Febuary";
                            break;;
                    case 3:
                        account.month = "March";
                            break;
                    case 4:
                        account.month = "April";
                            break;
                    case 5:
                        account.month = "May";
                            break;
                    case 6:
                        account.month = "June";
                            break;
                    case 7:
                        account.month = "July";
                            break;
                    case 8:
                        account.month = "August";
                            break;
                    case 9:
                        account.month = "September";
                            break;
                    case 10:
                        account.month = "October";
                            break;
                    case 11:
                        account.month = "November";
                            break;
                    default:
                        account.month = "December";
                        break;
                }

                account.gender = customer.gender==true ? "Male" : "Female";


                address.addresses = db.Address.Where(a => a.customer == customer.id).ToList();
                address.address_line_1 = "";
                address.address_line_2 = "";
                address.city = "";
                address.company_name = "";
                address.country = "";
                address.mobile_phone = "";

                checkOut = new CheckOutVM();
                checkOut.last_name = customer.fullName.Split('_')[1];
                checkOut.first_name = customer.fullName.Split('_')[0];
                checkOut.email = customer.email;

                List<Address> adds = db.Address.Where(a => a.customer == customer.id).ToList();
                if (adds.Count != 0)
                {
                    Address defa = adds.Where(a => a.isDefaultAddress == true).FirstOrDefault();
                    if (defa == null)
                    {
                        defa = adds[0];
                    }
                    checkOut.company_name = defa.detail.Split('_')[0];
                    checkOut.address_line_1 = defa.detail.Split('_')[1];
                    checkOut.address_line_2 = defa.detail.Split('_')[2];
                    checkOut.city = defa.detail.Split('_')[3];
                    checkOut.country = defa.detail.Split('_')[4];
                    checkOut.mobile_phone = defa.phone;
                }

                return RedirectToAction("Home", "User");
            }
            else
            {
                ViewBag.isUnsuccessful = true;
                return View(this.login);
            }

        }


    }
        
}
