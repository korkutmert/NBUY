using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// DTO : DATA TRANSFER OBJECT : Sadece veri taşımak için kullandığımız nesne yaratır
namespace BlogApp.Entities.Dtos
{
    public class ArticleAddDto
    {
        #region TitleAnnotation
        /*0*/
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")] // buradaki 0 ; Titl'in 0.sıradaki özelleiğidir. Yani 0. indekste displayName var ve oraya onu yazacak. Bunlar bilgi olarak verilen özellikleridr yani error message sayılmaz.
        /*1*/
        [MaxLength(150, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        /*1*/
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalıdır.")]
        #endregion
        public string Title { get; set; }

        #region ContentAnnotation
       
        [DisplayName("içerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")] 
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalıdır.")]
        #endregion
        public string Content { get; set; }

        #region ThumbnailAnnotation

        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalıdır.")]
        #endregion
        public string Thumbnail { get; set; }

        #region DateAnnotation

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        #endregion
        public DateTime Date { get; set; }

        #region SeoAuthorAnnotation
        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")] 
        [MaxLength(50, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        
      
        #endregion
        public string SeoAuthor { get; set; }

        #region SeoDescriptionAnnotation
        [DisplayName("Seo Açıklamaları")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]


        #endregion
        public string SeoDescription { get; set; }

        #region SeoTagsAnnotation
        [DisplayName("Seo Etiketleri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]


        #endregion
        public string SeoTags { get; set; }

        #region CategoryIdAnnotation
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        


        #endregion
        public int CategoryId { get; set; }

        public Category Category  { get; set; }

        #region IsActiveAnnotation
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir." )]

        #endregion
        public bool IsActive { get; set; }
    }
}
