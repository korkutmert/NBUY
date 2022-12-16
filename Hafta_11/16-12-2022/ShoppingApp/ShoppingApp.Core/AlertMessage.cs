using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    // Uygulama içinde çeşitli durumlarda ihtiyaç duydğumuz uyarı mesajları için kullanılacak bir tip.
    public class AlertMessage
    {
        public string Title { get; set; }//başlık
        public string Message { get; set; }// Uyarı MEsajı
        public string AlertType { get; set; }//Uyarı mesaıjının görünümü

    }
}
