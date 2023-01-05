using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDersYerim.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Data.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(s => s.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(s => s.LastName).IsRequired().HasMaxLength(100);
            builder.Property(s=>s.Age).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Url).IsRequired().HasMaxLength(250);
            builder.Property(s => s.ImageUrl).HasMaxLength(250);
            builder.Property(s => s.About).IsRequired().HasMaxLength(500);

            builder.ToTable("Students");
            builder.HasData
                (
                new Student
                {
                    Id = 1,
                    FirstName = "Mert Korkut",
                    LastName = "Muslu",
                    Age="24",
                    Url = "ogrenci-mert-korkut-muslu",
                    ImageUrl = "1.png",
                    About = "24 Yaşındayım.Yazılım eğitimi alıyorum.Yeni programlama dilleri üzerinde kendimi geliştirmek ve ders almak istiyorum."

                },
                new Student
                {
                    Id = 2,
                    FirstName = "Cemre ",
                    LastName = "Şenel",
                    Age="28",
                    Url = "ogrenci-cemre-senel",
                    ImageUrl = "2.png",
                    About = "24 Yaşındayım.Elektirk-elektronik mühendisiyim ancak şu sıralar yazılım eğitimi alıyorum.Kendimi bu alanda geliştirmek istiyorum."

                }, new Student
                {
                    Id = 3,
                    FirstName = "Harun ",
                    LastName = "Özer",
                    Age="23",
                    Url = "ogrenci-harun-ozer",
                    ImageUrl = "3.png",
                    About = "Kendimi her alanda gelişime açık hissediyorum. Back-end developer alanında çalışmak istediğim içinde özellikle bu alanda kendime birşeyler katmak istiyorum."

                }, new Student
                {
                    Id = 4,
                    FirstName = "Senem",
                    LastName = "Öztürk",
                    Age="20",
                    Url = "ogrenci-senem-ozturk",
                    ImageUrl = "4.png",
                    About = "Yeni mezun bir sağlıkçı olarak Kpss sınavlarına hazırlanmak için matematik dersleri almak istiyorum."
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Zeynep",
                    LastName = "Aslan",
                    Age = "14",
                    Url = "ogrenci-zeynep-aslan",
                    ImageUrl = "5.png",
                    About = "Matematik derslerinde çok zorlanıyorum."
                },
                new Student
                {
                    Id = 6,
                    FirstName = "Kemal Emre",
                    LastName = "Erol",
                    Age = "22",
                    Url = "ogrenci-kemal-emre-erol",
                    ImageUrl = "6.png",
                    About = "Merhaba.Herhangi bir müzik aleti çalmayı öğrenmek için buradayım !."
                },
                new Student
                {
                    Id = 7,
                    FirstName = "Aslı",
                    LastName = "Yıldız",
                    Age = "17",
                    Url = "ogrenci-asli-yildiz",
                    ImageUrl = "7.png",
                    About = "Lise öğrencisiyim.Üniversite sınavları için Kimya dersleri almak istiyorum."
                }
                );



        }
    }
}
