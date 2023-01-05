using Microsoft.EntityFrameworkCore;
using OzelDersYerim.Data.Abstract;
using OzelDersYerim.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Data.Concrete.EfCore.Repository
{
    public class EfCoreTeacherRepository : EfCoreGenericRepository<Teacher>, ITeacherRepository
    {
        public EfCoreTeacherRepository(DbContext context) : base(context)
        {
        }

        public Task<List<Teacher>> GetBranchByTeacherAsync(string branch)
        {
            throw new NotImplementedException();
        }

        public Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
