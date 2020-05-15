using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Nursoft.Service
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Nursoft saytının administrasiyası", "admin@nursoft.az"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("mail.hosting.reg.ru", 587, false);
                await client.AuthenticateAsync("admin@nursoft.az", "nursoft2020");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}