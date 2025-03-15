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
    public partial class sidebar: UserControl
    {
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
                    button.ForeColor = Color.FromArgb(87,85,85); // Optionally reset the ForeColor as well
                }
            }
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(41, 128, 185);
                btn.ForeColor = Color.FromArgb(255, 255, 255);
            }

        }


    }
}
