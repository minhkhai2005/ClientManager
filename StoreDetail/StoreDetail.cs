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
using System.Data.SqlClient;
using System.Threading;
using System.Net.Http.Headers;
using System.Diagnostics;
namespace StoreDetail
{
    public partial class StoreDetail: UserControl
    {
        private ListViewColumnSorter lvwColumnSorter;
        DatabaseAccess.Store StoreInformation { get; set; }
        private double Revenue { get; set; }
        private int NumberOfOrders { get; set; }
        private List<DatabaseAccess.Employee> StoreEmployees { get; set; }
        private List<DatabaseAccess.Product> StoreProducts { get; set; }
        private List<DatabaseAccess.Invoice> StoreInvoices { get; set; }
        private List<DatabaseAccess.Inventory> StoreInventoies { get; set; }
        private List<DatabaseAccess.Employee> OnDutyEmployee { get; set; }
        public StoreDetail()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.InventoryListView.ListViewItemSorter = lvwColumnSorter;
            this.EmployeeListView.ListViewItemSorter = lvwColumnSorter;
            this.InvoiceListView.ListViewItemSorter = lvwColumnSorter;
        }
        public StoreDetail(string storeID)
        {
            InitializeComponent();
            // Load store details based on the storeID
            LoadStoreDetails(storeID);
            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.InventoryListView.ListViewItemSorter = lvwColumnSorter;
            this.EmployeeListView.ListViewItemSorter = lvwColumnSorter;
            this.InvoiceListView.ListViewItemSorter = lvwColumnSorter;
        }
        public void LoadStoreDetails(string storeID)
        {
            try
            {
                StoreInformation  = DatabaseAccess.GetStoreByID(storeID);
                if (StoreInformation == null)
                {
                    MessageBox.Show("Store not found.");
                    return;
                }
                else
                {
                    Revenue = DatabaseAccess.GetStoreRevenue(StoreInformation.Store_ID);
                    NumberOfOrders = DatabaseAccess.GetStoreNumberOfOrders(StoreInformation.Store_ID);
                    StoreEmployees = DatabaseAccess.GetEmployeesByStoreID(StoreInformation.Store_ID);
                    StoreProducts = DatabaseAccess.GetProductsByStoreID(StoreInformation.Store_ID);
                    StoreInventoies = DatabaseAccess.GetInventoriesByStoreID(StoreInformation.Store_ID);
                    OnDutyEmployee = DatabaseAccess.GetOnDutyEmployee(StoreInformation.Store_ID);
                    StoreInvoices = DatabaseAccess.GetInvoicesByStoreID(StoreInformation.Store_ID);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading store details: " + ex.Message);
                return;
            }
        }
        public void ChangeTab(int tabIndex)
        {
            tabControl1.SelectTab(tabIndex);
        }

        private void overviewHeader_MsgBtnClicked(object sender, EventArgs e)
        {
            ChangeTab(3);
        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            // TODO: Implement the logic to handle adding a new employee
        }

        private void InvoiceListView_ItemActivate(object sender, EventArgs e)
        {
            // TODO: Implement the logic to handle item activation in listView2
            string invoiceID = InvoiceListView.SelectedItems[0].SubItems[0].Text;
            string storeID = StoreInformation.Store_ID;
            InvoiceDetailForm.InvoiceDetail id = new InvoiceDetailForm.InvoiceDetail(invoiceID, storeID);
            id.UpdateInfo();
            id.ShowDialog();
        }

        // refresh methods for each tab
        public void OverviewTabRefresh()
        {
            // Refresh the overview tab with the latest data

            // refresh header
            overviewHeader.UpdateStoreAddress(StoreInformation.Store_Address);
            overviewHeader.UpdateStoreName(StoreInformation.Store_Name);
            overviewHeader.UpdateStoreStatus(StoreInformation.Store_Status);

            // refresh left body
            leftBodyOverviewTabStores1.UpdateEmployeeList(OnDutyEmployee);

            // refresh right body
            rightBodyOverviewTabStores1.UpdateRevenue(Revenue);
            rightBodyOverviewTabStores1.UpdateOrders(NumberOfOrders);
        }
        public void InventoryTabRefresh()
        {
            // update store information for header
            header_Inventory_Stores1.UpdateStoreName(StoreInformation.Store_Name);
            header_Inventory_Stores1.UpdateStoreAddress(StoreInformation.Store_Address);

            // add item to inventory listView
            InventoryListView.Items.Clear();
            InventoryListView.ListViewItemSorter = null; // turn off sorting temporarily
            InventoryListView.BeginUpdate();
            foreach (var inventory in StoreInventoies)
            {
                var p = DatabaseAccess.Product.GetProductByID(inventory.Product_ID);
                ListViewItem item = new ListViewItem(p.Product_Name);
                item.SubItems.Add(p.Product_ID);
                item.SubItems.Add(p.Product_Price.ToString());
                item.SubItems.Add(inventory.Inventory_Stock.ToString());
                item.SubItems.Add(StoreInformation.GetNumberOfSoldItem(inventory.Product_ID).ToString());
                item.SubItems.Add(inventory.Inventory_Status?"Active":"Inactive");
                InventoryListView.Items.Add(item);
            }
            InventoryListView.EndUpdate();
            InventoryListView.ListViewItemSorter = lvwColumnSorter; // re-enable sorting
            InventoryListView.Sort();
        }
        public void EmployeeTabRefresh()
        {
            // update store information for header
            header_Inventory_Stores2.UpdateStoreName(StoreInformation.Store_Name);
            header_Inventory_Stores2.UpdateStoreAddress(StoreInformation.Store_Address);

            // update employee listView
            EmployeeListView.Items.Clear();
            EmployeeListView.ListViewItemSorter = null; // turn off sorting temporarily
            EmployeeListView.BeginUpdate();
            foreach (var employee in StoreEmployees)
            {
                ListViewItem item = new ListViewItem(employee.Employee_Name);
                item.SubItems.Add(employee.Employee_ID);
                item.SubItems.Add(OnDutyEmployee==null?"Idle":(OnDutyEmployee.Contains(employee)?"Working":"Idle"));
                EmployeeListView.Items.Add(item);
            }
            EmployeeListView.EndUpdate();
            EmployeeListView.ListViewItemSorter = lvwColumnSorter; // re-enable sorting
            EmployeeListView.Sort();
        }
        public void MessageTabRefresh()
        {
            header_Inventory_Stores3.UpdateStoreName(StoreInformation.Store_Name);
            header_Inventory_Stores3.UpdateStoreAddress(StoreInformation.Store_Address);

            // TODO: fetching messages from database and update the message rich text box
        }
        public void InvoiceTabRefresh()
        {
            header_Inventory_Stores4.UpdateStoreName(StoreInformation.Store_Name);
            header_Inventory_Stores4.UpdateStoreAddress(StoreInformation.Store_Address);

            // update invoice listView
            InvoiceListView.Items.Clear();
            InvoiceListView.ListViewItemSorter = null; // turn off sorting temporarily
            InvoiceListView.BeginUpdate();
            foreach (var invoice in StoreInvoices)
            {
                ListViewItem item = new ListViewItem(invoice.Invoice_ID);
                item.SubItems.Add(invoice.Invoice_Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(invoice.Invoice_TotalAmount.ToString("C"));
                item.SubItems.Add(invoice.Invoice_TotalQuantity.ToString());
                item.SubItems.Add(invoice.Invoice_Status);
                InvoiceListView.Items.Add(item);
            }
            InvoiceListView.EndUpdate();
            InvoiceListView.ListViewItemSorter = lvwColumnSorter; // re-enable sorting
            InvoiceListView.Sort();
        }
        private void InventoryTab_Enter(object sender, EventArgs e)
        {
            InventoryTabRefresh();
        }
        private void OverviewTab_Enter(object sender, EventArgs e)
        {
            OverviewTabRefresh();
        }

        private void EmployeeTab_Enter(object sender, EventArgs e)
        {
            EmployeeTabRefresh();
        }

        private void MessageTab_Enter(object sender, EventArgs e)
        {
            MessageTabRefresh();
        }

        private void InvoiceTab_Enter(object sender, EventArgs e)
        {
            InvoiceTabRefresh();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            OverviewTabRefresh();
        }

        private void InventoryListView_ItemActivate(object sender, EventArgs e)
        {
            if (InventoryListView.SelectedItems.Count > 0)
            {
                string productID = InventoryListView.SelectedItems[0].SubItems[1].Text;
                // Open the product view dialog
                ProductView.ProductView view = new ProductView.ProductView(StoreInformation.Store_ID, productID);
                view.ShowDialog();
            }
        }

        private void EmployeeListView_ItemActivate(object sender, EventArgs e)
        {
            if (EmployeeListView.SelectedItems.Count > 0)
            {
                string employeeID = EmployeeListView.SelectedItems[0].SubItems[1].Text;
                EmployeeView.EmployeeView view = new EmployeeView.EmployeeView(employeeID);
                view.ShowDialog();
            }
        }

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            addNewInventory addNewInventory = new addNewInventory();
            addNewInventory.storeID = StoreInformation.Store_ID; // Set the store ID for the new inventory
            addNewInventory.InventoryAdded += async (s, args) =>
            {
                // Refresh the inventory tab when a new inventory is added
                await Task.Run(() => StoreInventoies = DatabaseAccess.GetInventoriesByStoreID(StoreInformation.Store_ID)); // Ensure the store employees are updated
                InventoryTabRefresh();
            };
            addNewInventory.ShowDialog();
        }
        private void InventoryListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.InventoryListView.Sort();
        }

        private void EmployeeListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.EmployeeListView.Sort();
        }

        private void InvoiceListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.InvoiceListView.Sort();
        }
    }
}
