using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authentication;
using Sign_Up;
using Dapper;
using DatabaseClass;

namespace Sign_In
{
    public partial class Sign_in: Form
    {
        public static class Session
        {
            public static string Email { get; set; }
            public static string UID { get; set; }
            public static string ManagerID { get; set; }
            public static string ManagerName { get; set; } // Thêm biến lưu tên manager
        }
        public Sign_in()
        {
            InitializeComponent();
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {
            var result = await FirebaseAuthentication.SignIn(EmailBox.Text, PasswordBox.Text);
            if (result.Item1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Session.Email = EmailBox.Text;
                DatabaseAccess.CurrentEmail = EmailBox.Text; // Lưu email vào DatabaseAccess

                Session.UID = result.Item2; // Lưu UID vào Session
                var manager = DatabaseAccess.GetManagerByEmail(Session.Email);
                if (manager != null)
                {
                    Session.ManagerID = manager.Manager_ID;
                    Session.ManagerName = manager.Manager_Name; // Gán tên manager
                }
                else
                {
                    Session.ManagerID = null;
                    Session.ManagerName = null;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sign_up sign_Up = new Sign_up();
            sign_Up.ShowDialog();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private async void PasswordReset_Click(object sender, EventArgs e)
        {
            // show a message box to comfirm the action
            var result = MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Open the ResetPassword form
                bool sendRequestResult = false;
                await Task.Run(() => sendRequestResult =  FirebaseAuthentication.SendResetPasswordEmail(EmailBox.Text).Result);
                if (!sendRequestResult)
                {
                    MessageBox.Show("Không thể gửi yêu cầu đặt lại mật khẩu. Vui lòng kiểm tra lại email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Đã gửi yêu cầu đặt lại mật khẩu. Vui lòng kiểm tra email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Do nothing
            }
        }
    }
}
