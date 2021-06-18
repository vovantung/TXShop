using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXShop.Model.Models;

namespace TXShop.Data
{
    public class TXShopDbContext: DbContext
    {
        public TXShopDbContext() : base("TXShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Menu> menus { set; get; }
        public DbSet<MenuGroup> menuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
