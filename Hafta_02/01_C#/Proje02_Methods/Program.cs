using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;

namespace Proje02_Methods
{
    internal class Program
    {
        // static void Cikar(int sayi1,int sayi2)
        // {
        //     int sonuc = sayi1 - sayi2;
        //     Console.WriteLine();
        //     Console.WriteLine($"Fark : {sonuc}");
        // }
        //static void Topla (int sayi1,int sayi2 )
        // {
        //     int toplam = sayi1 + sayi2;
        //     Console.WriteLine();
        //     Console.WriteLine($"Toplam : {toplam}");
        // }
        // static int SiraNoBul(string metin, char karakter)
        // {
        //     int sonuc = metin.IndexOF(karakter);
        //     return sonuc;
        // }
        // static bool VarMi(string metin,char karakter)
        // {
        //     bool sonuc = metin.Contains(karakter);
        //     return sonuc;
        // }
        //public static int Topla(int sayi1,int sayi2)
        // {
        //     int toplam = sayi1 + sayi2;
        //     return toplam ;
        // }
        // static int Cikar(int sayi1, int sayi2)
        // {
        //     int fark = sayi2 - sayi1;
        //     return fark;
        // }
        static void Main(string[] args)// METHOD
        {
            //Console.Write("Sayi 1 : ");
            //int s1 = int.Parse(Console.ReadLine());

            //Console.Write("Sayi 2 : ");
            //int s2 = int.Parse(Console.ReadLine());


            //int toplam = Topla(s1,s2);
            //int fark = Cikar(s1,s2);

            //Console.WriteLine($" Toplam : {toplam}");
            //Console.WriteLine($"Fark : {fark}");
            //Console.Write($"Toplam - Fark : {toplam-fark}");

            // Kendisine verilen metnin içinde aradığımız karakterin kaçıncı sırada oduğunu bulan metodu hazırlayınız.

            // Kendisine verilen metnin içinde aradığımız karakterin olup olmadığını bize söyleyen bir metodu hazırlayınız.
            //    Console.WriteLine(SiraNoBul("Wissen Akademie", 'A' 'A'));
            //    string metin = Console.ReadLine();

            //    Console.WriteLine("VarMi("Wissen Akademie",'A');
            //    Sira();

            //}

            #region MethodOverloads
            MethodOverload methodOverload = new MethodOverload();
            
            Console.WriteLine(methodOverload.Islem(true,10,66,0));
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(  methodOverload.topla(sayilar));

            #endregion


        }



    }
    }