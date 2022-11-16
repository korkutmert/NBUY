using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje05_MVC_Efcore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_Efcore_CodeFirst.Controllers
{
    
    public class ProductController : Controller
    {
 

        public IActionResult Index()
        {
            //Veri Tabanında Productları cekeceğiz.
            MyDbContext context = new MyDbContext();
            List<Product> products = context
            .Products//Contexten products'a eriştik
            .Include(p=> p.Category)//Category tablosunun bilgilerine erişip tüm bilgilerini getirdi ve ID yerine name i Yazdı.
            .ToList();

            return View(products);
        }

     
    }
}