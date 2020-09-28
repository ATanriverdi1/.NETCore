using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MarketingApp.WebUI.EmailServices
{
    
    public class SmtpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;
        public SmtpEmailSender(string host, int port, bool enableSSL, string username, string password)
        {
            this._host = host;
            this._port = port;
            this._enableSSL = enableSSL;
            this._userName = username;
            this._password = password;
        }
        
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host,this._port)
            {
                Credentials = new NetworkCredential(_userName,_password),
                EnableSsl = this._enableSSL
            };

            return client.SendMailAsync(
                new MailMessage(this._userName,email,subject,htmlMessage){
                    IsBodyHtml = true
                }
            );
        }
    }
}