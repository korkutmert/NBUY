using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categroyService;

        public ProductController(IProductService productService, ICategoryService categroyService)
        {
            _productService = productService;
            _categroyService = categroyService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductsWithCategories();
            var productListDto = products
                .Select(p => new ProductListDto
            {
                Product = p,
             
            }).ToList() ;
         
            return View(productListDto);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int id)
        {
            var categories = await _categroyService.GetAllAsync();
            var productAddDto =  new ProductAddDto
            {
                Categories= categories,
            };

            return View(productAddDto);
        }
    }
}
