using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace AplicacionSeguridad.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //  using var message = new MailMessage();
            //  message.To.Add(new MailAddress(email,email));
            //  message.From = new MailAddress("anthony-nek30@hotmail.com", "Prueba 2022");
            //  message.Subject = subject;
            //  message.Body = htmlMessage;
            //  message.IsBodyHtml = true;
            //  using var client = new SmtpClient("smtp.live.com", 25);
            //  client.Port = 25;
            //  //ajpadilla2023
            ////  client.EnableSsl = false;
            //  client.UseDefaultCredentials = false;
            //  client.Credentials = new NetworkCredential("anthony-nek30@hotmail.com", "");
            //  client.EnableSsl = false;
            MailMessage msg = new MailMessage();
            //Quien escribe al correo
            msg.From = new MailAddress("anthony-nek30@outlook.com");
            //A quien va dirigido
            msg.To.Add(new MailAddress(email));
            //Asunto
            msg.Subject = subject;
            //Contenido del correo
            msg.Body = htmlMessage;
            //Servidor smtp de hotmail
            SmtpClient clienteSmtp = new SmtpClient();
            clienteSmtp.Host = "smtp.live.com";
            clienteSmtp.Port = 587;
            clienteSmtp.UseDefaultCredentials = false;
            //Se envia el correo
            clienteSmtp.Credentials = new NetworkCredential("anthony-nek30@outlook.com", "", "smtp.live.com");
            clienteSmtp.EnableSsl = true;

             clienteSmtp.Send(msg);
            return Task.CompletedTask;

        }
    }
}
