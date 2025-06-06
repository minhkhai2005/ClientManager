using System;
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
            storesPage.ViewBtnClicked += StoresPage_ViewBtnClicked;
            storesPage.MessageBtnClicked += StoresPage_MessageBtnClicked;
        }

        private void LoadPage(UserControl page)
        {
            splitContainer1.Panel2.Controls.Clear(); // Clear old control  
            page.Dock = DockStyle.Fill; // Fill entire panel  
            splitContainer1.Panel2.Controls.Add(page); // Add new control  
        }

        private void StoresPage_ViewBtnClicked(object sender, string storeID)
        {
            // Handle the event when the View button is clicked in the StoresList UserControl
            StoreDetail.StoreDetail storeDetail = new StoreDetail.StoreDetail();
            LoadPage(storeDetail); // Load the StoreDetail UserControl
        }

        private void StoresPage_MessageBtnClicked(object sender, string storeID)
        {
            // Handle the event when the Message button is clicked in the StoresList UserControl
            // You can implement your logic here
            StoreDetail.StoreDetail storeDetail = new StoreDetail.StoreDetail();
            storeDetail.ChangeTab(3); // Change to the Messages tab
            LoadPage(storeDetail); // Load the StoreDetail UserControl

        }

        private void sidebar_sidebarPageChanged(object sender, SidebarControl.sidebar.sidebarPage e)
        {
            switch (e)
            {
                case SidebarControl.sidebar.sidebarPage.Dashboard:
                    // Ensure Dashboard is a UserControl  
                    string email = Session.Email;
                    (double revenue, int orders) = DatabaseAccess.GetDashboardData(email);
                    dashboardPage.UpdateData(revenue, orders); // This line is commented out in the original code
                    LoadPage(dashboardPage);
                    break;
                case SidebarControl.sidebar.sidebarPage.Stores:
                    LoadPage(storesPage);  
                    break;
                case SidebarControl.sidebar.sidebarPage.Employees:
                    LoadPage(employeePage);
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
            ManagerView.ManagerView managerView = new ManagerView.ManagerView();
            managerView.ShowDialog();
        }

        private void sidebar_Load(object sender, EventArgs e)
        {

        }

        private void header1_Load(object sender, EventArgs e)
        {
            // Set the manager's name in the header
            string email = Session.Email;
            string managerName = DatabaseAccess.GetManagerNameByEmail(email);
            header1.UpdateHeader(managerName);

        }
    }
}
