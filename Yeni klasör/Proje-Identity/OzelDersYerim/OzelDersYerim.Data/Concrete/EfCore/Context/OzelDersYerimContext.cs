using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OzelDersYerim.Data.Config;
using OzelDersYerim.Data.Extensions;
using OzelDersYerim.Entity.Concrete;
using OzelDersYerim.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Data.Concrete.EfCore.Context
{
    public class OzelDersYerimContext : IdentityDbContext<User, Role, string >
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        public DbSet<Branch> Branches { get; set; }



        public OzelDersYerimContext(DbContextOptions<OzelDersYerimContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new BranchConfig());    
            modelBuilder.ApplyConfiguration(new StudentTeacherConfig());
            base.OnModelCreating(modelBuilder);

        }

    }

}
