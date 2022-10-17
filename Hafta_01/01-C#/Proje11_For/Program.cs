using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1}.hello world");
            //}


            //int sayac = 0;
            //for (int i = 1; i <=10 ; i++)
            //{

            //    sayac = sayac + i; 
            //}
            //Console.WriteLine(sayac);

            // 1 İLE 10 ARASINDAKİ ÇİFT SAYILARIN TOPLAMINI BUL VE EKRANA YAZDIR.

            //int toplam = 0;

            //for (int i = 0; i <= 10; i = i + 2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);


            // DİĞER YÖNTEM MOD YÖNTEMİ

            //int toplam = 0;
            //for (int i = 1; i <= 10; i = i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam = toplam + i;
            //    }

            //}

            //Console.WriteLine(toplam);

            // 1 -10 ARASINDAKİ ÇİFT SAYILARIN TOPLAMINI AYRI , TEK SAYILARIN TOPLAMINI AYRI GÖSTEREN KODU YAZINIZ.

            //int ciftToplam = 0;
            //int tekToplam = 0;
            //for (int i = 1; i <= 10; i = i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        tekToplam += i;
            //    }
            //    else
            //    {
            //        ciftToplam += i;
            //    }

            //}

            //Console.WriteLine(ciftToplam);
            //Console.WriteLine(tekToplam);

            //---SORU : KLAVYEDEN İKİ SAYI GİRİLSİN. bU SAYILARIN ARASINDAKİ SAYILARIN TOPLAMINI EKRANA YAZDIRALIM

            //** 1. sayı  2. sayıdan küçükse örn:1-10
            //Console.Write("1. Sayıyı giriniz. : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz. : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine($"Toplam = {toplam} " );

            //--- 1. sayı ikinci sayıdan kcukse örn : 36-10

            //Console.Write("1. Sayıyı giriniz. : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz. : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //if (sayi2 > sayi1)
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam = toplam + i;
            //    }

            //}
            //else
            //{
            //    for (int i = sayi1; i >= sayi2; i--)
            //    {
            //        toplam = toplam + i;
            //    }

            //}
            //Console.WriteLine($"Toplam = {toplam} ");

            ////***-*-*-*--- min max çözümü

            //Console.Write("1. Sayıyı giriniz. : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz. : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min = Math.Min(sayi1, sayi2);
            //int max= Math.Max(sayi1,sayi2);

            //for (int i = min; i <= max; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine($"Toplam = {toplam} ");



            ///--- ÖRNEK : Program kullanıcıdan sayı gimresini istesin. Ancak kullanıcı sayi girmeye devam ettşkçe girilen sayıların toplanmasını sağlayalım.Sayı adedi belirsizdir.Uygulamanın bitip ekrana toplamı yazdırabilmesi için kullanıcnın sayı yerine exit yazamasını kontrol edeceğiz.

            //int toplam = 0;
            //string girilenDeger = "";
            //string sonucMetin = "";
            //for (int i = 1; i < 100000; i++)
            //{
            //    Console.Write($"Toplamak istediğiniz {i}. sayıyı giriniz  (çıkış için exit yazınız.)[gecerli toplam {toplam}] : " );
            //    girilenDeger = Console.ReadLine();

            //    if (girilenDeger == "exit")
            //    {
            //        break;//içinde bulunulan döbgünün tamamlanmasını beklemden istenilen bir anda durdurulması için kullanılır.
            //    }
            //    sonucMetin = sonucMetin + girilenDeger+ " + " ;
            //    toplam = toplam+ Convert.ToInt32(girilenDeger);

            //}
            //int alinacakKisminUzunlugu = sonucMetin.Length - 3; // uzunluk aldık ve sondaki fazldan artıyı ve bpşluğu cıkarıp değere atadık.
            //sonucMetin = sonucMetin.Substring(0, alinacakKisminUzunlugu);// substring metindeki istediğimizz yerden başalyıp istediğimiz yere kadar olan kısmı yazdırır.

            //Console.WriteLine($"Toplamınız :{sonucMetin} = {toplam}");


            //---- SORU : 5*5'lik bir kare biçimini * işaretiyle oluşturan uygulamayı yazınız.

            //int satir = 5;
            //int sutun = 5;
            //string yildiz = "*";
            //for (int i = 0; i < satir; i++)
            //{

            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            // 5*5 lik bir içi boş kare

            int satir = 5;
            int sutun = 5;
            string yildiz = "*";
            for (int i = 0; i < satir; i++)
            {
                
                    for (int j = 0; j < sutun; j++)
                    {
                    if (i==0 || i==satir)
                    {
                        Console.Write("*");
                    }
                        else if (j==0 || i==sutun)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    }
                    Console.WriteLine();
                
                 // ÖDEV-üstteki içi boş kareyi oluşturan uygulamayı adım adım çalıştırarak anlamaya çalışın.
                 // ÖDEV-1 : 1 le yüz arasındaki sayıların ortalamsını bulduran program.
                 // Ödev-2 : 1 le yüz arasında çift tek ve 5 in katı olan sayıların adetleri ve toplamlarını ekrana yazdıran program.
                 // ÖDEV-3 :aşağıdaki yüksekliği 5 tabanı 9 birim olan yıldızlardan oluşan dik üçgeni çizdiren program.
                 //*
                 //***
                 //*****
                 //*******
                 //*********
            }













































        }
    }
}