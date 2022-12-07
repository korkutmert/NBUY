using ShoppingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class Product : IEntityBase
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public decimal? Price { get; set; }// Bu soru işareti bu property ' yi nullable yaptı. Boş bırakıaliblsin dedik çünkü değer vermeyi unutursak kendisi otomatik 0 veriyor bunu istemiyoruz.
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsHome { get; set; }
        public bool  IsApproved { get; set; }
        public DateTime DateAdded { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }// SAdece ilişki kurmak için

    }
}
