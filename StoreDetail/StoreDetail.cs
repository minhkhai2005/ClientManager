using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeView;
using ProductView;
using ProductEdit;
using InvoiceDetailForm;

namespace StoreDetail
{
    public partial class StoreDetail: UserControl
    {
        public StoreDetail()
        {
            InitializeComponent();
            AddSomeEmployee();
            AddSomeInvoices();
        }

        public void ChangeTab(int tabIndex)
        {
            tabControl1.SelectTab(tabIndex);
        }

        // this function is only used for testing purpose
        public void AddSomeEmployee()
        {
            string[] listViewItem1 = { "Tran Minh Khai", "Manager", "Working" };
            string[] listViewItem2 = { "Nguyen Van A", "Staff", "Working" };
            string[] listViewItem3 = { "Nguyen Van B", "Staff", "Working" };
            EmployeeListView.Items.Add(new ListViewItem(listViewItem1));
            EmployeeListView.Items.Add(new ListViewItem(listViewItem2));
            EmployeeListView.Items.Add(new ListViewItem(listViewItem3));
        }
        // this function is only used for testing purpose
        public void AddSomeInvoices()
        {
            string[] invoice1 = { "INV001", "2023-10-01", "100.00", "20" };
            InvoicesListView.Items.Add(new ListViewItem(invoice1));
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            EmployeeView.EmployeeView employeeView = new EmployeeView.EmployeeView();
            employeeView.ShowDialog();
        }

        private void overviewHeader_MsgBtnClicked(object sender, EventArgs e)
        {
            ChangeTab(3);
        }

        private void productCard1_EditBtnClick(object sender, string e)
        {
            ProductEdit.ProductEdit productEdit = new ProductEdit.ProductEdit();
            productEdit.ShowDialog();
        }

        private void productCard1_ViewBtnClick(object sender, string e)
        {
            ProductView.ProductView productView = new ProductView.ProductView();
            productView.ShowDialog();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            // TODO: Implement the logic to handle adding a new employee
        }

        private void InvoiceListView_ItemActivate(object sender, EventArgs e)
        {
            // TODO: Implement the logic to handle item activation in listView2
            InvoiceDetailForm.InvoiceDetail invoice_Detail = new InvoiceDetailForm.InvoiceDetail();
            //invoice_Detail.ShowDialog();
            invoice_Detail.ShowDialog();
        }
    }
}
