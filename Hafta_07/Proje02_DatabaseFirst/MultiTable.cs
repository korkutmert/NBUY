using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje02_DatabaseFirst.efcore;


namespace Proje02_DatabaseFirst
{

   public class OrderModel
    {
        public int OrderId { get; set; }
        public DateTime? ShippedDate { get; set; }
        public Decimal? Freight { get; set; }
    }
    public class CustomerModel
    {
        public string? CustomerId { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? City { get; set; }
        public int OrderCount { get; set; }
        public List<OrderModel>? Orders { get; set; }
    }
    public class MultiTable
    {
            public void MusteriSayisi()
        {
            var context = new NorthWindContext();
            var result = context.Customers.Count();
            System.Console.WriteLine(result);
        }
           public void SatisYapilanMusteriler()         //Gelen listede her bir customer'a ait id company name contact name ve city olacak.
        {
            var context = new NorthWindContext();
            var customers=context
            .Customers
            .Where(c=>c.Orders.Count()>0)
            .Select(c=>new CustomerModel(){
                CustomerId=c.CustomerId,
                CompanyName=c.CompanyName,
                ContactName=c.ContactName,
                City=c.City
            })
            .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"{c.CompanyName}--{c.ContactName}--{c.City}--{c.CustomerId}");
            }
            System.Console.WriteLine($"Toplam SAtışan Müşşteri SAyısı : {customers.Count}");
        }
            public void SatisYapilmayanMusteriler()
            {
              var context = new NorthWindContext();
            var customers=context
            .Customers
            .Where(c=>c.Orders.Count()==0)
            .Select(c=>new CustomerModel(){
                CustomerId=c.CustomerId,
                CompanyName=c.CompanyName,
                ContactName=c.ContactName,
                City=c.City
            })
            .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"{c.CompanyName}--{c.ContactName}--{c.City}--{c.CustomerId}");
            }
            System.Console.WriteLine($"Toplam SAtışan Müşşteri SAyısı : {customers.Count}");
           
            }
            public void MusteriSatisListesi()
            {
                var context = new NorthWindContext();
                var customers = context
                .Customers
                .Select(c=> new CustomerModel(){
                    CustomerId=c.CompanyName,
                    CompanyName=c.CompanyName,
                    ContactName=c.ContactName,
                    City=c.City,
                    OrderCount=c.Orders.Count(),
                    Orders=c.Orders.Select(o=> new OrderModel(){
                        OrderId=o.OrderId,
                        ShippedDate=o.ShippedDate,
                        Freight=o.Freight
                    }).ToList()
                    
                    
                }).ToList();
                    foreach (var c in customers)
                    {
                        System.Console.WriteLine($"İd {c.CustomerId}  - Company Name : {c.CompanyName} - Order Count : {c.OrderCount} ");
                        foreach (var o in c.Orders)
                        {
                            System.Console.WriteLine($"\t Order Id : {o.OrderId} - ShippedDate : {o.ShippedDate} - Freight : {o.Freight}");
                        }
                        System.Console.WriteLine();
                    }
            }
    }
}