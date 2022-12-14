namespace WebApplication1.Services
{
    public interface IEmailServices
    {
        void Send(string to, string message, string topic);
    }
}
