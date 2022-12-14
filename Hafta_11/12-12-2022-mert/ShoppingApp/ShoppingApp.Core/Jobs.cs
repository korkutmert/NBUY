using System;
using System.Collections.Generic;
using System.Linq;
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
         1) Latin alfabaesine çevrilirken problem çıkaran İ-i, ı-i dönüştümelri yapacak.
         2) Diğer Türkçe karakter yerie latin alfabesindeki karşılıklarını koyacak
         3) Boşluklar yerine - koyacak
         4) Nokta, slash gibi karakterleri kaldıracak.

         */
            #endregion

            #region Burada sorunlu karakterler düzeltiliyor
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            #endregion

            #region Küçük Harfe Dönüştürülüyor
            url = url.ToLower();

            #endregion

            #region Türkçe karakterler dönüştürülüyor.

            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion

            #region Boşluklar - ile değiştiriliyor.
            url = url.Replace(" ", "-");
            #endregion

            #region Sorunlu karakterler kaldırılıyor
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            #endregion

            return url;

        }
    }
}
