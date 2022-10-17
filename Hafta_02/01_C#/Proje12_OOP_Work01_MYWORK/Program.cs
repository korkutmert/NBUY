namespace Proje12_OOP_Work01
{
    public class Program
    {
        public static List<Ogrenci> Ogrenciler { get; private set; }

        static void Main(string[] args)
        {
            List<Bolum> bolums = new List<Bolum>()
                {
                new Bolum()
                {
                    Id=
                    Ad="",
                    Description="asdsa";
            Ogrenciler = new List<Ogrenci>()
                    {
                        new Ogrenci(){Id=1,OgrNo=400,Ad="ali",Soyad="asdasasd",Yas=10},
                        new Ogrenci(){Id=2,OgrNo=500,Ad="veli",Soyad="asdaadsd",Yas=11},
                        new Ogrenci(){Id=3,OgrNo=600,Ad="mert",Soyad="asdadsd",Yas=13}
                    };
        }
            
             
            }        }
    }
}