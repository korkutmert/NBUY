﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proje05_MVC_Efcore_CodeFirst.Models;

#nullable disable

namespace Proje05_MVC_Efcore_CodeFirst.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("Proje05_MVC_Efcore_CodeFirst.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desc = "phones",
                            Name = "Phone"
                        },
                        new
                        {
                            Id = 2,
                            Desc = "Tablets",
                            Name = "Tablet"
                        },
                        new
                        {
                            Id = 3,
                            Desc = "Computers",
                            Name = "Computer"
                        });
                });

            modelBuilder.Entity("Proje05_MVC_Efcore_CodeFirst.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Citys");

                    b.HasData(
                        new
                        {
                            Id = 34,
                            Name = "İstnabul"
                        },
                        new
                        {
                            Id = 35,
                            Name = "İzmir"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Yalova"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Rize"
                        });
                });

            modelBuilder.Entity("Proje05_MVC_Efcore_CodeFirst.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Desc = "phones",
                            Name = "iphone",
                            Price = 15000m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Desc = "pc",
                            Name = "Dell",
                            Price = 12000m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Desc = "phones",
                            Name = "Samsung",
                            Price = 15000m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Desc = "tablet",
                            Name = "Piranha",
                            Price = 1000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}