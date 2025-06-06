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
using DatabaseClass;


namespace Sign_Up
{
    public partial class Sign_up: Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }
        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            var isSuccess = await FirebaseAuthentication.SignUp(EmailBox.Text, PasswordBox.Text);
            if (isSuccess.Success)
            {
                MessageBox.Show("Đăng ký thành công. Vui lòng kiểm tra email để xác nhận tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatabaseAccess.CreateNewManager(new DatabaseAccess.Manager { 
                    Manager_Email = isSuccess.Email, 
                    Manager_ID = isSuccess.UID,
                    Manager_Name = NameBox.Text,
                    Manager_Phone = Phone.Text,
                });
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
