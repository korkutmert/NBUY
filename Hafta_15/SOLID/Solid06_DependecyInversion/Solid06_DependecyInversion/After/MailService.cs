using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid06_DependecyInversion.After
{
    public class MailService
    {
        public void SendMail(IMailServer server, string to,string body)
        {
            server.Send(to,body);
        }
    }
}
