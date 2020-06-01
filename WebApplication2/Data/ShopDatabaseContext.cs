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

    }
}
