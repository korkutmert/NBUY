using Microsoft.EntityFrameworkCore;
using OzelDersYerim.Data.Abstract;
using OzelDersYerim.Data.Concrete.EfCore.Context;
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
        public EfCoreTeacherRepository(OzelDersYerimContext context) : base(context)
        {
        }
        
        private OzelDersYerimContext OzelDersYerimContext
        {
            get { return _context as OzelDersYerimContext;}
        }


        public Task<List<Teacher>> GetBranchByTeacherAsync(string branch)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            return await OzelDersYerimContext.
                Teachers.
                Where(t => t.IsHome == true)
                .ToListAsync();



        }
    }
}
