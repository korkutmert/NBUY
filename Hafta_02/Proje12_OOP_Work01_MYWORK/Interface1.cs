using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work01
{
    public interface INameAndId
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
   public interface IOgrenci : INameAndId
    {
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }

}
