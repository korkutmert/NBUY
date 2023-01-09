using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_SingleResponsiblity.Before
{
    public class Customer
    {


        void Login(string username, string password)
        {
            // Login işlemeleri
        }
        void Register(string username, string password, string email)
        {
            // register işlemeleri
            SendMail("Kaydınız Başarıyla Gerçekleşmiştir.");
        }

        void SendMail(string text)
        {
            //Mail gönderme işlemleri ilgili kodlar.
        }

    }
}
