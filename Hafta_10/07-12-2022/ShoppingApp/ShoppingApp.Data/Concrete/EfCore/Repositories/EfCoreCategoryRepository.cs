using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Context;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context) : base(context) // ShopAppcontext zaten DbContexten miras adlığı için sorun olmaz kullanmak
        {
            // Buraya gelen context Base class'a gönderiliyor ve aynı zamanda sadece bu constructor içinde geçerli.
            // Ama bu classın bütününde henüz kullanılamıyor. Eğer kullanmak istersek yapmamız gereken işlemler var.
        }

        public List<Category> GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
