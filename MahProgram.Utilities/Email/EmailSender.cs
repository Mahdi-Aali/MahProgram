using System.Net.Mail;
using System.Net;
using MahProgram.Utilities.Logging;

namespace MahProgram.Utilities.Email;

public static class EmailSender
{
    public async static Task<bool> SendAsync(string to, string subject, string body)
    {
        try
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("mahdi1383harold@outlook.com");
            message.To.Add(new MailAddress(to));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = EmailBody.AnswereContactUsBody(body);
            smtp.Port = 587;
            smtp.Host = "smtp.office365.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("mahdi1383harold@outlook.com", "m4#d1@4l1");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            await smtp.SendMailAsync(message);
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }
}
