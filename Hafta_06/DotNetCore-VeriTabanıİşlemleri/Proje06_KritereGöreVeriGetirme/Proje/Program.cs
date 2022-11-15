﻿using System.Data.SqlClient;
using Proje.BusinessLayer;
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;

namespace Proje;
class Program
{
    static void Main(string[] args)
    {
        int secim;
       do
       {
        Console.Clear();
        Console.WriteLine("Choose Database->");
        Console.WriteLine("1 - MsSql");
        Console.WriteLine("2 - Sqlite");
        Console.WriteLine("0 - Exit");
        Console.Write("Seçiminizi Giriniz:");
        secim = Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
        {
            Menu(secim);
            Console.ReadLine();
        }
        else if(secim == 2)
        {
            Menu(secim);
            Console.ReadLine();
        }
        else if (secim != 0)
        {
            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
            Console.ReadLine();
        }
       } while (secim != 0);
    }
    static void Menu(int dbType)
    {
        string dbName = dbType==1 ? "MsSql" : "SqLite";
        Console.Clear();
        Console.WriteLine($"By {dbName} Database - NorthWind");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1- Product List");
        Console.WriteLine("2- Customer List");
        if (dbType==1)
        {
            System.Console.WriteLine("3- Search Products By ID");
            System.Console.WriteLine("4- Filter Product By Category ID");
            System.Console.WriteLine("5- Filter Product By Category Name");
        }
        Console.Write("Seçim Yapınız: ");
        int secim = int.Parse(Console.ReadLine());
        if (secim == 1)
        {
            if(dbType == 1)
            {
            ProductList(new SqlProductDAL());
            }
            else
            {
            ProductList(new SqliteProductDAL());    
            }
        }
        else if (secim == 2)
        {
            if (dbType==1)
            {
                CustomerList(new SqlCustomerDAL());
            }
            else
            {
                CustomerList(new SqliteCustomerDAL());
            }
        }
        else if (secim==3)
        {
            if (dbType==1)
            {
                ProductSearch(new SqlProductDAL());
            }
            else
            {

            }
        }
        else if (secim==4)
        {
             if (dbType==1)
            {
                ProductFilterByCategoryId(new SqlProductDAL());
            }
            else
            {

            }
        }
         else if (secim==5)
        {
             if (dbType==1)
            {
                ProductFilterByCategoryName(new SqlProductDAL());
            }
            else
            {

            }
        }
    }

    static void ProductFilterByCategoryName(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        System.Console.WriteLine("Enter Category Name: ");
        string catName=Console.ReadLine();
        List<Product> products=productManager.GetProductsByCategory(catName);
        
            foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
        
        
    }

    static void ProductFilterByCategoryId(IProductDAL productDAL)
    {
        var productManager=new ProductManager(productDAL);
        System.Console.Write("Enter Category ID: ");
        int catId=int.Parse(Console.ReadLine());
        List<Product> products=productManager.GetProductsByCategoryID(catId);
         if (products.Count > 0)
        {
            foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
        }
        else 
        {
            Console.WriteLine("Aradağınız kategoride ürün yok !");
        }
    }

    static void ProductSearch(IProductDAL productDAL)
    {
        var productManager=new ProductManager(productDAL);
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Product product = productManager.GetByIdProduct(id);
        if (product!=null)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
        else
        {
            Console.WriteLine("Aradığınız ID Bulunamadı.");
        }
    }
    static void ProductList(IProductDAL productDAL)
    {
        ProductManager productManager = new ProductManager(productDAL);
        List<Product> products = productManager.GetAllProducts();
       foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
        
    }
    static void CustomerList(ICustomerDAL customerDAL)
    {
        CustomerManager customerManager = new CustomerManager(customerDAL);
        List<Customer> customers = customerManager.GettAllCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine($"Id: {customer.Id}, Company Name: {customer.CompanyName}, Contact Name: {customer.ContactName}, Country: {customer.Country}");
        }
    }
}
