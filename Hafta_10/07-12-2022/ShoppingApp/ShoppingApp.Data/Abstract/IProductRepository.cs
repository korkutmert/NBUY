using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository :IRepository<Product>
    {
        // Zaten IRepositoryde miras aldığı için onun içindekileri kullanıyor bu ekleneler ekstra sadece kendi yapablieceği şeyler olucak
        // producta özgü memberlar burada yer alacak. (Property , field, method..)
        List<Product> GetProductByCategory(); // Kategoriye göre product getir.
        List<Product> GetHomePageProducts();
    }
}
