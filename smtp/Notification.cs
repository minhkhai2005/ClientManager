using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace smtp
{
    public class Notification
    {
        static public void SendNotificationEmail(string toEmail, List<Tuple<string, string>> sch)
        {
            var fromAddress = new MailAddress("familyfamily4867@gmail.com", "Notification");
            var toAddress = new MailAddress(toEmail);
            const string fromPassword = "srxo serp kjbo zkjs"; // dùng app password
            const string subject = "YOUR SCHEDULE HAS BEEN CHANGED";
            string body = $@"Your schedule has been changed. Here is your new schedule for the week:
                Monday: {sch[0].Item1} - {sch[0].Item2}
                Tuesday: {sch[1].Item1} - {sch[1].Item2}
                Wednesday: {sch[2].Item1} - {sch[2].Item2}
                Thursday: {sch[3].Item1} - {sch[3].Item2}
                Friday: {sch[4].Item1} - {sch[4].Item2}
                Saturday: {sch[5].Item1} - {sch[5].Item2}
                Sunday: {sch[6].Item1} - {sch[6].Item2}
            ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
