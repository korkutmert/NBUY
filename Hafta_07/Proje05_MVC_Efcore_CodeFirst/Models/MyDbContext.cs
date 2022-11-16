using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_Efcore_CodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<City> Citys  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = First.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>()//Çalışma esansında , veritababında categories 'e erişip çalşışır.
                                .HasData(
                                            new Category(){Id=1, Name="Phone",Desc="phones" },
                                            new Category(){Id=2, Name="Tablet",Desc="Tablets" },
                                            new Category(){Id=3, Name="Computer",Desc="Computers" }
                                           
                                        );

            modelBuilder.Entity<Product>()
                                .HasData(
                                            new Product(){Id=1, Name="iphone",Desc="phones", Price=15000, CategoryId=1 },
                                            new Product(){Id=2, Name="Dell",Desc="pc", Price=12000, CategoryId=3 },
                                            new Product(){Id=3, Name="Samsung",Desc="phones", Price=15000, CategoryId=1 },
                                            new Product(){Id=4, Name="Piranha",Desc="tablet", Price=1000, CategoryId=2 }
                                         
                                        );

            modelBuilder.Entity<City>()
                                .HasData(
                                            new City(){Id=34, Name="İstnabul" },
                                            new City(){Id=35, Name="İzmir" },
                                            new City(){Id=77, Name="Yalova"},
                                            new City(){Id=53, Name="Rize"}
                                         
                                        );
         }   
    }
}