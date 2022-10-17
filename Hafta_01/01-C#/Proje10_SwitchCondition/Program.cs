using System.Collections.Concurrent;

namespace Proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen bir sayının 5olması halinde 2 katını - 10olamsı halinde 3 katını ya da 15 olması halinde 4 katını ekrana yazan programı hazırlayalım.Eğer üçüde değilse tanınmayan değer yazdıralım.

            // Console.Write("Bir sayı giriniz :  ");
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // int sonuc = 0;

            // if (sayi==5)
            // {
            //     sonuc = sayi * 2; 

            // }

            // else if (sayi==10)
            // {
            //     sonuc= sayi * 3;              
            // }
            // else if (sayi==15)
            // {
            //     sonuc = sayi * 4;              
            // }          
            //if(sonuc
            //     ==0)
            // {
            //     Console.WriteLine("Tanınmayan değer");
            // }
            // else
            // {
            //     Console.WriteLine(sonuc);
            // }

            /**********SWTİCHHH*/

            //Console.Write("Bir sayı giriniz (5-10-15):  ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //switch (sayi)
            //{
            //    case 5:
            //        sonuc = sayi * 2;
            //        break;

            //    case 10:
            //        sonuc = sayi * 3;
            //        break;

            //    case 15:
            //        sonuc = sayi * 4;
            //        break;

            //    default:
            //        sonuc = 0;
            //        break;
            //}
            //if (sonuc == 0)
            //{
            //    Console.WriteLine("tanımlanmamış değer ");

            //}
            //else
            //{
            //    Console.WriteLine(sonuc);
            //}


            //x--> x<10  ise 2 ile çarp
            //x--> 11-20 arasında ise 3 ile çarp
            //x--> 21-50 arasında ise 4 ile çarp
            //x--> 51-100 arasında ise 5 ile çarp
            //x--> x>100 ise 10 ile çarp

            // --------------------------ÇÖZÜM 1  İF İLE :

            //int x = 150;

            //int katsayi = 0;
            //if (x<10)
            //{
            //    katsayi =2;
            //}
            //else if(x<=20)
            //{
            //    katsayi =  3;
            //}
            //else if (x<=50)
            //{
            //    katsayi =  4;
            //}
            //else if (x<=100)
            //{
            //    katsayi= 5;
            //}
            //else
            //{
            //    katsayi= 10;
            //}
            //int sonuc = x * katsayi;
            //Console.WriteLine($"x= {x} , Sonuc = {x}*{katsayi} = {sonuc} ");

            //***------------------------- ÇÖZÜM 2 SWTİCH CASE İLE**


            //int x = 150;
            //int katsayi = 0;

            //switch (x)
            //{
            //    case (>=0 and <=10):
            //        katsayi = 2;
            //        break;
            //    case (>= 11 and <= 20):
            //        katsayi = 3;
            //        break;
            //    case (>= 21 and <= 50):
            //        katsayi = 4;
            //        break;
            //    case (>= 51 and <= 100):
            //        katsayi=5;
            //        break;              
            //   default:
            //        katsayi = 10;
            //        break;
            //}
            //int sonuc = x * katsayi;
            //Console.WriteLine($"x= {x} , Sonuc = {x}*{katsayi} = {sonuc} ");



            // ÖRNEK : İÇİNDE BULUNDUĞUMUZ GÜNÜN HAFTA İÇİMİ HAFTA SONU MU OLDUĞUNU BULALIM
            
            DayOfWeek gun = DateTime.Now.DayOfWeek;                     
            //if (gun==DayOfWeek.Sunday || gun==DayOfWeek.Saturday)
            //{
            //    Console.WriteLine("Hafta sonundasın.");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta içi ");
            //}
            // BAŞKA BİR GÜN İÇİNN------------------- birdaha bak eksik var

            //DateTime tarih = new DateTime(2022, 10, 8);
            //DayOfWeek gun = DateTime.DayOfWeek;
            //if (gun == DayOfWeek.Sunday || gun == DayOfWeek.Saturday)
            //{
            //    Console.WriteLine("Hafta sonundasın.");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta içi ");
            //}


////------------------SWİTCH CASE İLE YAPIMI**-*-*-*-**-*-*------

            switch(gun)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:    
                    case DayOfWeek.Friday:
                    Console.WriteLine("hafta ici");
                    break;
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                    Console.WriteLine("hafta soni");
                        break;
                default:
                    break;


            }









        }


    }
}