using System.Runtime.InteropServices;

namespace Proje02_degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir değişkene isim verirken;
            // 1) Alfanümerik karakterler kullanılmaz.( _ hariç )
            // 2) Türkçe karakter kullanılmaz.
            // 3) Özel yada ayrılmış sözcükler kullanılmaz.
            // 4) Değişken isimleri büyük küçük harf duyarlıdır.


            /*string adSoyad;*/
            // Tercih edilen yöntem ilk harf küçük devamında ki harfler büyük olacak şekildedir.

            //adSoyad = "mert muslu";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine("adSoyad");

            //int yas;
            //yas = 19;                             ctrl k+c ile satırı comment satırı yap.
            //Console.WriteLine(yas);               ctrl k+u ile satırı normal kod satırı yap.

            //string adSoyad = "Ali Candan";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine("Adı :" + adSoyad +",Yaş:" + yas);

            //***** TAM SAYI ******
            byte sayi1 = 255;    // 1 byte 8 bittir.!!
            int sayi2 = 45;      // int değişkenine 32 bit sayı yazılır.
                                 //Console.WriteLine(int.MinValue+"---" + int.MaxValue); min ve max değer gösterme 
            long sayi3 = 12345678987456; // long değişkenine 64 bit sayı yazılır.
            int sayi4 = 15;
            Console.WriteLine(sayi4 + 2);

            //****** ONDALIKLI SAYI ******
            float a = 10.5f;
            double b = 20.6;
            decimal c = 100.65m;

            //****** KARAKTER VE METİN ***** 
            string name = "mert korkut muslu ";
            char cinsiyet = 'E';  // Char içinde sadece tek bir karakter bulıudnuran tiptir.

            // **** MANTIKSAL****
            bool evliMİ = true; // Sadece true ve false olur. Başka değer alamaz.
            
        }

    }
}