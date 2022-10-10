using System;

namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AYNI TİPTE İÇİNDE BİRDEN FAZLA DEĞER BULUDURAN YAPILAR.

            // string adSoyad = "Mert Muslu, Fatih Candan, Cemal Gündem";
            //string ad;
            //ad = " mert ";
            //Console.WriteLine(adSoyad);
            // string[] adlar = new string[6];//İçinde 3 adet string bilgi tutabilecek dizi.
            // adlar[0] = " Mert Korkut Muslu";
            // adlar[1] = " Fatih Candan";
            // adlar[2] = " Cemal Gündem";
            // adlar[3] = " ahmet yılmaz";
            // adlar[4] = " ali yıldır";
            // adlar[5] = " ahmet mehmet";
            //// Console.WriteLine(adlar[0]);

            // for (int i = 0; i < adlar.Length ; i++)//adlar dizisinin eleman sayısı kadar dön.
            // {
            //     Console.WriteLine(adlar[i]);
            // }


            //int[] yaslar = new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int toplam = 0;
            //for(int i = 0; i < rakamlar.Length ; i++)
            //{
            //    toplam += rakamlar[i];

            //}
            //Console.WriteLine(toplam);

            //string okul = "wissen akademie";
            //Console.WriteLine(okul[0]);

            //ÇALIŞMA ------> Klavyeden kullanıcnın adını soyadını girmesini isteyiniz.
            // girilen ad soyadı aşağıya doğru yazdırınız.z

            //string adSoyad = "";

            //Console.WriteLine("adınızı giriniz.");
            //adSoyad =Console.ReadLine().ToUpper();



            //for (int i = 0; i < adSoyad.Length; i++)
            //{
            //    Console.WriteLine(adSoyad[i] );
            //}

            //Console.WriteLine("Bir metin giriniz : ");
            //string girilenMetin =Console.ReadLine().ToLower();
            //Console.WriteLine(" Hangi karakterin sırasını bulmamı istersiniz ? :");
            //string karakter = (Console.ReadLine().ToLower());
            //int siraNo = girilenMetin.IndexOf(karakter)+1;
            //Console.Clear();// buraya kadar olan konsol ekranını temizler..
            //Console.WriteLine($"Aradığınız karakter {siraNo}. sırada olup {siraNo-1}. indextedir.");
            //Console.WriteLine("DİZİNİN ORJİNAL HALİ");
            //Console.WriteLine("********************");
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($" {i + 1}. Eleman :\t{rakamlar[i]}");
            //}
            //Console.WriteLine();
            // Kendimiz en büyük sayıyı buluyoruz.
            //int enBuyukSayi = rakamlar[0];
            //int enKucukSayi = rakamlar[0];
            //for (int i = 0; i < rakamlar.Length; i++)
            //{



            //    if (enBuyukSayi < rakamlar[i])

            //    {
            //        enBuyukSayi = rakamlar[i];

            //    }
            //    if (enKucukSayi > rakamlar[i])
            //    {
            //        //enKucukSayi = rakamlar[i];
            //    }

            //}
            //Console.WriteLine(enKucukSayi);
            //Console.WriteLine(enBuyukSayi);
            //Console.WriteLine($" En küçük :\t{rakamlar.Min()} ");
            //Console.WriteLine($" En büyük :\t{rakamlar.Max()} ");

            /////_-______-___-----***** bu diziyi küçükten büyüğe sıralayınız
            ///


            //Console.WriteLine("DİZİNİN TERS ÇEVRİLMİŞ HALİ");
            //Console.WriteLine("***************************");
            //Array.Reverse(rakamlar);
            //     for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($" {i+1}. Eleman :\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("DİZİNİN KÜÇÜKTEN BÜYÜĞÜE SIRALANMIŞ HALİ");
            //Console.WriteLine("****************************************");
            //Array.Sort(rakamlar);  // SORT KOMUTU KUCUKTEN BUYUGE SIRALAR.
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($" {i + 1}. Eleman :\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("DİZİNİN BÜYÜKTEN KÜÇÜĞE SIRALANMIŞ HALİ");
            //Console.WriteLine("****************************************");
            //Array.Sort(rakamlar);  // SORT KOMUTU KUCUKTEN BUYUGE SIRALAR.
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($" {i + 1}. Eleman :\t{rakamlar[i]}");
            //}
            //Console.WriteLine();





            //**********************ÖRNEKLER*******************

            //örnek1: Sayılar dizisinin elemanlarının ortalamasını bulup ekrana yazdrın.

            int[] sayilar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayilar.Sum(); // sum komutu SAYI DİZİSİ ise içerdeki toplamı verir.
            //Console.WriteLine(toplam);

            //******************************************************************************

            // Örnek 2 : Sayılar dizisindeki çift sayıları ekrana yazdıralım.

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //if (sayilar[i]%2 ==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }

            //}

            //*******************************************************************************

            // Örnek 3 : Sayilar dizisindeki sayıları yanlarında pozitif, ngatif yada işaretsiz olma bilgileriyle yazdıralım.

            //string tip = "";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 0)
            //    {
            //        tip = sayilar[i] ? "Pozitif" :
            //              sayilar[i] < 0 ? "Negatif" :
            //            "işaretsiz";
            //        Console.WriteLine($"{i + 1}.Sayı : {Sayilar[i]} - Tipi : {tip}");


            //    }
            //}
            //}

            //**********************************************************************************

            // Örnek 4 : Kullanıcının gireceği bir metindeki sesli harf sayısını yaz.

            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            //int toplamSesliHarfSayisi = 0;
            //Console.Write("Metin giriniz :");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i]))
            //    {
            //        toplamSesliHarfSayisi++;
            //    }
            //}
            //Console.WriteLine($"Toplam sesli harf sayısı : {toplamSesliHarfSayisi}");


            //*****************************************************************************

            // Örnek 5 :Klavyeden girilen bir CÜMLEdeki yine klavyeden girilecek bir KELİMEnin kaç kez geçtiğini bulduralım.

            string ornekMetin = " Mert Korkut Muslu";
            string[] sozcukDizisi = ornekMetin.Split(" ");
            for (int i = 0; i < sozcukDizisi.Length; i++)
            {
                Console.WriteLine(sozcukDizisi[i]);
            }
            int sozcukAdedi = 0;
            Console.Write("Bir cümle giriniz : ");
            string girilenCumle = Console.ReadLine();
            Console.WriteLine("Adedini bulmak istediğiniz kelimeyi giriniz :");
            string sayilacakSozcuk= Console.ReadLine();
            string[] girilenCumleninDiziHali = girilenCumle.Split(" ");
            for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            {
                if (sayilacakSozcuk.ToLower()== girilenCumleninDiziHali[i].ToString().ToLower())
                {
                    sozcukAdedi++;
                }
            }

            Console.WriteLine($"'{girilenCumle}' içinde '{sayilacakSozcuk}' sözcüğü '{sozcukAdedi}' kez geçmektedir. ");



            // - Araştırma  ÖDEVİ :
            // çok boyutlu dizileri araştırın.

            //KOD YAZMA ÖDEVİ :içinde Türkçe karakterler hariç tüm küçük harfler, 0-9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-),  karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde rastgele şifre üreten programı yazınız.*/



   char[] harfler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h','i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y' 'z', 'w', 'x', '+', '-', '.', ',' };

        }

    }
    }