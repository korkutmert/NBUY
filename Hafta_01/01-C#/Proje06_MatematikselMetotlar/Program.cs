using System;

namespace Proje06_MatematikselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //********** Büyük küçük KArşılaştırma**********/////

            //int sayi1 = 43;
            //int sayi2 = 50;
            //int minimum = Math.Min(sayi1, sayi2);
            //Console.WriteLine($" En küçük sayı:  {minimum} ");
            //int maximum = Math.Max(sayi1, sayi2);
            //Console.WriteLine($" En büyük sayı:  {maximum} ");
            //--------------------------------------------------------------------------------

            //******** Üslü İfadeler***********

            //    int taban = 4;
            //    int us = 2;
            //    double sonuc = Math.Pow(taban, us);
            //    Console.WriteLine(sonuc);

            /* Console.Write("Taban sayıyı giriniz. : ");
             int taban = Convert.ToInt32(Console.ReadLine());   // readine hep string döndürür. Dönüştürme işlemi gerekli olur.

             Console.Write("Üs sayıyı giriniz. : ");
             int us = int.Parse(Console.ReadLine());            // Parse komutu stringi integere cevirdi üsttekiyle ayn islemi yaptı.

             double sonuc = Math.Pow(taban, us);
             Console.WriteLine(sonuc);*/

            //-----------------------------------------------------------------------------
             
            // ******* YUVARLAMA KOMUTLARI*****
            
            double sayi = 5.34566;
            Console.WriteLine(Math.Ceiling(sayi));// yukarı yuvarlama
            Console.WriteLine(Math.Floor(sayi));  // Aşağı yuvarlama
            Console.WriteLine(Math.Round(sayi,2));// Virgülden sonra ne koarsan o kadar basamak bırakır. MEsela burda virgülden sonra iki basamak yazıdırdı.
            Console.WriteLine(Math.Sqrt(sayi));   // karekök








        }
    }
}