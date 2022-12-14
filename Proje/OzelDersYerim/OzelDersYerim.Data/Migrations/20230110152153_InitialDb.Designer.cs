// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OzelDersYerim.Data.Concrete.EfCore.Context;

#nullable disable

namespace OzelDersYerim.Data.Migrations
{
    [DbContext(typeof(OzelDersYerimContext))]
    [Migration("20230110152153_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6d7d1e60-4a5e-448f-8893-9bae68e75fee",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "4f631c1c-445b-40c9-a1fe-e10df56aaff0",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "16df138b-7628-4b80-ae77-2e146b6b85cc",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "f51a33d9-90b7-4304-8f27-296121b22ed8",
                            RoleId = "16df138b-7628-4b80-ae77-2e146b6b85cc"
                        },
                        new
                        {
                            UserId = "36c1db42-7495-477f-921e-ba037f5188ed",
                            RoleId = "4f631c1c-445b-40c9-a1fe-e10df56aaff0"
                        },
                        new
                        {
                            UserId = "arzu",
                            RoleId = "16df138b-7628-4b80-ae77-2e146b6b85cc"
                        },
                        new
                        {
                            UserId = "serdar",
                            RoleId = "16df138b-7628-4b80-ae77-2e146b6b85cc"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Branches", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchName = "Matematik",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "mat.png",
                            Url = "matematik"
                        },
                        new
                        {
                            Id = 2,
                            BranchName = "Kimya",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "kimya.png",
                            Url = "kimya"
                        },
                        new
                        {
                            Id = 3,
                            BranchName = "İngilizce",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "ing.png",
                            Url = "ingilizce"
                        },
                        new
                        {
                            Id = 4,
                            BranchName = "Müzik",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "müzik.png",
                            Url = "muzik"
                        },
                        new
                        {
                            Id = 5,
                            BranchName = "Türkçe",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "turkce.png",
                            Url = "turkce"
                        },
                        new
                        {
                            Id = 6,
                            BranchName = "Bilgisayar",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "bilgisayar.png",
                            Url = "bilgisayar"
                        });
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f51a33d9-90b7-4304-8f27-296121b22ed8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a31a040-5445-4b63-bc19-95d10dc35462",
                            Email = "student@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d69dd39b-3353-4b35-b7eb-0cfc104c9f6e",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "36c1db42-7495-477f-921e-ba037f5188ed",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "92b520ca-07a2-45e9-a792-44d4501af7a5",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5b2f813f-889a-4738-baf3-228ca4d31b4a",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "arzu",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1bce61a4-7038-473e-bc53-53736cf0d200",
                            Email = "arzu@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95198115-a1ed-4951-811f-d882dbacf630",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "serdar",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7c44910-f720-4733-a7a8-2342ea3004c5",
                            Email = "serdar@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2f9034e-e4b0-45c5-9081-f08bf3f6cdc9",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "24 Yaşındayım.Yazılım eğitimi alıyorum.Yeni programlama dilleri üzerinde kendimi geliştirmek ve ders almak istiyorum.",
                            Age = "24",
                            FirstName = "Mert Korkut",
                            Gender = "Erkek",
                            LastName = "Muslu",
                            Location = "Kadıköy",
                            ProfilePictureUrl = "1.png",
                            Url = "ogrenci-mert-korkut-muslu",
                            UserId = "f51a33d9-90b7-4304-8f27-296121b22ed8"
                        });
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int?>("BranchId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("PricePerHour")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Mimar Sinan Güzel Sanatlar Üniversitesi Konservatuar mezunuyum. Uzmanlık alanım Piyano olamakla beraber keman ve gitar dersleri de vermekteyim.",
                            Age = "39",
                            Experience = "15",
                            FirstName = "Ahmet",
                            Gender = "Erkek",
                            IsHome = true,
                            LastName = "Yılmaz",
                            Location = "Beşiktaş",
                            PricePerHour = 450m,
                            ProfilePictureUrl = "10.png",
                            Url = "ogretmen-ahmet-yilmaz",
                            UserId = "36c1db42-7495-477f-921e-ba037f5188ed"
                        },
                        new
                        {
                            Id = 2,
                            About = "İngilizce Öğretmeniyim. Her türlü İngilizce sınavlarına hazırlık konusunda ders vermekteyim.",
                            Age = "27",
                            Experience = "5",
                            FirstName = "Arzu",
                            Gender = "Kadın",
                            IsHome = false,
                            LastName = "Doğramacı",
                            Location = "Şişli",
                            PricePerHour = 300m,
                            ProfilePictureUrl = "11.png",
                            Url = "ogretmen-arzu-dogramaci",
                            UserId = "arzu"
                        },
                        new
                        {
                            Id = 3,
                            About = "İlköğretim-lise düzeyinde matematik dersleri verilir. Sınavlar için fazladan etüt alabilirsiniz.",
                            Age = "42",
                            Experience = "",
                            FirstName = "Serdar",
                            Gender = "Erkek",
                            IsHome = false,
                            LastName = "Kulbilge",
                            Location = "Aksaray",
                            PricePerHour = 250m,
                            ProfilePictureUrl = "12.png",
                            Url = "ogretmen-serdar-kulbilge",
                            UserId = "serdar"
                        });
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.TeacherBranch", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BranchId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("TeacherBranches", (string)null);

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            BranchId = 1
                        },
                        new
                        {
                            TeacherId = 1,
                            BranchId = 2
                        },
                        new
                        {
                            TeacherId = 2,
                            BranchId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            BranchId = 2
                        },
                        new
                        {
                            TeacherId = 3,
                            BranchId = 1
                        },
                        new
                        {
                            TeacherId = 3,
                            BranchId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OzelDersYerim.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OzelDersYerim.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDersYerim.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OzelDersYerim.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Student", b =>
                {
                    b.HasOne("OzelDersYerim.Entity.Concrete.Identity.User", "User")
                        .WithMany("Students")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Teacher", b =>
                {
                    b.HasOne("OzelDersYerim.Entity.Concrete.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("OzelDersYerim.Entity.Concrete.Identity.User", "User")
                        .WithMany("Teachers")
                        .HasForeignKey("UserId");

                    b.Navigation("Branch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.TeacherBranch", b =>
                {
                    b.HasOne("OzelDersYerim.Entity.Concrete.Branch", "Branch")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDersYerim.Entity.Concrete.Teacher", "Teacher")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Branch", b =>
                {
                    b.Navigation("TeacherBranches");
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Identity.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("OzelDersYerim.Entity.Concrete.Teacher", b =>
                {
                    b.Navigation("TeacherBranches");
                });
#pragma warning restore 612, 618
        }
    }
}
