using Microsoft.EntityFrameworkCore;
using OzelDersYerim.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            List<Role> roles = new List<Role>
            {
                new Role
                {
                    Name="Admin",
                    NormalizedName="ADMIN",
                    Description="Admin rolü"

                },
                //  new Role
                //{
                //    Name="User",
                //    Description="User rolü",
                //    NormalizedName="USER"
                //},
                  new Role
                {
                    Name="Student",
                    Description="Student rolü",
                    NormalizedName="STUDENT"
                },
                  new Role
                {
                    Name="Teacher",
                    Description="Teacher rolü",
                    NormalizedName="TEACHER"
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);
            List<User> users = new List<User>
            {
                new User
                {

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
                  new User
                {
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

                },  new User
                {

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
                },  new User
                {

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
                }

            };
            modelBuilder.Entity<User>().HasData(users);

        }
    }
}
