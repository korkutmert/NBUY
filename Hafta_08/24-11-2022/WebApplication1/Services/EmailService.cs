namespace WebApplication1.Services
{
    public class EmailService : IEmailServices
    {
        public void Send(string to,string message, string topic)
        {
            Console.WriteLine($"{to}-{topic}-{message}");
        }
    }
}
