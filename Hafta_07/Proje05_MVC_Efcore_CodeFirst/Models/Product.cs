using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje05_MVC_Efcore_CodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }//Bu yazım stiliyle Category entity'sinin IDsini otomatik olarak algılar.
        public Category Category { get; set; }//Category ID si neyse onun bilgilerini (name vs) vermye yarar.
    }
}