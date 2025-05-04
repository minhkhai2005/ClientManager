using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationsPage
{
    public partial class NotificationPage: UserControl
    {
        public event EventHandler<string> NotificationSelected;
        public NotificationPage()
        {
            InitializeComponent();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedNoti = listView1.SelectedItems[0];
            if (selectedNoti == null)
            {
                string notificationID = selectedNoti.SubItems[0].Text;
                NotificationSelected?.Invoke(this, notificationID);
                return;
            }           
        }
    }
}
