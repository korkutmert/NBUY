using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje03_MVC.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();// Bu komut  : () içi boş olursa adı index olan motdu arar. Home controllerde index 'i arar.
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
      public IActionResult Contact()
    {
        return View();
    }

    
}
