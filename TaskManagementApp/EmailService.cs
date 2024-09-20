using System.Net.Mail;
using System.Net;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace TaskManagementApp
{
    internal class EmailService
    {
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int port = 587;
        private readonly string senderEmail = "gytis760@gmail.com";
        private readonly string senderPassword = "qckv yzha yoxm tbne";

        public EmailService(){}

        public void SendPasswordResetEmail(string recipientEmail, string newPassword)
        {
            try
            {
               
                using (SmtpClient smtpClient = new SmtpClient(smtpServer, port))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;
                    
                    using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail))
                    {
                        mailMessage.Subject = "Password Reset";
                        mailMessage.Body = $"Your new password is: {newPassword}";

                        smtpClient.Send(mailMessage);
                    }
                }
                Console.WriteLine("Password reset email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending password reset email: {ex.Message}");
            }
        }
    }
}
