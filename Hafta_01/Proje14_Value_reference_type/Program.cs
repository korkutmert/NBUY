using System.Reflection.Metadata;

namespace Proje14_Value_reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;
            Random r = new Random();
            Kisi kisi1 =new Kisi();
           
            kisi1.Ad = "Mert";
            kisi1.Yas = 23;
            kisi1.Meslek = "sdses";

            Kisi kisi2 = new Kisi();
            kisi2.Ad = " Ali";
            kisi2.Yas = 21;
            kisi2.Meslek="Öğretmen";
           
            Kisi kisi3 = new Kisi();
            kisi3.Ad = " Akmet";
            kisi3.Yas = 40;
            kisi3.Meslek="Mühendis";



            Araba araba1 = new Araba();
            araba1.Marka =  "Opel";
            araba1.Renk = "Kırmızı";

            DateTime bugun = DateTime.Now;
            Random r2 = new Random();
            


        }
        class Kisi
        {
            public string Ad { get; set; } // Public olanlar dısardan erişilebiir.
                                            // Private olanlara dısardan erişim yok sadece bu                          classtan erişilir. Hiç birsey yazmazsa da privatedir.
            public int Yas  { get; set; }
            public string Meslek { get; set; }

            //Erişiö Belirleyici : Bir propertynin dışarıdan yani içinde bulunduğu class ın dışından erişim seviyesini belirleyen ahatar sözcüklere denir.Eğer herhangi bir erişim belirleyici kullanılmamışsa default erişim belirleyici private olarak kabul edilir.
            /* Erişim belirleyiciler
             * 1)Public
             * 2)Private
             * 3)internal
             * 4)protected
             */


        }
        class Araba
        {
            public string Marka { get; set; }
            public string Renk { get; set; }
             string VitesTuru { get; set; }
        }
    }
}