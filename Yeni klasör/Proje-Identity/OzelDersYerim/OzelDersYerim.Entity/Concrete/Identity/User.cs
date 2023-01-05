using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Entity.Concrete.Identity
{
    public class User :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string About { get; set; }
        public string Phone { get; set; }
        public string Experince { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal? PricePerHour { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
