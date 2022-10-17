namespace ErtesiGunun_Tarihi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime bugun = DateTime.Now;
            int gun = bugun.Day;
            int yil = bugun.Year;
            int ay = bugun.Month;

            if (gun == 31)

            {
                ay++;
            }
            if (ay == 12)
            {
                yil++;
            }
            DateTime sonuc = new DateTime(yil, ay, gun+1);
           
            Console.WriteLine(sonuc);
        }
    }
}