using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Authentication
{
    class FirebaseAuthentication
    {
        static string apiKey = "AIzaSyBI5v4TWR-xOYnNiL8_7-C6PsBv36cm_mA"; // <-- Dán API Key ở đây
        static async Task<bool> CheckEmailVerified(string idToken)
        {
            var client = new HttpClient();
            var url = $"https://identitytoolkit.googleapis.com/v1/accounts:lookup?key={apiKey}";

            var payload = new
            {
                idToken = idToken
            };

            var response = await client.PostAsync(url, SerializeJson(payload));
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                //Console.WriteLine($"❌ Không kiểm tra được trạng thái email:\n{result}");
                return false;
            }

            dynamic userInfo = JsonConvert.DeserializeObject(result);
            return userInfo.users[0].emailVerified == true;
        }
        static async Task<bool> SendEmailVerification(string idToken)
        {
            var client = new HttpClient();
            var url = $"https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key={apiKey}";

            var payload = new
            {
                requestType = "VERIFY_EMAIL",
                idToken = idToken
            };

            var response = await client.PostAsync(url, SerializeJson(payload));
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;
            //Console.WriteLine("✅ Đã gửi email xác nhận. Vui lòng kiểm tra hộp thư.");
            //MessageBox.Show("Đã gửi email xác nhận. Vui lòng kiểm tra hộp thư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Console.WriteLine($"❌ Lỗi khi gửi email xác nhận: \n{result}");
            //MessageBox.Show($"Lỗi khi gửi email xác nhận: \n{result}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public class SignUpResult
        {
            public bool Success { get; set; }
            public string Email { get; set; }
            public string Username { get; set; }
            public string UID { get; set; }
        }
        public static async Task<SignUpResult> SignUp(string email, string password)
        {
            var client = new HttpClient();
            var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={apiKey}";

            var payload = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };

            var response = await client.PostAsync(url, SerializeJson(payload));
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var auth = JsonConvert.DeserializeObject<AuthResponse>(result);
                //Console.WriteLine($"Đăng ký thành công! idToken: {auth.idToken}");
                //MessageBox.Show("Đăng ký thành công!\nXác nhận email để hoàn tất đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await SendEmailVerification(auth.idToken);
                
                return new SignUpResult
                {
                    Success = true,
                    Email = auth.email,
                    Username = "", 
                    UID = auth.localId
                };
            }
            else
            {
                //Console.WriteLine($"Lỗi khi đăng ký:\n{result}");
                //MessageBox.Show($"Lỗi khi đăng ký:\n{result}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new SignUpResult
                {
                    Success = false,
                    Email = email,
                    Username = "", 
                    UID = null
                };
            }
        }

        public static async Task<bool> SignIn(string email, string password)
        {
            var client = new HttpClient();
            var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={apiKey}";

            var payload = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };

            var response = await client.PostAsync(url, SerializeJson(payload));
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var auth = JsonConvert.DeserializeObject<AuthResponse>(result);

                // Kiểm tra xác minh email
                bool verified = await CheckEmailVerified(auth.idToken);
                if (!verified)
                {
                    //Console.WriteLine("❌ Tài khoản chưa xác minh email. Vui lòng kiểm tra hộp thư.");
                    //MessageBox.Show("Tài khoản chưa xác minh email. Vui lòng kiểm tra hộp thư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //Console.WriteLine($"✅ Đăng nhập thành công! idToken: {auth.idToken}");
                return true;
            }
            else
            {
                //Console.WriteLine($"❌ Lỗi khi đăng nhập:\n{result}");
                return false;
            }
        }

        static StringContent SerializeJson(object data) =>
            new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
    }

    public class AuthResponse
    {
        public string idToken { get; set; }
        public string email { get; set; }
        public string refreshToken { get; set; }
        public string expiresIn { get; set; }
        public string localId { get; set; }
    }
}
