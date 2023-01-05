using GetCountriesFromApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace GetCountriesFromApi.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            List<Country> countryList = new List<Country>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://restcountries.com/v2/all"))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();// Response değişkenin içerğine git ve oku-aktar--> stringRepsonse'e aktarır.
                     countryList = JsonSerializer.Deserialize<List<Country>>(stringResponse);//stringResponse un içinde JSON TİPİndeki dataları country tipine dönüştür.  VE countries değişkenine at sonra viewwe gönder.
                 
                }
            }
         
            return View(countryList);
        }
        public async Task<IActionResult> Privacy()
        {
            List<User> users = new List<User>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://reqres.in/api/users?page=2"))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    users = JsonSerializer.Deserialize<List<User>>(stringResponse);
                }
            }
            return View(users);
        }
        //public async Task<IActionResult> Privacy()
        //{
        //    User users = new User();
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync("https://reqres.in/api/users/2"))
        //        {
        //            var stringResponse = await response.Content.ReadAsStringAsync();
        //            users = JsonSerializer.Deserialize<User>(stringResponse);
        //        }
        //    }
        //    return View(users);
        //}


    }
}