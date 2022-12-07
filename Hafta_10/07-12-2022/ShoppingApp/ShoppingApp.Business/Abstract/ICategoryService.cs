using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Abstract
{
    public interface ICategoryService
    {
        // Burda Tüm generic metotlar ve category e özgü olanlar yazılmalı
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        void UpdateAsync(Category category);
        void DeleteAsync(Category category);
        Category GetByIdWithProducts();
    }
}
