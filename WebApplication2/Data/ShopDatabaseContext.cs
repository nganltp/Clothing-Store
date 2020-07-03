using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ShopDatabaseContext : DbContext
    {
        public ShopDatabaseContext (DbContextOptions<ShopDatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication2.Models.Address> Address { get; set; }
        public DbSet<WebApplication2.Models.Admin> Admin { get; set; }
        public DbSet<WebApplication2.Models.Comment> Comment { get; set; }
        public DbSet<WebApplication2.Models.Customer> Customer { get; set; }
        public DbSet<WebApplication2.Models.Image> Image { get; set; }
        public DbSet<WebApplication2.Models.Item> Item { get; set; }
        public DbSet<WebApplication2.Models.News> News { get; set; }
        public DbSet<WebApplication2.Models.Order> Order { get; set; }
        public DbSet<WebApplication2.Models.Payment> Payment { get; set; }
        public DbSet<WebApplication2.Models.Product> Product { get; set; }
        public DbSet<WebApplication2.Models.ProductSize> ProductSize { get; set; }
        public DbSet<WebApplication2.Models.Promotion> Promotion { get; set; }
        public DbSet<WebApplication2.Models.ShoppingCart> ShoppingCart { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    id = 1,
                    whose = 1001,
                    content = "https://dynamic.zacdn.com/zvk_pURuBf0qebzA1ki7tOeAFQ0=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/forcast-3385-1064121-1.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 2,
                    whose = 1002,
                    content = "https://dynamic.zacdn.com/kPyjMLscmoN9zhFOFlNZmKzhEqE=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-basics-7289-908288-1.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 3,
                    whose = 1003,
                    content = "https://dynamic.zacdn.com/PXAZe_2vxNQm5-Gwklv1XXB1BZA=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-5887-342268-1.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 4,
                    whose = 1004,
                    content = "https://dynamic.zacdn.com/fVn7okqR8Fv_aPBqGArtyykeP1g=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/r-a-f-by-plains-prints-0623-4461951-2.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 5,
                    whose = 1005,
                    content = "https://dynamic.zacdn.com/svO5p4CWSaTfAvwr7_8RJUdpBp4=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/dorothy-perkins-3322-636078-2.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 6,
                    whose = 1006,
                    content = "https://dynamic.zacdn.com/Gn_53BkdgO_0agFVlmTo_wFrQiQ=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-9164-5696121-2.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 7,
                    whose = 1007,
                    content = "https://dynamic.zacdn.com/GE730BaW3zNJRovgiUEpUyyGGGo=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-0075-138559-1.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 8,
                    whose = 1008,
                    content = "https://dynamic.zacdn.com/GSDNBe3hVxb-pygRjSFnKS2qa7Y=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/cole-vintage-4379-5930361-1.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 9,
                    whose = 1009,
                    content = "https://dynamic.zacdn.com/O0Dk13WyWc8YVbOAzrq9wFxJf54=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/wallis-8725-031539-1.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }, new Image
                {
                    id = 10,
                    whose = 1010,
                    content = "https://dynamic.zacdn.com/iVq4A_CjMo3tbUTJPyvTHTv7QFg=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/bardot-9307-5647951-2.jpg",
                    format = "jpg",
                    created = DateTime.Parse("2020-07-03")
                }
            );

           modelBuilder.Entity<ProductSize>().HasData(
               new ProductSize 
               { 
                   id = 1, 
                   product = 1, 
                   size = "S" ,
                   quantity = "900"
               }, new ProductSize
               {
                   id = 2,
                   product = 1,
                   size = "L",
                   quantity = "100"
               }, new ProductSize
               {
                   id = 3,
                   product = 1,
                   size = "One Size",
                   quantity = "1000"
               }, new ProductSize
               {
                   id = 4,
                   product = 10,
                   size = "S",
                   quantity = "50"
               }, new ProductSize
               {
                   id = 5,
                   product = 2,
                   size = "M",
                   quantity = "2000"
               }, new ProductSize
               {
                   id = 6,
                   product = 2,
                   size = "2XL",
                   quantity = "1000"
               }, new ProductSize
               {
                   id = 7,
                   product = 2,
                   size = "L",
                   quantity = "500"
               }, new ProductSize
               {
                   id = 8,
                   product = 3,
                   size = "2XL",
                   quantity = "800"
               }, new ProductSize
               {
                   id = 9,
                   product = 3,
                   size = "XL",
                   quantity = "600"
               }, new ProductSize
               {
                   id = 10,
                   product = 3,
                   size = "S",
                   quantity = "100"
               }, new ProductSize
               {
                   id = 11,
                   product = 4,
                   size = "XL",
                   quantity = "50"
               }, new ProductSize
               {
                   id = 12,
                   product = 4,
                   size = "2XL",
                   quantity = "800"
               }, new ProductSize
               {
                   id = 13,
                   product = 4,
                   size = "2XL",
                   quantity = "150"
               }, new ProductSize
               {
                   id = 14,
                   product = 5,
                   size = "S",
                   quantity = "60"
               }, new ProductSize
               {
                   id = 15,
                   product = 5,
                   size = "L",
                   quantity = "400"
               }, new ProductSize
               {
                   id = 16,
                   product = 5,
                   size = "XL",
                   quantity = "900"
               }, new ProductSize
               {
                   id = 17,
                   product = 6,
                   size = "2XL",
                   quantity = "150"
               }, new ProductSize
               {
                   id = 18,
                   product = 6,
                   size = "S",
                   quantity = "50"
               }, new ProductSize
               {
                   id = 19,
                   product = 6,
                   size = "M",
                   quantity = "50"
               }, new ProductSize
               {
                   id = 20,
                   product = 7,
                   size = "2XL",
                   quantity = "150"
               }, new ProductSize
               {
                   id = 21,
                   product = 7,
                   size = "XL",
                   quantity = "200"
               }, new ProductSize
               {
                   id = 22,
                   product = 7,
                   size = "One Size",
                   quantity = "1000"
               }, new ProductSize
               {
                   id = 23,
                   product = 8,
                   size = "L",
                   quantity = "80"
               }, new ProductSize
               {
                   id = 24,
                   product = 8,
                   size = "XL",
                   quantity = "400"
               }, new ProductSize
               {
                   id = 25,
                   product = 8,
                   size = "2XL",
                   quantity = "50"
               }, new ProductSize
               {
                   id = 26,
                   product = 9,
                   size = "M",
                   quantity = "300"
               }, new ProductSize
               {
                   id = 27,
                   product = 9,
                   size = "S",
                   quantity = "500"
               }, new ProductSize
               {
                   id = 28,
                   product = 10,
                   size = "S",
                   quantity = "400"
               }, new ProductSize
               {
                   id = 29,
                   product = 10,
                   size = "M",
                   quantity = "400"
               }, new ProductSize
               {
                   id = 30,
                   product = 10,
                   size = "L",
                   quantity = "50"
               }
           );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                id = 1,
                name = "Karsyn A-Line Dress",
                supplier = "FORCAST",
                summary = "SOLD BY ZALORA",
                description = "Lined, Round neckline, Regular fit, Front button and back zip fastening",
                price = 5049,
                category = "dress_a lined"
            },
            new Product
            {
                id = 2,
                name = "Essential Raglan Sleeve Shift Dress",
                supplier = "ZALORA BASICS",
                summary = "SOLD BY ZALORA",
                description = "Raglan sleeve shift dress, Round neckline, Unlined, Relaxed fit, Polyblend",
                price = 749,
                category = "dress_shift"
            },
            new Product
            {
                id = 3,
                name = "Wrap Front Dress",
                supplier = "ZALORA",
                summary = "SOLD BY ZALORA",
                description = "Monochrome textured mini wrap dress, Lined, V neckline, Relaxed fit, Concealed back zip fastening, Front pleat detail",
                price = 489,
                category = "dress_wrap"
            },
            new Product
            {
                id = 4,
                name = "RAF Vinea Sleeveless Dress",
                supplier = "R.A.F. by Plains & Prints",
                summary = "SOLD BY ZALORA",
                description = "Floral print tie strap midi dress,  Sweetheart neckline, Self-tie straps,  Shirred back panel, Square back, Casual",
                price = 3298,
                category = "dress_maxi"
            },
            new Product
            {
                id = 5,
                name = "Shimmer Lace Shift Dress",
                supplier = "Dorothy Perkins",
                summary = "SOLD BY ZALORA",
                description = "Lace shift dress with bell sleeves, Lined, Fits true to size, take your usual size, Bateau neckline, Short sleeves, Back zipper fastening",
                price = 2795,
                category = "dress_shift"
            },
            new Product
            {
                id = 6,
                name = "Notches Detailed A-Line Dress",
                supplier = "ZALORA",
                summary = "SOLD BY ZALORA",
                description = "Sleeveless plain mini dress, Unlined, V neckline,  Regular fit, Zip fastening, Polyblend",
                price = 479,
                category = "dress_a lined"
            },
            new Product
            {
                id = 7,
                name = "Studio Short Sleeve Wrap Dress",
                supplier = "ZALORA",
                summary = "SOLD BY ZALORA",
                description = "Floral printed shirt dress, Collared neckline, Lined, Regular fit, Waist tie fastening, Polyblend",
                price = 1439,
                category = "dress_wrap"
            },
            new Product
            {
                id = 8,
                name = "Zia Midi Dress",
                supplier = "Cole Vintag",
                summary = "SOLD BY ZALORA",
                description = "Frilled hem high necklined shift midi dress, High neckline, Unlined, Back button keyhole fastening, Sleeveless, Evening",
                price = 1899,
                category = "dress_maxi"
            },
            new Product
            {
                id = 9,
                name = "Petite Monochrome Geometric Print Wrap Dress",
                supplier = "Wallis",
                summary = "SOLD BY ZALORA",
                description = "Printed mini dress with flute sleeves, V neckline, Unlined, Regular fit, Waist tie fastening,  Polyblend",
                price = 3089,
                category = "dress_wrap"
            },
            new Product
            {
                id = 10,
                name = "Estelle Drape Dress",
                supplier = "Bardot",
                summary = "SOLD BY ZALORA",
                description = "Sheeny open back drape dress, Cowl neckline, Regular fit, Invisible back zipper fastening, Back self tie fastening, Polyester blend",
                price = 3249,
                category = "dress_maxi"
            });


        }
    }
}
