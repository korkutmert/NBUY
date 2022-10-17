using System;
using System.Globalization;

namespace Proje01_Class_field_Property_uygulama
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir product classımız olacak. İçinde name , price description bilgisi olacak.
            //İstenildiği kadar product bilgisinin girilmesini sağlayacağız.
            //Kaç adet product bilgisi girileceğini kullanıcı belirlesin.
            //Product ekleme işi bitince eklenmiş productlar listelensin.


            //Console.Write("Kaç adet ürün girmek istiyorsunuz ? ");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet];
            //Product product;

            //for (int i = 0; i < adet; i++)
            //{

            //    Console.Write("Product Name : ");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price : ");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.Write("Description :  ");
            //    product.Description = Console.ReadLine();


            //    products[i] = product;
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Product Name".PadLeft(30));
            //foreach (var prdct in products)
            //{
            //    Console.WriteLine($" {prdct.Name}\t{prdct.Price}\t{prdct.Description}");
            //}

            #region RastgeleDegerUreterek
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Galaxy A50", "HP Notebook", "Macbook Air M2", "Iphone 14 Plus", "LG 27 inç monitör" };
            string[] descArray = { "İyidir", "Şaşırtıcıdır", "Heyecan vericidir", "Soluğunuzu keser", "Tırttır" };
            decimal[]  oldPrices = new decimal  [5];
            Random random = new Random();
            Console.WriteLine("Zam oranını giriniz : ");
            decimal oran = decimal.Parse(Console.ReadLine());
            
            for (int i = 0; i < 5; i++)
            {
                product = new Product();
                {
                    product.Name = nameArray[random.Next(0, 5)];
                    product.Description = descArray[random.Next(0, 5)];
                    product.Price = random.Next(100, 1001);
                }
                oldPrices[i] = product.Price;
                product.Price *= (1 + (oran / 100));
                products[i] = product;
            }
            Console.WriteLine("Product Name".PadRight(30) + "Old Price".PadRight(10) + "Price".PadRight(10) + "Description");
            int j = 0;
            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.Name.PadRight(30)}{oldPrices[j].ToString().PadRight(10)}{prd.Price.ToString().PadRight(10)}{prd.Description}");
                j++;
            }
            #endregion
        }
    }
}