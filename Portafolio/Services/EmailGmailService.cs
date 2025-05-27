using System.Net.Mail;
using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IEmailService
    {
        Task Send(ContactViewModel contact);
    }
    public class EmailGmailService : IEmailService
    {

        private readonly IConfiguration _configuration;
        public EmailGmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Send(ContactViewModel contact)
        {
            var fromEmail = _configuration.GetValue<string>("EMAIL_CONFIGURATIONS:EMAIL");
            var password = _configuration.GetValue<string>("EMAIL_CONFIGURATIONS:PASSWORD");
            var host = _configuration.GetValue<string>("EMAIL_CONFIGURATIONS:HOST");
            var port = _configuration.GetValue<int>("EMAIL_CONFIGURATIONS:PORT");

            var smtpClient = new SmtpClient(host, port);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;

            smtpClient.Credentials = new System.Net.NetworkCredential(fromEmail, password);
            var mailMessage = new MailMessage(fromEmail, fromEmail, $"New Contact from {contact.Name}, {contact.Email}", contact.Message);

            await smtpClient.SendMailAsync(mailMessage);

        }

    }
    
}