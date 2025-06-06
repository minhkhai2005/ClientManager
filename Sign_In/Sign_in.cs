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


namespace Sign_In
{
    public partial class Sign_in: Form
    {
        public static class Session
        {
            public static string Email { get; set; }
        }
        public Sign_in()
        {
            InitializeComponent();
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {
            bool result = await FirebaseAuthentication.SignIn(EmailBox.Text, PasswordBox.Text);
            if (result)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Session.Email = EmailBox.Text;
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
