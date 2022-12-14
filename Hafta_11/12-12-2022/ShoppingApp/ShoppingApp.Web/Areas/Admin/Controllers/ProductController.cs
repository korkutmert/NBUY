using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductsWithCategories();
            var productListDto = products
                .Select(p => new ProductListDto
                {
                    Product = p
                }).ToList();
     
            return View(productListDto);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            var productAddDto = new ProductAddDto
            {
                Categories = categories
            };
            return View(productAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductAddDto productAddDto)
        {
            if (ModelState.IsValid)
            {
                
                var url = Jobs.InitUrl(productAddDto.Description);
                var product = new Product
                {
                    Name = productAddDto.Name,
                    Price = productAddDto.Price,
                    Description = productAddDto.Description,
                    Url = url,
                    IsApproved = productAddDto.IsApproved,
                    IsHome = productAddDto.IsHome,
                    ImageUrl = Jobs.UploadImage(productAddDto.ImageFile)// Jobs class'ında yazdık buranın kodunu.
                };
                await _productService.CreateProductAsync(product, productAddDto.SelectedCategoryIds);
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllAsync();
            productAddDto.Categories= categories;
            return View(productAddDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var product = await _productService.GetProductWithCategories(id);
            if (product==null)
            {
                return NotFound();
            }
            var categories = await _categoryService.GetAllAsync();

            var productUpdateDto = new ProductUpdateDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ProductCategories = product.ProductCategories,
                SelectedCategoryIds = product.ProductCategories.Select(pc => pc.CategoryId).ToArray(),
                Description =product.Description,
                IsHome=product.IsHome,
                IsApproved=product.IsApproved,
                
            };
            return View(productUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto, int[] selectedCategoryIds)
        {
            if (ModelState.IsValid)
            {
                var product = await _productService.GetByIdAsync(productUpdateDto.Id);
                if (product==null)
                {
                    return NotFound();
                }
                var url= Jobs.InitUrl(productUpdateDto.Name);
                product.Name= productUpdateDto.Name;
                product.Price = productUpdateDto.Price;
                product.Description= productUpdateDto.Description;
                product.Url= url;
                
                product.IsHome = productUpdateDto.IsHome;
                product.IsApproved = productUpdateDto.IsApproved;
                product.ImageUrl = Jobs.UploadImage(productUpdateDto.ImageFile);
                _productService.Update(product);
                return RedirectToAction("Index");
                
            }
            return View(productUpdateDto);
        }
    }
}

