using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Runtime.Caching;


namespace smtp
{
    static public class otp
    {
        static public void StoreOtp(string email, string otp)
        {
            MemoryCache.Default.Set($"otp_{email}", otp,
                new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(5) });
        }

        static public bool VerifyOtp(string email, string inputOtp)
        {
            string storedOtp = MemoryCache.Default.Get($"otp_{email}") as string;
            if (storedOtp != null && storedOtp == inputOtp)
            {
                MemoryCache.Default.Remove($"otp_{email}");
                return true;
            }
            return false;
        }
        static public string GenerateOtp(int length = 6)
        {
            Random random = new Random();
            string otp = "";
            for (int i = 0; i < length; i++)
                otp += random.Next(0, 10).ToString();
            return otp;
        }
        static public void SendOtpEmail(string toEmail, string otp)
        {
            var fromAddress = new MailAddress("familyfamily4867@gmail.com", "OTP Service");
            var toAddress = new MailAddress(toEmail);
            const string fromPassword = "srxo serp kjbo zkjs"; // dùng app password
            const string subject = "Mã OTP của bạn xác nhận thêm cửa hàng mới";
            string body = $"Mã OTP của bạn là: {otp}";

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
