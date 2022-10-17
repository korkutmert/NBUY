namespace mertOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // İçinde Türkçe karakterler hariç tüm küçük harfler, 0-9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız.*/
            //******************************************

            

            //string[] a = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "w", "x", ".", ",", "+", "-", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
           
            //string sifre = "";


            //for (int i = 0; i < 6; i++)
            //{
            //    Random r = new Random();
            //    sifre = sifre + a[r.Next(a.Length)];
                
            //}
            //Console.WriteLine($"6 Haneli Rastgele Şifreniz: {sifre}");


            string[] b = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "w", "x", ".", ",", "+", "-", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            for (int i = 0; i < 6; i++)
            {
                Random rnd = new Random();
                b[i]= Convert.ToString(b[rnd.Next(b.Length)]);
                Console.Write(b[i]);
            }
            
        }
    }
}


















































        
    
