using DatabaseClass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DatabaseClass.DatabaseAccess;
using Sign_In;
using System.Diagnostics.Eventing.Reader;
namespace EmployeePage
{
    public partial class EmployeePage : UserControl
    {
        public EmployeePage()
        {
            InitializeComponent();
            LoadAllEmployees(); // gọi khi khởi tạo
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = listView1.SelectedItems[0];
            string employeeId = selectedItem.SubItems[0].Text;

            var employeeView = new EmployeeView.EmployeeView();  // form xem chi tiết
            employeeView.ShowDialog();
        }

        private void UpdateEmployeeList(List<Employee> employees)
        {
            listView1.Items.Clear();

            foreach (var emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.Employee_ID);
                item.SubItems.Add(emp.Employee_Name);

                string role = DatabaseAccess.roleemployee(emp.Employee_ID) ?? "Không xác định";
                item.SubItems.Add(role);

                item.SubItems.Add(emp.Employee_Email);

                string status = DatabaseAccess.statusEmployee(emp.Employee_ID);
                item.SubItems.Add(status);

                listView1.Items.Add(item);
            }
        }

        private void LoadAllEmployees()
        {
            try
            {
                string email = Sign_In.Sign_in.Session.Email;

                // Lấy nhân viên hiện tại
                Employee emp = DatabaseAccess.GetEmployeesByEmail(email);
                if (emp == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên với email đăng nhập.");
                    return;
                }

                // Lấy storeID từ nhân viên đó
                string storeID = emp.Store_ID;

                // Lấy danh sách nhân viên trong cùng cửa hàng
                var employees = DatabaseAccess.GetEmployeesByStoreID(storeID);
                UpdateEmployeeList(employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new list_empoyee();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadAllEmployees(); // reload danh sách nếu thêm thành công
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // có thể xử lý thêm nếu cần
        }
    }
}
