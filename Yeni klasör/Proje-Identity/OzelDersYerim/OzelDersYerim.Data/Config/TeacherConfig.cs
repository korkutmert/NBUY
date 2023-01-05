using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDersYerim.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Data.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Gender).IsRequired().HasMaxLength(20);
            builder.Property(t => t.Age).IsRequired().HasMaxLength(20);
            builder.Property(t => t.About).IsRequired().HasMaxLength(500);
            builder.Property(t => t.Experince).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Location).IsRequired().HasMaxLength(20);
            builder.Property(t => t.Url).IsRequired().HasMaxLength(250);
            builder.Property(t => t.ImageUrl).HasMaxLength(250);
            builder.Property(t => t.Phone).HasMaxLength(11);

            builder.ToTable("Teachers");
            builder.HasData
                (
                    new Teacher
                    {
                        Id = 1,
                        FirstName = "Ahmet",
                        LastName = "Yılmaz",
                        Gender = "Erkek",
                        Age = "39",
                        About = "Mimar Sinan Güzel Sanatlar Üniversitesi Konservatuar mezunuyum. Uzmanlık alanım Piyano olamakla beraber keman ve gitar dersleri de vermekteyim.",
                        Experince = "15",
                        Phone="05550005500",
                        Location = "Beşiktaş",
                        Url = "ogretmen-ahmet-yilmaz",
                        ImageUrl = "10.png",
                        PricePerHour = 450,
                        BranchId= 4

                    },
                     new Teacher
                     {
                         Id = 2,
                         FirstName = "Arzu",
                         LastName = "Doğramacı",
                         Gender = "Kadın",
                         Age = "27",
                         About = "İngilizce Öğretmeniyim. Her türlü İngilizce sınavlarına hazırlık konusunda ders vermekteyim.",
                         Experince = "5",
                         Phone = "05550005501",
                         Location = "Şişli",
                         Url = "ogretmen-arzu-dogramaci",
                         ImageUrl = "11.png",
                         PricePerHour = 300,
                        BranchId =3

                     }, new Teacher
                     {
                         Id = 3,
                         FirstName = "Serdar",
                         LastName = "Kulbilge",
                         Gender = "Erkek",
                         Age = "42",
                         About = "İlköğretim-lise düzeyinde matematik dersleri verilir. Sınavlar için fazladan etüt alabilirsiniz.",
                         Experince = "",
                         Phone = "05550005502",
                        Location = "Aksaray",
                         Url = "ogretmen-serdar-kulbilge",
                         ImageUrl = "12.png",
                         PricePerHour =250,
                         BranchId =1


                    }, new Teacher
                    {
                        Id = 4,
                        FirstName = "Hande",
                        LastName = "Yıldırım",
                        Gender = "Kadın",
                        Age = "28",
                        About = "Boğaziçi Üniversitesi Mezunuyum. 28 yaşındayım. Özel bir lisede Kimya Öğretmenliği yapıyorum.",
                        Experince = "6",
                        Phone = "05550005503",
                        Location = "Etiler",
                        Url = "ogretmen-hande-yildirim",
                        ImageUrl = "13.png",
                        PricePerHour =300,
                        BranchId =2


                    }, new Teacher
                    {
                        Id = 5,
                        FirstName = "Burak",
                        LastName = "Yılmaz",
                        Gender = "Erkek",
                        Age = "30",
                        About = "Samsun 19 Mayıs Universitesi Matematik Bölümü mezunuyum. Aynı zamanda Elektro Gitar dersleri vermekteyim.",
                        Experince = "7",
                        Phone = "05550005504",
                        Location = "Mecidiyeköy",
                        Url = "ogretmen-burak-yilmaz",
                        ImageUrl = "14.png",
                        PricePerHour =400,
                        BranchId =4


                    }, new Teacher
                    {
                        Id = 6,
                        FirstName = "Hasan Can",
                        LastName = "Güzel",
                        Gender = "Erkek",
                        Age = "29",
                        About = "Türk Dili Ve Edebiyatı, Türkçe, Dil Anlatım gibi dersler uzmanlık alanım olup, her türlü sınav için ders veriyorum.",
                        Phone = "05550005505",
                        Experince = "7",
                        Location = "Beşiktaş",
                        Url = "ogretmen-hasan-can-guzel",
                        ImageUrl = "15.png",
                        PricePerHour =200,
                        BranchId =5


                    },
                     new Teacher
                     {
                         Id = 7,
                         FirstName = "Hakkı ",
                         LastName = "Sarıca",
                         Gender = "Erkek",
                         Age = "42",
                         About = "Back-End ve Front-End development konularında A'dan Z'ye eğitim vermekteyim. Sektörde Senior Developer olarak çalıştım.",
                         Phone = "05550005505",
                         Experince = "21",
                         Location = "Esenler",
                         Url = "ogretmen-hakki-sarica",
                         ImageUrl = "16.png",
                         PricePerHour = 700,
                         BranchId =6


                     }
                );




        }
    }
}
