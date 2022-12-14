
namespace WebApplication1.Services
{
    public class SendGridEmailService : IEmailServices
    {
        public void Send(string to, string message, string topic)
        {
            throw new NotImplementedException();
        }

        public void To(string to, string message, string topic)
        {
            To(to,message,topic);
        }
    }
}


