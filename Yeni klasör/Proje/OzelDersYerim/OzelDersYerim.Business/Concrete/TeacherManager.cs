using OzelDersYerim.Business.Abstract;
using OzelDersYerim.Data.Abstract;
using OzelDersYerim.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersYerim.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeacherManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #region GENERİC
        public async Task CreateAsync(Teacher teacher)
        {
            await _unitOfWork.Teachers.CreateAsync(teacher);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(Teacher teacher)
        {
            _unitOfWork.Teachers.Delete(teacher);
            _unitOfWork.Save();
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _unitOfWork.Teachers.GetAllAsync();

        }
        public void Update(Teacher teacher)
        {
            _unitOfWork.Teachers.Update(teacher);
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            return await _unitOfWork.Teachers.GetByIdAsync(id);
        }
        #endregion

        #region TEACHER
        public async Task<List<Teacher>> GetHomePageTeachers()
        {
            return await _unitOfWork.Teachers.GetHomePageTeachersAsync();
        }
        public async Task<List<Teacher>> GetBranchByTeacher(string branch)
        {
            return await _unitOfWork.Teachers.GetBranchByTeacherAsync(branch);

        }

     
        #endregion


    }
}
