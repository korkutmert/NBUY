using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OzelDersYerim.Business.Abstract;
using OzelDersYerim.Entity.Concrete;
using OzelDersYerim.Web.Models.Dtos;

namespace OzelDersYerim.Web.Controllers;

public class HomeController : Controller
{

    private readonly ITeacherService _teacherService;

    public HomeController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    public async Task<IActionResult> Index()
    {
        List<Teacher> teachers = await _teacherService.GetHomePageTeachers();
        List<TeacherDto> teacherDtos = new List<TeacherDto>();
        foreach (var teacher in teachers)
        {
            teacherDtos.Add(new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Age = teacher.Age,
                BranchId = teacher.BranchId,               
                Location = teacher.Location,
                PricePerHour = teacher.PricePerHour,
                Url = teacher.Url,
                ProfilePictureUrl = teacher.ProfilePictureUrl,
            });
        }
        return View(teacherDtos);
    }


}
