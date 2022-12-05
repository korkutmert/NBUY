using BlogApp.Entities.Dtos;

namespace BlogApp.Mvc.Areas.Admin.Models
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryAddDto CategoryAddDto { get; set; }
        public string CategoryAddPartial { get; set; } //json formatına dönüştürmek için string tipinde.
        public CategoryDto CategoryDto { get; set; }
    }
}
