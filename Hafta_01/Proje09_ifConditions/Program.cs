namespace Proje09_ifConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if (bool)
             * {
             *     bool true ise yapılacak işler
             * }
             */
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 >= 0)
            //{
            //    Console.WriteLine("merhaba dünya . ");
            //}




            //Kullancııdan yaşını girmesini isteyelim 
            // 18 yaşından küçüklere giriş yasak yazdıralım.  

            //Console.Write("Yaş gir ");
            //byte yas = Convert.ToByte(Console.ReadLine());

            //if (yas < 18)
            //{
            //    Console.WriteLine("18 yaşından küçüklere giriş yasak ");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş serbest. ");
            //}

            // ********* Girline iki sayıdan büyük olanı yaz

            //Console.Write("1. sayıyı gir");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gir");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1>sayi2)

            //{
            //    Console.WriteLine($"Büyük Sayı : {sayi1}");
            //}
            //else if  (sayi2>sayi1)
            //{
            //    Console.WriteLine($"Büyük Sayı : {sayi2} ");

            //}
            //else
            //{
            //    Console.WriteLine($"Sayı 1 ({sayi1}) ve sayı 2 ({sayi2}) birbirine eşittir.");
            // }
            //-----------------------------------------------
            // girilen üç sayıdan büyük olanı yaz

            //Console.Write("1. sayıyı gir");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. sayıyı gir");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("3. sayıyı gir");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    if (a>c)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}
            // if (b > a)
            //{
            //    if(b>c)
            //    {
            //        Console.WriteLine(b);
            //    }
            //}
            // if(c > a)
            //{
            //    if (c>b)

            //    {
            //        Console.WriteLine(c);
            //    }
            //}

            //---------*****--*-*-*-*-*-*-*-*-*-*-*-* aynı örneğin farklı çözümü
            //Console.Write("1. sayıyı gir");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. sayıyı gir");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("3. sayıyı gir");
            //int c = Convert.ToInt32(Console.ReadLine());

            //if (a>=b && a>=c )

            //{
            //    Console.WriteLine(a);
            //}
            //else if (b>=a && b>=c)
            //{
            //    Console.WriteLine(b);
            //}
            //else if (c>=a && c>=b)
            //{
            //    Console.WriteLine(c);
            //}

            Console.Write("1. sayıyı gir : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı gir : ");
            int b = Convert.ToInt32(Console.ReadLine());

            string sonuc = a > b ? " a büyüktür b " :
                                    b > a ? " b büyüktür a " : 
                                                " ikiside eşittir.";

            Console.WriteLine(sonuc);
            
            
            //int buyukSayi = a > b ? a : b;         // AŞAĞIDAKİNİN KISA YOLU .
            //Console.WriteLine(buyukSayi);


            //int buyukSayi = 0;
            //if (a>b)

            //{
            //    buyukSayi = a;
            //}
            //else if (b>a)
            //{
            //    buyukSayi = b;
            //}
           
            //Console.WriteLine(buyukSayi);
        }
    }
}