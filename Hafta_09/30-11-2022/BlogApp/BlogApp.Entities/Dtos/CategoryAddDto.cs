using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryAddDto
    {
        #region NameAnnotation
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        #endregion
        public string Name { get; set; }

        #region DescriptionAnnotation
        [DisplayName("Açıklama")]
       
        [MaxLength(50)]
        #endregion
        public string Description { get; set; }
        

        #region IsActiveAnnotation
        [DisplayName("Aktif Mi ?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]

        #endregion
        public bool IsActive { get; set; }
    }
}
