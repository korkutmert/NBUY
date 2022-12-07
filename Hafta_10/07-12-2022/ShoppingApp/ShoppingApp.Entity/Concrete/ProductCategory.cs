using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } // Veri tabanında olmıycak
        public int CategoryId { get; set; }
        public Category Category { get; set; }// Veri tabanında olmıycak
    }
}
