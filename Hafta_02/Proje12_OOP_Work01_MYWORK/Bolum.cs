using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work01
{
    public class Bolum : INameAndId
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Description { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

    }
    public class Ogrenci : IOgrenci
    {
        public int Id { get; set; }
        public int OgrNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }      
        public int Yas { get; set; }
        

    }
}
