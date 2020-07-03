using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            string cat, subcat;
            foreach (Product p in products)
            {
                _size = productSizes.Where(s=>s.product == p.id).ToList();
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

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Catalog(String dresses)
        {

            return View(this.catalog);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }


    }
}