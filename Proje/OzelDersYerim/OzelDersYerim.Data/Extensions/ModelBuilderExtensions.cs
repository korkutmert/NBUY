using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OzelDersYerim.Data.Config;
using OzelDersYerim.Entity.Concrete;
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
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name="Admin",
                    NormalizedName="ADMIN",
                },

                  new IdentityRole
                {
                    Name="Student",
                    NormalizedName="STUDENT"
                },
                  new IdentityRole
                {
                    Name="Teacher",
                    NormalizedName="TEACHER"
                }
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            List<User> users = new List<User>
            {
                new User
                      {
                          Id="f51a33d9-90b7-4304-8f27-296121b22ed8",
                          Email="student@gmail.com",
                          
                      },
                 new User
                     {
                         Id="36c1db42-7495-477f-921e-ba037f5188ed",
                         Email="teacher@gmail.com",
                     },
                 new User
                     {
                         Id="arzu",
                         Email="arzu@gmail.com",
                     },
                 new User
                     {
                         Id="serdar",
                         Email="serdar@gmail.com",
                     }

            };
            modelBuilder.Entity<User>().HasData(users);



            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {

                new IdentityUserRole<string>
                {
                    UserId=users[0].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[1].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[2].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[3].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
