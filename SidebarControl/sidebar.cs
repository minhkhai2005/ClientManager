using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidebarControl
{
    public partial class sidebar : UserControl
    {
        public enum sidebarPage
        {
            Dashboard = 0,
            Stores = 1,
            Employees = 2,
            Customers = 3,
            Notifications = 4,
            Configuration = 5
        }

        public event EventHandler<sidebarPage> sidebarPageChanged; // Fix: Change the event type to use 'sidebarPage'  

        public sidebar()
        {
            InitializeComponent();
            dashboardBtn.Click += Button_Click;
            storesBtn.Click += Button_Click;
            employeesBtn.Click += Button_Click;
            customerBtn.Click += Button_Click;
            notificationsBtn.Click += Button_Click;
            configurationBtn.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Change the BackColor of all buttons to white  
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.FromArgb(87, 85, 85); // Optionally reset the ForeColor as well  
                }
            }
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(41, 128, 185);
                btn.ForeColor = Color.FromArgb(255, 255, 255);
            }

            switch (btn)
            {
                case var _btn when _btn == dashboardBtn:
                    sidebarPageChanged?.Invoke(this, sidebarPage.Dashboard);
                    break;
                case var _btn when _btn == storesBtn:
                    sidebarPageChanged?.Invoke(this, sidebarPage.Stores);
                    break;
                case var _btn when _btn == employeesBtn:
                    sidebarPageChanged?.Invoke(this, sidebarPage.Employees);
                    break;
                case var _btn when _btn == customerBtn:
                    sidebarPageChanged?.Invoke(this, sidebarPage.Customers);
                    break;
                case var _btn when _btn == notificationsBtn:
                    sidebarPageChanged?.Invoke(this, sidebarPage.Notifications);
                    break;
                case var _btn when _btn == configurationBtn:
                    sidebarPageChanged?.Invoke(this, sidebarPage.Configuration);
                    break;
                default:
                    break;
            }
        }
    }
}
