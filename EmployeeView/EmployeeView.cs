using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace EmployeeView
{
    public partial class EmployeeView: Form
    {
        private DatabaseAccess.Employee emp { get; set; } = new DatabaseAccess.Employee();
        public EmployeeView()
        {
            InitializeComponent();
        }
        public EmployeeView(string empID)
        {
            InitializeComponent(empID);
            emp = DatabaseAccess.Employee.GetEmployeeByID(empID);
            headerEmployeeView1.UpdateEmployeeName(emp.Employee_Name);
            var store = DatabaseAccess.Store.GetStoreByID(emp.Store_ID);
            headerEmployeeView1.UpdateEmployeeWorkAddress(store.Store_ID);
        }

        private void bodyEmployeeView1_CancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bodyEmployeeView1_SaveBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bodyEmployeeView1_DelBtnClick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
