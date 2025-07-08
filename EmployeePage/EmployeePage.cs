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
        List<Employee> employees = new List<Employee>();
        public EmployeePage()
        {
            InitializeComponent();
            FetchEmployeesList();
            UpdateEmployeeList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployee addEmployee = new addEmployee();
            addEmployee.ShowDialog();
        }

        private void EmployeeListView_ItemActivate(object sender, EventArgs e)
        {

        }
        private void FetchEmployeesList()
        {
            employees = DatabaseAccess.GetEmployeesByManagerID(Sign_in.Session.UID);
        }
        private void UpdateEmployeeList() 
        {
            EmployeeListView.Items.Clear();
            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.Employee_ID);
                item.SubItems.Add(emp.Employee_Name);
                item.SubItems.Add(DatabaseAccess.Store.GetStoreByID(emp.Store_ID).Store_Name);
                List<DatabaseAccess.Shift> empShifts = DatabaseAccess.Employee.GetShifts(emp.Employee_ID);
                item.SubItems.Add("Idle");
                foreach (var sh in empShifts)
                {
                    if (sh.Is_Active)
                    {
                        item.SubItems[3].Text = "Working";
                        break;
                    }
                }
                EmployeeListView.Items.Add(item);
            }
        }
    }
}
