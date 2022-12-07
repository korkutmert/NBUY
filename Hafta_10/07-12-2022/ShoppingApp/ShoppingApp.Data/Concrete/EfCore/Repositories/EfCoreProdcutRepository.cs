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
    public class EfCoreProdcutRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProdcutRepository(ShopAppContext context) : base(context)
        {
        }

        public List<Product> GetHomePageProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
