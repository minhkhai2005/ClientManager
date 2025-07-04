using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smtp;
using DatabaseClass;
using Sign_In;

namespace StoresList
{
    public partial class Add_Store : Form
    {
        public Add_Store()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (DatabaseAccess.GetStoreByEmail(Email.Text) == null)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống. Vui lòng kiểm tra lại.");
                return;
            }
            var newOtp = otp.GenerateOtp();
            otp.StoreOtp(Email.Text, newOtp);
            otp.SendOtpEmail(Email.Text, newOtp);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var enteredOtp = OtpTextBox.Text;
            if (otp.VerifyOtp(Email.Text, enteredOtp))
            {
                MessageBox.Show("OTP verified successfully!");
                // Here you can add code to proceed with adding the store
                var newStore = DatabaseAccess.GetStoreByEmail(Email.Text);
                if (newStore.Manager_ID != null)
                {
                    MessageBox.Show("Cửa hàng đã có quản lý");
                    return;
                }
                else
                {
                    newStore.Manager_ID = Sign_In.Sign_in.Session.UID;
                    newStore.UpdateStore();
                    MessageBox.Show("Cửa hàng đã được thêm thành công!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }
    }
}
