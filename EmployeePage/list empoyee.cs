using DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePage
{
    public partial class list_empoyee : Form
    {
        public list_empoyee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var newEmployee = new DatabaseAccess.Employee
                {
                    Employee_ID = Guid.NewGuid().ToString(),
                    Employee_Name = txtName.Text,
                    Employee_Gender = cbGender.Text.ToString(),
                    Employee_Birth = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Employee_PhoneNumber = txtPhone.Text,
                    Employee_Email = txtEmail.Text,
                    Employee_Salary = double.TryParse(txtSalary.Text, out double salary) ? salary : 0,
                    Store_ID = txtSTR.Text // hoặc GlobalSession.StoreID nếu bạn có
                };

                DatabaseAccess.CreateNewEmployee(newEmployee);

                MessageBox.Show("Thêm nhân viên thành công!");
                this.DialogResult = DialogResult.OK; // báo thành công cho form cha
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
