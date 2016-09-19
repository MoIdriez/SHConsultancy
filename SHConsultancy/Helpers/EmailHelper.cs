using System.Net.Mail;
using System.Text;

namespace SHConsultancy.Helpers
{
    public static class EmailHelper
    {   
//        public static void Send(string subject, string body)
//        {
//            MailMessage mail = new MailMessage("moidriez@gmail.com", "15108195@brookes.ac.uk")
//            {
//                Subject = subject,
//                Body = body
//            };
//
//            SmtpClient client = new SmtpClient
//            {
//                Port = 25,
//                DeliveryMethod = SmtpDeliveryMethod.Network,
//                UseDefaultCredentials = false,
//                Host = "smtp.google.com"
//            };
//
//            client.Send(mail);
//        }

        public static void Send(string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("moidriez@gmail.com", "H3lloYasmine2Google");

            MailMessage mm = new MailMessage("moidriez@gmail.com", "15108195@brookes.ac.uk", subject, body)
            {
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            client.Send(mm);

        }
    }
}