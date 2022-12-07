using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id); // Bu komut ile ; Id yi primary Key yapmış olduk.
            builder.Property(c => c.Id).ValueGeneratedOnAdd();// Bu sayede ıd 1 er 1 er artacak.

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);// Zorunlu ve max uzunluk 50 olsun dedik.

            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);

            builder.Property(c => c.Url).IsRequired().HasMaxLength(250);

            builder.ToTable("Categories");

            builder.HasData(
                new Category
                    {
                    Id = 1,
                    Name = "Telefon",
                    Description = "Telefonlar bu kategoride yer almaktadır.",
                    Url = "telefon"
                    },

                new Category
                    {
                      Id = 2,
                      Name = "Elektronik",
                      Description = "Elektronik eşyalar bu kategoride yer almaktadır.",
                      Url = "elektronik"
                    },

                new Category
                    {
                      Id = 3,
                      Name = "Bilgisayar",
                      Description = "Bilgisayarlar bu kategoride yer almaktadır.",
                      Url = "bilgisayar"
                     },

                new Category
                     {
                      Id = 4,
                      Name = "Beyaz Eşya",
                      Description = "Beyaz eşyalar bu kategoride yer almaktadır.",
                      Url = "beyaz-esya"
                    }

                );
        }
    }
}
