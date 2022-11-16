using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje04_MVC.Controllers;

public class Product 
{
    public int Id { get; set; } 
    public string Name { get; set; }   
    public decimal Price { get; set; }
}
public class Category 
{
    public int Id { get; set; } 
    public string CategoryName { get; set; }
}
public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        string ad ="Mert";
        ViewBag.KisiAd=ad;
        string dil="En";
        string selamlama ="";
        if (dil=="Tr")
        {
            selamlama="Hoşgeldiniz";
        }
        else if (dil=="En")
        {
            selamlama="Welcome";
        }
        else
        {
            selamlama="";
        }
        ViewBag.Selam=selamlama;
        return View();
    }

 
    public IActionResult About()
    {
        ViewBag.Hata=true;
        ViewData["Not"]=85;

        List<string> adlar = new List<string>(){"Sema","Harun", "Sefa","Tuğçe"};
        ViewData["Adlar"]=adlar;
        
        List<string> bolumler=new List<string>(){"Muhasebe","Eğitim","İK","Satış"};
        ViewBag.Bolumler=bolumler;
        return View();
    }

  public IActionResult GetProducts()
  {
    List<Product> products =new List<Product>()
    {
        new Product(){Id=1, Name="Samsung", Price=10000},
        new Product(){Id=2, Name="Xiaomi", Price=12000},
        new Product(){Id=3, Name="Iphone", Price=11000},
        new Product(){Id=4, Name="Dell", Price=13000},
        new Product(){Id=5, Name="Asus", Price=14000}
    };

    // ViewBag.Products = products;

    return View(products);
  }

  public IActionResult GetCategories()
  {
    List<Category> category = new List<Category>()
    {
        new Category(){Id = 1, CategoryName="Beyaz Eşya"},
        new Category(){Id = 2, CategoryName="Elektronik"},
        new Category(){Id = 3, CategoryName="Bilgisayar"},
        new Category(){Id = 4, CategoryName="Temel Gıda"},
        new Category(){Id = 5, CategoryName="Giyim"}
    };
    return View (category);
  } 
}
