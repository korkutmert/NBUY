using System.Collections;

namespace Proje04_Sayisal_Loto_Oyunu
{
    
    internal class Program
    {
        static int[] SayiUret()
        {
            Random rnd = new Random();
            int sayi;
            int[] loto = new int[6];
            for (int i = 0; i < 6; i++)
            {
                
                do
                {
                    sayi = rnd.Next(1, 50);
                }while (loto.Contains(sayi));
                loto[i] = sayi;
            }
            return loto;
        }
        static void Hile(int[] loto)
        {
            Console.WriteLine("HİLE");
            Console.WriteLine("****");
            foreach (var siradakiSayi in loto)
            {
                Console.WriteLine(siradakiSayi);
            }
            
        }
        static int TahminYap(int tahminSiraNo)//Kullanıcı her tahmin yapışında burayı kullanacak.
        {
            int tahmin;
            Console.Write($"{tahminSiraNo}. Tahmininizi Giriniz :");
            tahmin = int.Parse(Console.ReadLine());
            return tahmin;
        }
        static void Main(string[] args)
        {
            #region Açıklamalar
            //1-) Sistem 6 adet 1-49 arasında birbirinden farklı sayılar üretsin.
            //2-) Kullanıcıdan 6 adet tahmin alalım.
            //3-) Sonuç olarak kullanıcının kaç tane doğru tahmin yaptığını tahminleriyle beraber yazdıralım.
            //4-) Not: Hiç doğru tahmin yapamazsa KAYBETTİNİZ yazsın.
            #endregion
           

            int[] loto = SayiUret();//üretilen 6 adet sayiyi loto dizisine attık.Sayiureti çağırıp 6 tane rstgele sayi uretebiliyoruz.
            int[] tahminler = new int[6];
            Hile(loto);
            int tahmin;
            for (int i = 0; i < 6; i++)
            {
                
                do
                {
                   tahmin= TahminYap(i+1);
                } while (tahmin<0 || tahmin>49);
                tahminler[i] = tahmin;
            }
            ArrayList bilinenler = new ArrayList();//Arraylistlerin kaç elemanlı oldğu söylenmez. İçinde her bir eleman istenilen tipte değer tutabilir. int, string,char vb.
            foreach (var siradakiTahmin in tahminler)
            {
                if (loto.Contains(siradakiTahmin))
                {
                    bilinenler.Add(siradakiTahmin);
                }
            }
            if (bilinenler.Count==0)
            {
                Console.WriteLine("kaybettiniz kiç bilemediniz.");
            }
            else
            {
                Console.WriteLine($"Tebrikler {bilinenler.Count}adet doğru tahmin yaptınız.");
                Console.WriteLine("Bildiğiniz sayılar");
                foreach (var item in bilinenler)
                {
                    Console.WriteLine(item);
                }
            }
           
            Console.ReadLine();
        }
    }
}