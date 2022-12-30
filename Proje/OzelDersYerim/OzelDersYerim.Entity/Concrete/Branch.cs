using OzelDersYerim.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Entity.Concrete
{
    public class Branch : IEntityBase
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }
}
