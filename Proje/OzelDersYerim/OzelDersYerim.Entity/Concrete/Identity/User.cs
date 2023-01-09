using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OzelDersYerim.Entity.Concrete.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public List<Student> Students { get; set; } 
        public List<Teacher> Teachers { get; set; }

       
    }
}