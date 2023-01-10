using Microsoft.AspNetCore.Mvc;
using OzelDersYerim.Business.Abstract;
using OzelDersYerim.Entity.Concrete;
using OzelDersYerim.Web.Models.Dtos;

namespace OzelDersYerim.Web.Controllers
{


    public class ChooseController : Controller
    {
        private readonly ITeacherService _teacherManager;

        public ChooseController(ITeacherService teacherManager)
        {
            _teacherManager = teacherManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TeacherList(string branchurl)
        {
            List<Teacher> teachers = await _teacherManager.GetBranchByTeacher(branchurl);
            List<TeacherDto> teacherDtos = new List<TeacherDto>();
            foreach (var teacher in teachers)
            {
                teacherDtos.Add(new TeacherDto
                {
                    Id = teacher.Id,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    PricePerHour = teacher.PricePerHour,
                    Age = teacher.Age,
                    ProfilePictureUrl = teacher.ProfilePictureUrl,
                    Url = teacher.Url,
                });
            }
            return View(teacherDtos);
        }
    }
}
