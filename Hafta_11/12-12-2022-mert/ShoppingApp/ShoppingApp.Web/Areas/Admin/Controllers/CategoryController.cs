using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using System.Xml.Linq;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            var categoryListDto = new CategoryListDto
            {
                Categories = categories
            };
            return View(categoryListDto);
        }

        [HttpGet] // Yeni kategori açılırken gerekli sayfayı açar açılırken içine bilgi gelmesine gerek yok
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var category = new Category
                {
                    Name = categoryAddDto.Name,
                    Description = categoryAddDto.Description,
                    Url = Jobs.InitUrl(categoryAddDto.Name)
                };
                await _categoryService.CreateAsync(category);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]// Bu sefer içi dolu olmalı edite baslınca önceki bilgiler içinde olamlı
        public async Task<IActionResult> Edit(int id) // view'ine git -> asp-route-id="@category.Id  ----> bunu almak için int id yaptık.
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryUpdateDto = new CategoryUpdateDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Url = category.Url
            };
            return View(categoryUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var category = await _categoryService.GetByIdAsync(categoryUpdateDto.Id);
                if (category == null)
                {
                    return NotFound();
                }

                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Url = Jobs.InitUrl(categoryUpdateDto.Name);

                _categoryService.Update(category);
                return RedirectToAction("Index");
            }
            return View(categoryUpdateDto);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var categoryDeleteDto = new CategoryDeleteDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            };
            return View(categoryDeleteDto);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(CategoryDeleteDto categoryDeleteDto)
        {
            var deleteCategory= await _categoryService.GetByIdAsync(categoryDeleteDto.Id);
            deleteCategory.Name = categoryDeleteDto.Name;
            deleteCategory.Description = categoryDeleteDto.Description;
            _categoryService.Delete(deleteCategory);
            return RedirectToAction("Index");
        }
    }
}
