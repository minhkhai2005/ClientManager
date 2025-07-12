﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard; // Assuming you have a Dashboard UserControl
using ManagerView; // Assuming you have a ManagerView Form
using StoresList; // Assuming you have a StoresList UserControl
using StoreDetail; // Assuming you have a StoreDetail UserControl
using EmployeePage; // Assuming you have an EmployeePage UserControl
using CustomersPage; // Assuming you have a CustomersPage UserControl
using NotificationsPage; // Assuming you have a NotificationsPage UserControl
using ConfigurationPage;
using DatabaseClass;
using Sign_In;
using static Sign_In.Sign_in;
namespace ClientManager
{
    public partial class ClientManager : Form
    {
        private Dashboard.Dashboard dashboardPage = new Dashboard.Dashboard();
        private StoresList.StoreList storesPage = new StoreList();
        private EmployeePage.EmployeePage employeePage = new EmployeePage.EmployeePage();
        private CustomersPage.CustomersPage customersPage = new CustomersPage.CustomersPage();
        private NotificationsPage.NotificationPage notificationPage = new NotificationsPage.NotificationPage();
        private ConfigurationPage.ConfigurationPage configurationPage = new ConfigurationPage.ConfigurationPage();
        public ClientManager()
        {
            InitializeComponent();
            storesPage.StoreSelected += LoadDetailStore;
        }

        private void LoadPage(UserControl page)
        {
            splitContainer1.Panel2.Controls.Clear(); // Clear old control  
            page.Dock = DockStyle.Fill; // Fill entire panel  
            splitContainer1.Panel2.Controls.Add(page); // Add new control  
        }
        private void LoadDetailStore(object sender, string storeID)
        {
            // Handle the event when a store is selected in the StoresList UserControl
            StoreDetail.StoreDetail storeDetail = new StoreDetail.StoreDetail(storeID, Sign_In.Sign_in.Session.Email);
            storeDetail.OverviewTabRefresh();
            LoadPage(storeDetail); // Load the StoreDetail UserControl
        }
        private async void sidebar_sidebarPageChanged(object sender, SidebarControl.sidebar.sidebarPage e)
        {
            switch (e)
            {
                case SidebarControl.sidebar.sidebarPage.Dashboard:
                    string email = Session.Email;
                    (double revenue, int orders) = DatabaseAccess.GetDashboardData(email);
                    dashboardPage.UpdateData(revenue, orders);
                    LoadPage(dashboardPage);
                    break;
                case SidebarControl.sidebar.sidebarPage.Stores:
                    LoadPage(storesPage);
                    await Task.Run(() => storesPage.FetchStoresList());
                    storesPage.Invoke((Action)(() => storesPage.UpdateStoreList()));
                    break;
                case SidebarControl.sidebar.sidebarPage.Employees:
                    LoadPage(employeePage);
                    await Task.Run(() => employeePage.FetchEmployeesList());
                    employeePage.Invoke((Action)(() => employeePage.UpdateEmployeeList()));
                    break;
                case SidebarControl.sidebar.sidebarPage.Customers:
                    LoadPage(customersPage);
                    break;
                case SidebarControl.sidebar.sidebarPage.Notifications:
                    LoadPage(notificationPage);
                    break;
                case SidebarControl.sidebar.sidebarPage.Configuration:
                    LoadPage(configurationPage);
                    break;
            }
        }

        private void header1_showManagerDetails(object sender, EventArgs e)
        {
            ManagerView.ManagerView managerView = new ManagerView.ManagerView(Session.UID);
            managerView.ShowDialog();
        }

        private void sidebar_Load(object sender, EventArgs e)
        {

        }

        private void header1_Load(object sender, EventArgs e)
        {
            // Set the manager's name in the header
            string email = Session.Email;
            var manager = DatabaseAccess.GetManagerByEmail(email);
            header1.UpdateHeader(manager.Manager_Name);

        }
    }
}
