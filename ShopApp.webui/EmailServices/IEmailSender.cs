using System.Threading.Tasks;

namespace ShopApp.webui.EmailServices
{
    public interface IEmailSender
    {        
         Task SendEmailAsync(string email, string sunject,string htmlMessage);
    }
}