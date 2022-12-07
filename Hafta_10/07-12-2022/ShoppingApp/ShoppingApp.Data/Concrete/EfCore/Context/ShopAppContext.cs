using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Config;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Context
{
    public class ShopAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Prdocuts { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }// Bunu buraya yazdık uygulama içinde belki kullanbilriiz zaman zaman

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =ShoppingApp.db ");// Db uzantısı verilmeli
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // burada Configurationlarımızı uygulayacağız.
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
        }
    }
}
