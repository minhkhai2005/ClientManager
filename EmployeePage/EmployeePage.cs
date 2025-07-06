using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace EmployeePage
{
    public partial class EmployeePage: UserControl
    {
      
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string employeeId = selectedItem.SubItems[0].Text;
            EmployeeView.EmployeeView employeeView = new EmployeeView.EmployeeView();
            employeeView.ShowDialog();
        }
        private void UpdateEmployeeList(List<string[]> employees)
        {
            listView1.Items.Clear();
            foreach (var employee in employees)
            {
                ListViewItem item = new ListViewItem(employee[0]); // Employee ID
                item.SubItems.Add(employee[1]); // Employee Name
                string role = DatabaseAccess.roleemployee(employee[0]) ?? "Không xác định";
                item.SubItems.Add(role); // Role
                item.SubItems.Add(employee[8]);
                string status = DatabaseAccess.statusEmployee(employee[0]);
                item.SubItems.Add(status); // Status

                listView1.Items.Add(item);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
