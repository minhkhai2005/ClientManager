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
                this.Close();
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
    }
}
