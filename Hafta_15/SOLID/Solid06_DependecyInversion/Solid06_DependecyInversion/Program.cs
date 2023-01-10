//using Solid06_DependecyInversion.Before;
using Solid06_DependecyInversion.After;

namespace Solid06_DependecyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BEFORE
            //MailService mailService = new MailService();
            //mailService.SendMail(new GmailServer());
            #endregion
            #region AFTER
            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer()  ,"mert@gmail.com","selam");
            mailService.SendMail(new HotmailServer(),"mert@hotmailcom","selam");
            #endregion
        }
    }
}