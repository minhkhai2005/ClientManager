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
using  System.Net.Mail;
using static System.Net.WebRequestMethods;

namespace EmployeePage
{
    public partial class addEmployee: Form
    {
        private static DatabaseClass.DatabaseAccess.Employee emp = new DatabaseClass.DatabaseAccess.Employee();
        public addEmployee()
        {
            InitializeComponent();
        }

        private void SendOTPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress email = new MailAddress(emailTextBox.Text);
                // check there is an employee with this email
                emp = DatabaseClass.DatabaseAccess.GetEmployeeByEmail(email.Address);
                if (emp != null)
                {
                    // check if this employee has assign to a store
                    if (emp.Store_ID != null)
                    {
                        MessageBox.Show("This employee has already been assigned to a store.");
                        return;
                    }
                    else {
                        Task.Run(() =>
                        {
                            string OTP = otp.GenerateOtp();
                            otp.StoreOtp(email.Address, OTP);
                            otp.SendOtpEmail(email.Address, OTP, "OTP code to confirm your new employee");
                        });
                    }
                }
                else
                {
                    MessageBox.Show("Email does not exist in the system. Please check again.");
                    return;
                }   
            }
            catch
            {
                MessageBox.Show("Invalid email address, please try again.");
                return;
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string enteredOtp = otpTextBox.Text;
            if (otp.VerifyOtp(emailTextBox.Text, enteredOtp))
            {
                MessageBox.Show("OTP verified successfully!");
                // Here you can add code to proceed with adding the employee
                emp.Store_ID = Sign_In.Sign_in.Session.UID;
                emp.UpdateEmployee();
                MessageBox.Show("Employee has been added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid OTP, please try again.");
            }
        }
    }
}
