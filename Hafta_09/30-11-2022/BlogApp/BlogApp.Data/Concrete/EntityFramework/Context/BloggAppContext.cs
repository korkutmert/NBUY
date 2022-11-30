using BlogApp.Data.Concrete.EntityFramework.Mappings;
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Context
{
    public class BloggAppContext : DbContext
    {
        // DBsetlere bakıp isimlerine göre tablolar oluşturacak veritabanında.
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OFVK2FD;Database=BlogAppDb; Integrated Security=true;TrustServerCertificate=True;");
            #region TrustedServerCertificate
            //EntityFrameworkCore 7 ile SqlServer veri tabanına bağlantı ile ilgili önemli br değişiklik olmuştur. Bu da güvenlik amacıyla doğrulanmış sertifika gereksinimidir. Bunu ifade eden TrustServerCertificate özelliği böyle bir sertifika yoksa True'ya çekilmelidir. Çünkü default olarak false ' dur.False iken maalesef veritabanına bağlansa bile kullanıma izin vermez.
            #endregion
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }
}
