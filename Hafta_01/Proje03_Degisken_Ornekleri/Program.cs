namespace Proje03_Degisken_Ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 120;
            int sayi2 = 110;
            Console.WriteLine(sayi1 + "\n" + sayi2);
            Console.WriteLine($"SAYI 1 : {sayi1}\nSAYI2: {sayi2}");//$ işareti metinleri birleştirmeye yarar.
            Console.WriteLine(sayi1 + sayi2);

            //dönüştürme metodu
            Console.WriteLine(sayi1.ToString() + sayi2.ToString()); // tostring ile intten stringe dönüştürdük.
                                                                    // işleme girenlerden herhangi biri string ise diğerini de stringe çevirir.
                                                                    //örnek aşağıda

            string sayi3 = "120";
            int sayi4 = 20;
            Console.WriteLine(sayi3+sayi4);// Ekrana 12020 olarak yazar.
             // dönüştürme metodu
            Console.WriteLine(Convert.ToInt32(sayi3)+sayi4);// convert.toInt32(sayi3) ile string olan ifadeyi int'e cevirdik.


            Console.WriteLine("---------------------------");

            decimal a = 0.1m; /// ondalık hassasiyet çok önemliyse float kullan.
            decimal b = 0.7m;
            decimal c = 0.8m;
            Console.WriteLine(a+b);
            Console.WriteLine((a + b) == c );








        }
    }
}