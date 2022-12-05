using BlogApp.Entities.Dtos;
using BlogApp.Mvc.Areas.Admin.Models;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Extensions;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlogApp.Mvc.Areas.Admin.Controllers
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
            var result = await _categoryService.GetAll();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            // ModelState'in içinde veri var ise 
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Add(categoryAddDto,"Mert Korkut");
                // Başarılıysa:
                if (result.ResultStatus==ResultStatus.Success)
                {
                    //İçindeki verileri CategoryAddAjaxViewModel tipinde json a dönüştürüyoruz.
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto = result.Data,
                        CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)
            });
            return Json(categoryAddAjaxErrorModel);
        }

        public async Task<JsonResult> GetAllByNonCategories()
        {
            var result = await _categoryService.GetAll();
            var resultJson = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(resultJson);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int categoryId)
        {
            var result = await _categoryService.Delete(categoryId, "Mert Korkut");
            var resultJson = JsonSerializer.Serialize(result);
            return Json(resultJson);
        }
    }
}
