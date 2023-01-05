using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        
        #region GENERIC YAPIYA ÖZGÜ OLANLAR
        public async Task CreateAsync(Product product)
        {
            await _unitOfWork.Products.CreateAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
            
        }

        public void UpdateAsync(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();

        }
        public void DeleteAsync(Product product)
        {
            _unitOfWork.Products.Delete(product);
            _unitOfWork.Save();
        }

        #endregion



        #region PRODUCT'A ÖZGÜ OLANLAR
        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await _unitOfWork.Products.GetHomePageProducts();
        }

        public Product GetProductByCategory()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
