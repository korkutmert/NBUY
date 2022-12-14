using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailServices  _emailSerivce;

        public HomeController(ILogger<HomeController> logger, IEmailServices emailSerivce)
        {
            _logger = logger;
            _emailSerivce = emailSerivce;
        }

        public IActionResult Index()
        {
            _emailSerivce.Send( "mertmuslu99@gmail.com","Test messagı","Konu");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}