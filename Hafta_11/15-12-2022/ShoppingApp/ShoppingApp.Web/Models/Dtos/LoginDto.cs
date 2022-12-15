using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Models.Dtos
{
    public class LoginDto
    {
        [DisplayName("Kulanıcı Adı")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı.")]
        public string UserName { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
