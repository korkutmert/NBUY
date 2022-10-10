namespace Proje15_ClassPropertyField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.OgrNo = 1234;
            ogrenci1.Ad = "Mert";
            ogrenci1.Sinif = "10K";


            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrNo = 16;
            ogrenci2.Ad = "Korkut";
            ogrenci2.Sinif = "11C";

            Ogrenci ogrenci3 = new Ogrenci() { OgrNo = 15, Ad = "Umay", Sinif = "10C" };
            Ogrenci[]  ogrenciler = {ogrenci1,ogrenci2,ogrenci3};

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($" Ad : {ogrenciler[i].Ad} <----> Sınıf : {ogrenciler[i].Sinif} ");
            //}

            //foreach (var siradakiOgrenci in ogrenciler)
            //{
            //    Console.WriteLine(siradakiOgrenci.Ad + " , " + siradakiOgrenci.Sinif);

            //}

            //int[] sayilar = { 32, 54, 33 };
            //foreach (var sıradakiSayi in sayilar)
            //{
            //    Console.WriteLine(sıradakiSayi*sıradakiSayi);
            //}


        }
        class Ogrenci
        {
            private int ogrNo;

            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }
            private string ad;

            public string Ad
            {
                get { return ad.ToUpper(); }
                set { ad = value; }
            }


            public string Sinif { get; set; }

            
        } 



    }
}