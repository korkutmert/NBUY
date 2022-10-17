namespace Proje04_TipDönüştürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte a = 5;
            //short b = 10;
            //sbyte c = 30;// Eksi sayılar da yazılabilir. 8 bittir. Ancak 1 bitini - işareti için kullanır ve 7 bit sayı yazabilir.
            //int d = a + b + c;// Örtülü dönüştürme 
            //Console.WriteLine($"Sonuç(d)= {d} ");

            //string metin = "NBUY";
            //char karakter = 'K';
            //object e = metin + karakter + d ; // Örtülü dönüştürme-Implicit convert
            //Console.WriteLine($"object= {e}");

            //  byte a = 155;
            //  byte b = 101;
            //  byte c = Convert.ToByte(a + b); // Explicit convert - bilinçli dönüşüm
            //  Console.WriteLine($"Sonuç(c): {c}");
            //  byte d = (byte)(a + b);// Unboxing işlemi--> 256 dan itibaren sıfırlanır baştan sayar.


            //  Console.WriteLine($"Sonuç(d): {d}");

            //int a = 500;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            byte a = 155;
            byte b = 101;
            int c = a + b;
            Console.WriteLine(c);


            Convert.ToInt64
            Convert.ToDouble 
        }
    }
}