using System.Net;
using System.Net.Mail;
using System.Security;
using EmailSendServiceLib.Settings;

namespace EmailSendServiceLib
{
    public class EmailSendServiceClass
    {
        public static void SendMessage(MailMessage message, string user_name, SecureString user_password)
        {
            ServerSettings serverSettings = new ServerSettings("smtp.yandex.ru", 25);

            using (SmtpClient client = new SmtpClient(serverSettings.ServerAddress, serverSettings.ServerPort))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(user_name, user_password);

                client.Send(message);
            }
        }
    }
}
