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
using DatabaseClass;

namespace StoreDetail
{
    public partial class StoreDetail: UserControl
    {
        public StoreDetail()
        {
            InitializeComponent();
        }
        public StoreDetail(string storeID)
        {
            InitializeComponent();
            // Load store details based on the storeID
            LoadStoreDetails(storeID);
        }
        public void LoadStoreDetails(string storeID)
        {
            // Fetch store details from the database using the storeID
            DatabaseAccess.Store store = DatabaseAccess.GetStoreByID(storeID);
            double storeRevenue = DatabaseAccess.GetStoreRevenue(storeID);
            int storeOrders = DatabaseAccess.GetStoreOrders(storeID);
            List<DatabaseAccess.Employee> onDutyEmployees = DatabaseAccess.GetOnDutyEmployee(storeID);
            if (store != null)
            {
                // Update UI elements with store details
                overviewHeader.UpdateStoreName(store.Store_Name);
                overviewHeader.UpdateStoreAddress(store.Store_Address);
                overviewHeader.UpdateStoreStatus(store.Store_Status?"Open":"Close");

                rightBodyOverviewTabStores1.UpdateRevenue(storeRevenue); // Replace with actual revenue data
                rightBodyOverviewTabStores1.UpdateOrders(storeOrders); // Replace with actual order count
                if (onDutyEmployees != null)
                {
                    leftBodyOverviewTabStores1.UpdateEmployeeList(onDutyEmployees); // Update employee list
                }
                    
            }
            else
            {
                MessageBox.Show("Store not found.");
            }
        }
        public void ChangeTab(int tabIndex)
        {
            tabControl1.SelectTab(tabIndex);
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
