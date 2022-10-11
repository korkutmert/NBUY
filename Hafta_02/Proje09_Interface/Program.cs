using Proje09_Interface;
using System.Runtime.Intrinsics.Arm;

namespace Proje09_Interface
{
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKisi

    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        
        public int    Maas { get; set; }
        public void Bilgi();//Interfaceler içindeki metotlarda sadece İMZA bulunur, metodun gövdesi olmaz.
        //Metodun gövdesi bu interfacei miras alan CLASS içinde doldurulur. 

    }
    class Yonetici : IKisi, IPersonel
                                    //Bir interface 'den miras alırsen içindeki herşey miras alan classın içine somut               olarak aktarılır. !!****!!!
                                    //Bir class birden fazla interfaceden miras alabilir. !!!****!!!
                                    //Bir class ; 1 Class ve 1 interfaceden miras almak istiyorsa önce class YAZILIR!!!!                
                                    //Interface new yapılamaz.
          
        public Yonetici()
    {

    }
    /// <summary>
    /// Bu metot AdSoyad, Adres, Maas ve Departman bilgileri girilerek Yonetici oluşturrur.
    /// </summary>
    /// <param name="adSoyad">Ad soyad giriniz.</param>
    /// <param name="adres">adres giriniz.</param>
    /// <param name="maas">Maas giriniz.</param>
    /// <param name="departman">Departman giriniz.</param>
        public Yonetici(string adSoyad, string adres, int maas, string departman) 
    {
        AdSoyad = adSoyad;
        Adres = adres;
        Maas = maas;
        Departman = departman; 
    }
    
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Departman { get; set; }
        public int Maas { get; set; }

        public void Bilgi()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        // Bir abstract classtan miras alan classta eğer base classta abstract bir metotlar varsa mutlaka override edilemli .Eğer base classta abstract olmayan bir metotlar varsa onlar aynen kullanılabilir.Ancak bazen miras alınan classtaki her metodun, içinin dolu hallerini yazmak zorunlu olsun isteriz.
        //Yani birnevi hepsi abstract olsun isteriz. Bunu yapmak yerine miras alma classı, class değil INTERFACE şeklinde tanımlarız.
        //KENDİ NOTUM : INTERFACE ABSTRACT YAZMAYI ORTADAN KALDIRIR. TÜM METOTALR NESNE İSE KULLAN.

        IPersonel personel = new IPersonel();//HAtalı Kullanım
        Yonetici yonetici = new Yonetici();
        Yonetici yonetici1 = new Yonetici("Mert Muslu","İstanbul",5000,"Developer");        
        }
    }
}