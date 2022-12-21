using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs
    {
        public static string InitUrl(string url)
        {
            #region Açıklamalar
            /*Bu metot kendisine gelen url değişkeninin içindeki 
             * 1) Latin alfabesine çevrilirken problem çıkaran İ-i, I-i gibi dönüştürmeleri yapacak. 
             * 2) Türkçe karakterlerin yerine latin alfabesindeki karşılıklarını koyacak.
             * 3) Boşluklar yerine - koyacak.
             * 4) Nokta( . ), slash( / ) gibi karakterleri kaldıracak.
             */
            #endregion

            #region SorunluKarakterlerDüzeltiliyor
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion
            
            #region KüçükHarfeDönüştürülüyor
            url = url.ToLower();
            #endregion
            
            #region TürkçeKarakterlerDönüştürülüyor
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion
            
            #region BoşluklarTireİleDeğiştiriliyor
            url = url.Replace(" ", "-");
            #endregion
            
            #region SorunluKarakterlerKaldırılıyor
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("}", "");
            url = url.Replace("{", "");
            #endregion

            return url;
        }
        public static string UploadImage(IFormFile image)
        {
            var extension = Path.GetExtension(image.FileName); //Gelen image'in FileName'inin uzantısını alıyoruz. Yani .jpeg, .png vb olan kısmı alıyoruz. 
            var randomName = $"{Guid.NewGuid()}{extension}"; //değiştirilmiş olan ismin sonuna .jpeg, .png olarak eklenmiş olur.Örneğin 2.png isimli resim aq45we8hld5.png olarak random isimle değişmiş olacak.
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", randomName); // Sitemizin adını GetCurrentDirectory ile alıyor, wwwroot/images teki resimleri randomName değişkeniyle random isimle üretmiş olduk.
            using (var stream = new FileStream(path,FileMode.Create)) //path kısmındaki belirtilen adresteki resimi, yeni random adıyla yarat.
            {
                image.CopyTo(stream); //
            }
            return randomName;
        }
        public static string CreateMessage(string title, string message, string alertType)
        {
            var msg = new AlertMessage
            {
                Title = title,
                Message = message,
                AlertType = alertType
            };
            return JsonConvert.SerializeObject(msg);
        }
        /*
         * CreateMessage("Dikkat", "Kayıt silinecektir!", "danger");
         *                 title            message       alertType
         */
    }
}
