using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeAdd
{
    public partial class EmployeeAdd : UserControl
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string startDate = dtpStartDate.Value.ToShortDateString();
            string role = txtRole.Text;
            string salary = txtSalary.Text;
            string phone = txtPhone.Text;
            string shift = txtShift.Text;
            string email = txtEmail.Text;
            string dob = dtpDOB.Value.ToShortDateString();
            string storeID = txtStoreID.Text;

            // Hiển thị thông báo thành công
            MessageBox.Show($"Nhân viên đã được thêm thành công!\n\nNgày bắt đầu: {startDate}\nVai trò: {role}\nLương: {salary}\nĐiện thoại: {phone}\nCa làm việc: {shift}\nEmail: {email}\nNgày sinh: {dob}\nMã cửa hàng: {storeID}",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void employeeStartDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void storeIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
