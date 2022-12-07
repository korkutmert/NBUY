using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Abstract
{
    public interface IProductService
    {
        // Burda Tüm generic metotlar ve product e özgü olanlar yazılmalı
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task CreateAsync(Product product);
        void UpdateAsync(Product product);
        void DeleteAsync(Product product);
        Product GetProductByCategory();
        Task<List<Product>>GetHomePageProductsAsync();
    }
}
