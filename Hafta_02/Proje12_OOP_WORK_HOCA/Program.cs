namespace Proje12_OOP_WORK_HOCA
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        

    }
    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Description { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
    class Ogrenci :IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    internal class Program
    {
        static string GirisYap(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();

        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i < 2; i++)
            {
                Bolum bolum=new Bolum();
                Console.Write($"{i+1}.Bolüm Id'sini giriniz : ");
                bolum.Id = int.Parse(Console.ReadLine());
                Console.Write($"{i+1}. Bölümün adı :");
                bolum.Ad = Console.ReadLine();
                Console.Write($"{i + 1}. Bölümün Açıklaması :");
                bolum.Description= Console.ReadLine();
                List<Ogrenci> ogrenciler = new List<Ogrenci>();
                for (int j = 0; j < 3; j++)
                {
                    Ogrenci ogrenci = new Ogrenci();

                    Console.Write($"{j+1}. Öğrenci Id :");
                    ogrenci.Id = int.Parse(Console.ReadLine());

                    Console.Write($"{j + 1}. Öğrenci NO :");
                    ogrenci.OgrNo = int.Parse(Console.ReadLine());

                    Console.Write($"{j + 1}. Öğrenci Ad :");
                    ogrenci.Ad = Console.ReadLine();

                    Console.Write($"{j + 1}. Öğrenci Soyad :");
                    ogrenci.Soyad = Console.ReadLine();

                    Console.Write($"{j + 1}. Öğrenci Yas :");
                    ogrenci.Yas = int.Parse(Console.ReadLine());
                    ogrenciler.Add(ogrenci);


                }
                bolum.Ogrenciler = ogrenciler;
                bolumler.Add(bolum);
            }
            foreach (var bolum in bolumler)
            {
                Console.WriteLine($"Bölüm Id : {bolum.Id}- BÖlüm AD :-{bolum.Ad}- Bölüm Açıklama : {bolum.Description}");
                foreach (var ogrenci in bolum.Ogrenciler)
                {
                    Console.WriteLine($"Öğrenci Id : {ogrenci.Id} - Öğrenci No : {ogrenci.OgrNo} - Öğrenci Adı : {ogrenci.Ad} - Öğrenci Soyadı : {ogrenci.Soyad} - Öğrenci Yaşı : {ogrenci.Yas}");
                }
                
            }
            
            Console.ReadLine();
        }
    }
}





//Console.Write($"{i+1}.Bolüm Id'sini giriniz : ");
//                bolum.Id = int.Parse(Console.ReadLine());
//                Console.Write($"{i+1}. Bölümün adı :");
//                bolum.Ad = Console.ReadLine();
//                Console.Write($"{i + 1}. Bölümün Açıklaması :");
//                bolum.Description= Console.ReadLine();