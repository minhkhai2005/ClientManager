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
using static DatabaseClass.DatabaseAccess;
using Sign_In;
namespace CustomersPage
{
    public partial class CustomersPage: UserControl
    {
        List<Customer> customers;
        public CustomersPage()
        {
            InitializeComponent();
            FetchCustomerList();
            Updatepage();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FetchCustomerList()
        {
             customers = DatabaseClass.DatabaseAccess.GetCustomersbyManagerID(Sign_in.Session.UID);
        }
        private void Updatepage()
        {
            listView1.Items.Clear();
            foreach (Customer customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.Customer_ID);
                item.SubItems.Add(customer.Customer_Name);
                item.SubItems.Add(customer.Customer_Phone);
                listView1.Items.Add(item);
            }

        }
    }
}
