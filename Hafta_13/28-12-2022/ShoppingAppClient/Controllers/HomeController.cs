using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;
using System.Diagnostics;

namespace ShoppingAppClient.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ProductViewModel> urunler = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/products"))
                {
                    string  apiResponse = await response.Content.ReadAsStringAsync();
                    urunler = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse); //İçerisindeki verilerin her birini List ProductViewModel olarak al.
                }
            }
            return View(urunler);
        }

        public async Task<IActionResult> ProductDetail(int id)
        {
            ProductViewModel product = new ProductViewModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:5200/api/products/{id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<ProductViewModel>(apiResponse);
                }
            }
            return View(product);
        }
        public async Task<IActionResult> GetProducts20000()
        {
            List<ProductViewModel> urunler = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    urunler = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse); //İçerisindeki verilerin her birini List ProductViewModel olarak al.
                }
            }
            urunler = urunler.Where(u => u.Price >= 20000).ToList();
            return View("index",urunler);
        }

        public async Task<IActionResult> GetCategories()
        {
            List<CategoryViewModel> kategoriler = new List<CategoryViewModel>();
            using (var httpClient= new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/categories"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    kategoriler = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            return View(kategoriler);
        }
    }
}