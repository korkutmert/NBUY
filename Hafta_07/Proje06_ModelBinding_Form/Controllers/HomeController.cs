using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_Form.Models;

namespace Proje06_ModelBinding_Form.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    
     public IActionResult YasGrubu()
    {
        return View();
    }
    [HttpPost]// Bir alttaki yas grubu action'u post türünde olduğu için hemen üstüne tanumlanır.
         public IActionResult YasGrubu(int yas, string ad)
    {   if(yas == 0 )
        {
            ViewBag.YasGrubu="Lütfen Yaşınızı Giriniz.";
        }
        else if (yas<18)
        {
            ViewBag.YasGrubu=$"{ad},Reşit Değilsiniz.";
        }
        else if (yas<40)
        {
            ViewBag.YasGrubu=$"{ad}, Gençsiniz.";
        }
        else if (yas<60)
        {
            ViewBag.YasGrubu=$"{ad},Yaşlısınız.";
        }
        else
        {
            ViewBag.YasGrubu=$"{ad}, Çok Yaşlısınız.";

        }
        return View();
    }
    
    
       public IActionResult CreateProduct()
    {
        return View();
    }
    
    [HttpPost]
           public IActionResult CreateProduct(Product product)
    {

        // Burada veri tabanına kayıt işlemi vb. yapılacak.
        // Şimdilik biz gelen verilerin testini yapabilmek için tekrar sayafaya bastıralım.
        ViewBag.ResultHeader=$"{product.Name} adlı ürün eklendi." ;
        ViewBag.ResultBody=$" Ürün Kategorisi: {product.Category} Fiyat :{product.Price} " ;
        
        
        return View(product);
    }
    
   
    
    // public IActionResult VerileriAl(string txtAd ,int txtYas)
    // {
    //     return View();
    // }

}
