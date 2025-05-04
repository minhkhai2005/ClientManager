using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePage
{
    public partial class EmployeePage: UserControl
    {
        private string[] testEmployee = new string[]
        {
            "23520679",
            "Tran Minh Khai",
            "Waiter",
            "Addidas",
            "Working"
        };
        public EmployeePage()
        {
            InitializeComponent();
            listView1.Items.Add(new ListViewItem(testEmployee));
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string employeeId = selectedItem.SubItems[0].Text;
            EmployeeView.EmployeeView employeeView = new EmployeeView.EmployeeView();
            employeeView.ShowDialog();
        }
    }
}
