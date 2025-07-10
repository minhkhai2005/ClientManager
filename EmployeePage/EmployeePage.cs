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
        private ListViewColumnSorter lvwColumnSorter;
        List<Employee> employees = new List<Employee>();
        Dictionary<string, Store> stores = new Dictionary<string, Store>();
        Dictionary<string, bool> employeeWorkingStatus = new Dictionary<string, bool>();
        public EmployeePage()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.EmployeeListView.ListViewItemSorter = lvwColumnSorter;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployee addEmployee = new addEmployee();
            addEmployee.ShowDialog();
        }

        private void EmployeeListView_ItemActivate(object sender, EventArgs e)
        {
            if (EmployeeListView.SelectedItems.Count > 0)
            {
                string employeeID = EmployeeListView.SelectedItems[0].SubItems[0].Text;
                EmployeeView.EmployeeView view = new EmployeeView.EmployeeView(employeeID);
                view.ShowDialog();
            }
        }
        public void FetchEmployeesList()
        {
            employees = DatabaseAccess.GetEmployeesByManagerID(Sign_in.Session.UID);
            foreach (var emp in employees)
            {
                if (!stores.ContainsKey(emp.Store_ID))
                {
                    Store store = DatabaseAccess.GetStoreByID(emp.Store_ID);
                    if (store != null)
                    {
                        stores[emp.Store_ID] = store;
                    }
                }

                // build working status dictionary
                List<DatabaseAccess.Shift> empShifts = DatabaseAccess.Employee.GetShifts(emp.Employee_ID);
                employeeWorkingStatus[emp.Employee_ID] = false; // default to not working
                foreach (var sh in empShifts)
                {
                    if (sh.Is_Active)
                    {
                        employeeWorkingStatus[emp.Employee_ID] = true; // employee is working
                        break;
                    }
                }
            }
        }
        public void UpdateEmployeeList() 
        {
            EmployeeListView.Items.Clear();
            EmployeeListView.ListViewItemSorter = null; // turn off sorting temporarily
            EmployeeListView.BeginUpdate();
            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.Employee_ID);
                item.SubItems.Add(emp.Employee_Name);
                item.SubItems.Add(stores[emp.Store_ID].Store_Name);
                item.SubItems.Add(employeeWorkingStatus[emp.Employee_ID]?"Working":"Idle");
                EmployeeListView.Items.Add(item);
            }
            EmployeeListView.EndUpdate();
            EmployeeListView.ListViewItemSorter = lvwColumnSorter; // re-enable sorting
            EmployeeListView.Sort(); // sort the list view
        }

        private void EmployeeListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.EmployeeListView.Sort();
        }
    }
}
