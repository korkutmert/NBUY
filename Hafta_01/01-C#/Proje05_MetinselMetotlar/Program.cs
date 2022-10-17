using System.Collections.Concurrent;
using System.Runtime.Loader;

namespace Proje05_MetinselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu projede metinsel işlemlere dair bazı metotlar öğreneceğiz.
            //string metin = "yalova";
            //int uzunluk = metin.Length;
            //Console.WriteLine($"{metin} metni {uzunluk} karakterdir");

            // string metin = "WİSSEN";              // metini kucuk harfe cevirme kodu.
            // string kucukMetin=metin.ToLower();
            // Console.WriteLine(kucukMetin);

            //string buyukMetin=metin.ToUpper();       // metni buyuk harfe cevirme kodu.
            // Console.WriteLine(buyukMetin);  


            //string m1 = "Wissen";
            //string m2 = "Wissen Akademie";
            //int sonuc= String.Compare(m2, m1);
            //Console.WriteLine(sonuc);       // Eğer sayı 0 ise eşit , -1 ise ilk yazılan küçük , +1 ise ilk yazılan büyüktür.

            // Kullanıcıdan girmesi isteniyor.


            //Console.Write("1.Metni Giriniz : ");
            //string m1 = Console.ReadLine();
            //Console.Write("2.Metni giriniz : ");
            //string m2 = Console.ReadLine();
            //int sonuc = String.Compare(m1, m2);
            //if (sonuc==0)
            //{
            //    Console.WriteLine("Girilen iki metin biribirine eşittir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen iki metin birbirinden farklıdır.");
            //}


            //string m1 = "işkur";
            //string m2 = "eğitimleri";
            //string m3 = "wissen";

            ////string sonuc = m1 + m2;
            //string sonuc =String.Concat(m1, m2,m3 ); // Metin birleşitrme metdou. Birden fazla eklenebilir.m1,m2,m3...
            //Console.WriteLine(sonuc);

            //    string ad = "Mert";
            //    int yas = 23;
            //    string okul = "BAU";

            //    Console.WriteLine($"Benim adım  {ad}. {yas} yaşındayım. Okuduğum okulunun adı  {okul}");
            //    string sonuc = String.Concat(ad, yas, okul);

            //    string sonuc1=("Benim adım " + ad+ ". " + yas + " yaşındayım. Okuduğum okulun adı "+ okul);
            //    Console.WriteLine(sonuc1);

            //    string sonuc3 = String.Concat("Benim adım " ,ad, ". ", yas ," yaşındayım. Okuduğum okulun adı ", okul);
            //    Console.WriteLine(sonuc3);
            //}


            // aradığımız kelime yada karakter (char) yazılan metnin içinde var mı ?

            //string metin = "merhaba. Bu hafta eğitime başladık. ";
            //bool sonuc = metin.Contains("merhaba");
            //Console.WriteLine(sonuc);


            // Metnin sonunda ya da başında aradığımız kelime var mı ? 
            //string adres = "İstanbul Şehit Ali mh. Can sokak. No:6 Kadıköy/Ankara";
            //bool sonuc = adres.EndsWith("istanbul");
            //Console.WriteLine(sonuc);
            //bool sonuc2 = adres.StartsWith("Selami");
            //Console.WriteLine(sonuc2);


            //****Adres içindeki c harfi kaçıncı sıradadır ?

            //int siraNo = adres.IndexOf('C');
            //Console.WriteLine($" C harfi {adres} içinde, {siraNo}. sıradadır");

            //****Adres içindeki c harfi kaçıncı sıradadır Büyük küçük farketmeden 

            //string aranacakIfade = "K";

            //int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
            //Console.WriteLine($" C harfi {adres} içinde, {siraNo}. sıradadır");





            //string aranacakIfade = "Şehit ali";

            //int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
            //Console.WriteLine($" {aranacakIfade} ifadesi {adres} içinde, {siraNo}. sıradadır");


            //string metin = "Wissen Akademie";
            //Console.WriteLine($"Metnin İlk Hali : {metin}");
            //Console.WriteLine($"Akademie ifadesi silindikten sonraki hali : {metin.Remove(6)}");
            //Console.WriteLine($"Aka ifadesi silindikten sonraki hali : {metin.Remove(7, 3)}");

            string urunAd = "Iphone 13 Pro";
          //  iphone-13-pro haline çevirmek için;
          //string sonuc = (urunAd.Replace(" ", "-");
          //  string sonuc= urunAd.ToLower().Replace(" ", "-");
          //  Console.WriteLine(sonuc);
            













        }
    }
}