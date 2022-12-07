using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // Burdada kategoriye özgü memberlar olacak. IRepositoryden miras alıyor ama ortak olanların
        // dışında kendi yapacağı işlerde burda olcak

        List<Category> GetByIdWithProducts();
    }
}
