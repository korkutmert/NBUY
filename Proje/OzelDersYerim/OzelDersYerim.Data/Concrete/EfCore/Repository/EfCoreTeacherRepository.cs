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


        public async Task<List<Teacher>> GetBranchByTeacherAsync(string branch)
        {
            var teachers = OzelDersYerimContext
                .Teachers
                //.Where(t => t.User.EmailConfirmed == true)
                .AsQueryable();
            if (branch!=null)
            {
                teachers =
                    teachers.Include(t => t.TeacherBranches)
                    .ThenInclude(tb => tb.Branch)
                    .Where(t => t.TeacherBranches.Any(tb => tb.Branch.Url == branch));
            }
            return await teachers.ToListAsync();
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
