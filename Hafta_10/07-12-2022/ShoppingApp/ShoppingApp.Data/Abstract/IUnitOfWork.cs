using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IUnitOfWork : IDisposable // Merkezi bir yerden işleri yönetmek için unitofwork oluştururlur.
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        Task SaveAsync();
        void Save();
    }
}
