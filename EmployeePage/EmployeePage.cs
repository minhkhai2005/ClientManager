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
using static DatabaseClass.DatabaseAccess;

namespace EmployeePage
{
    public partial class EmployeePage: UserControl
    {

        private string storeID;

        public EmployeePage(string storeID)
        {
            InitializeComponent();
            this.storeID = storeID;
            LoadAllEmployees(); // gọi luôn khi khởi tạo
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string employeeId = selectedItem.SubItems[0].Text;
            EmployeeView.EmployeeView employeeView = new EmployeeView.EmployeeView();
            employeeView.ShowDialog();
        }
        private void UpdateEmployeeList(List<Employee> employees)
        {
            listView1.Items.Clear();

            foreach (var emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.Employee_ID); // cột 0
                item.SubItems.Add(emp.Employee_Name);                  // cột 1

                string role = DatabaseAccess.roleemployee(emp.Employee_ID) ?? "Không xác định";
                item.SubItems.Add(role);                               // cột 2

                item.SubItems.Add(emp.Employee_Email);                 // cột 3

                string status = DatabaseAccess.statusEmployee(emp.Employee_ID);
                item.SubItems.Add(status);                             // cột 4

                listView1.Items.Add(item);
            }
        }

        private void LoadAllEmployees()
        {   
            var employees = DatabaseAccess.GetEmployeesByStoreID(storeID); // hoặc GlobalSession.StoreID
            UpdateEmployeeList(employees);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new list_empoyee(); // tạo một instance của form thêm nhân viên

            var result = addForm.ShowDialog(); // mở form thêm

            if (result == DialogResult.OK)
            {
                // Nếu thêm thành công, reload lại danh sách nhân viên
                LoadAllEmployees();
            }
        }
      

    }
}
