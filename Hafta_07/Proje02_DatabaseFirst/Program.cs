using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;



var mt = new MultiTable();
mt.MusteriSayisi();
mt.SatisYapilanMusteriler();
mt.MusteriSatisListesi();














// NorthWindContext context = new NorthWindContext();

//------------------------------------------- Bu örnek customer listesi alıyor
// List<Customer> customers = context.Customers.ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// }

//-------------------------------------------London'da yaşayan Customer'ların listesi:
// List<Customer> customers = context.Customers.Where(c => c.City == "London").ToList();
// foreach (var customer in customers)
// {
//     System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }


//------------------------------------------- London'da yaşayan Customer'ların sadece Company Name ve Contact Name'lerini getirelim.
// var customers = context
//     .Customers
//     .Select(c => new{c.CompanyName, c.ContactName, c.City})
//     .Where(c => c.City == "London")
//     .ToList();
// foreach (var customer in customers)
// {
//     System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// System.Console.WriteLine("Bitti");


//-------------------------------------------London'da yaşayan Customer'ların sadece Company Name ve Contact Name'lerini getirelim.
//Nesne kullanarak


// List<CustomerModel> customers = context
//     .Customers
//     .Select(c => new CustomerModel()
//     {
//         CompanyName = c.CompanyName,
//         ContactName = c.ContactName,
//         City = c.City
//     })
//     .Where(c => c.City == "London")
//     .ToList();
// foreach (var customer in customers)
// {
//     System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// System.Console.WriteLine("Bitti");

//-------------------------------------------Beverages kategorisindeki ürünlerin listesi
// var beveragesProducts = context
// .Products
// .Where(p => p.Category.CategoryName == "Beverages") // iNNER JOİN
// .ToList();
// foreach (var p in beveragesProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }

//------------------------------------------- Suppliers tablosundaki Germany'de yaşayanları listeleyin.
// List<Supplier> germanySuppliers = context
// .Suppliers
// .Where(s => s.Country == "Germany")
// .ToList();
// foreach (var s in germanySuppliers)
// {
//     System.Console.WriteLine($"Company Name: {s.CompanyName} - Country: {s.Country}");
// }

//--------------------------------------------Nancy adındaki employee nin brezilya'ya satışlarını getir.
// var ordersOfNancy = context
// .Orders
// .Where(o => o.Employee.FirstName == "Nancy" && o.ShipCountry == "Brazil")
// .ToList();
// foreach (var o in ordersOfNancy)
// {
//     System.Console.WriteLine(o.OrderId);
// }
// System.Console.WriteLine($"Toplam Satış Sayısı: {ordersOfNancy.Count()}");


// -------------------------------------------PRODUCTLARI ID ' YE GÖRE BÜYÜKTEN KÜÇÜĞE LİSTELEELYİM
// var products = context
// .Products
// .OrderByDescending(p=> p.ProductId)
// .ToList();


// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }



// -------------------------------------------EN SON KAYIT 5 ÜRÜN YANİ (EN BÜYÜK 5 ID)
// var products = context
// .Products
// .OrderByDescending(p=> p.ProductId)
// .Take(5)// ilk 5 tanesini yazdır.
// .ToList();


// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }


// -------------------------------Fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleylim.Küçütkten b'e sırala!

// var products = context
// .Products
// .Where(p=>p.UnitPrice >= 10 && p.UnitPrice <=20)
// .Select(p=> new{
//     p.ProductName,
//     p.UnitPrice
// })
// .OrderBy(p=>p.UnitPrice)
// .ToList();


// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName} / {p.UnitPrice}");
// }

//---------------------Beverages kategorisindeki ürünlerin ortalama fiyatını ekrana yazdıalrım.
// var ortalama = context
// .Products
// .Where(p=> p.Category.CategoryName=="Beverages")
// .Average(p=>p.UnitPrice); // Ortalama alma

// System.Console.WriteLine(ortalama);


//--------------------- Beveragesteki ürün adedi

// var adet = context
// .Products
// .Where(p=> p.Category.CategoryName=="Condiments")
// .Count(); 

// // YADA BÖYLE OLABLİR 
// // Count(p=> p.Category.CategoryName=="Beverages");

// System.Console.WriteLine(adet);

//--------------------- Beverages ve Condimenys toplam kaç ürün var
// var toplam = context
// .Products
// .Count(p=> p.Category.CategoryName=="Beverages" || p.Category.CategoryName=="Condiments") ;
// System.Console.WriteLine(toplam);


//-------------------- ADININ İÇİNDE TOFU GEÇENLERİ LİSTELELEYİM

// var products = context
// .Products
// .Where(p=>p.ProductName.Contains("tofu"))
// .ToList();

// foreach (var p in products)
// {
//     System.Console.WriteLine(p.ProductName);
// }



//-----------------------EN UCUZ VE EN PAHALI ÜRÜNLER HANGİLERİ

// var minPrice = context.Products.Min(p=>p.UnitPrice);
// var maxPrice = context.Products.Max(p=>p.UnitPrice);

// var minProduct = context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=>new{
//     p.ProductName,
//     p.UnitPrice
// })
// .FirstOrDefault();

// var maxProduct = context
// .Products
// .Where(p=>p.UnitPrice==maxPrice)
// .Select(p=>new{
//     p.ProductName,
//     p.UnitPrice
// })
// .FirstOrDefault();



// System.Console.WriteLine($"Min Price : {minPrice} --> Product : {minProduct.ProductName}-{minProduct.UnitPrice}");
// System.Console.WriteLine($"Min Price : {maxPrice} --> Product : {maxProduct.ProductName}-{maxProduct.UnitPrice}");


//-------------------------- En ucuz urunler ve adları 

// var minPrice = context.Products.Min(p=>p.UnitPrice);
// var maxPrice = context.Products.Max(p=>p.UnitPrice);

// var minProducts = context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=>new{
//     p.ProductName,
    
// })
// .ToList();
//  System.Console.WriteLine($"En Ucuz Ürün Fiyatı : {minPrice}  " );
//  System.Console.WriteLine("-En Ucuz Ürünler-");
// foreach (var p in minProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }






// class CustomerModel
// {
//     public string? CompanyName { get; set; }
//     public string? ContactName { get; set; }
//     public string? City { get; set; }
// }