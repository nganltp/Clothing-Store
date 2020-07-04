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
        private List<CatalogProduct> catalogproducts = new List<CatalogProduct>(); // ds catalogp

        private List<Product> products;
        private List<ProductSize> productSizes;
        private List<Image> images;

        private CatalogProductVM catalog = new CatalogProductVM(); //ds catalogproductVM

        private readonly ShopDatabaseContext db;

        public UserController(ShopDatabaseContext context)
        {
            this.db = context;
            products = db.Product.ToList();
            productSizes = db.ProductSize.ToList();
            images = db.Image.ToList();

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
        }


            public IActionResult Catalog(String dresses, String leggings, String bloudseAndshirts,
                    String coatsAndjackets, String hoodiesAndsweats, String denim, String jeans, String jumpersAndcardigans,
                    string size, int price, string deletion)
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
            return View(this.catalog);
            }
        
        }
    }
