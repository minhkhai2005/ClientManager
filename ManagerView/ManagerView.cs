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
namespace ManagerView
{
    public partial class ManagerView: Form
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        private void LoadManagerDetails(string UID)
        {
            var manager = DatabaseAccess.GetManagerByUID(UID);
            if (manager != null)
            {
                // Populate the UI with manager details
                headerManagerView1.UpdateHeader(manager.Manager_Name);
                bodyManagerView1.UpdateEmail(manager.Manager_Email);
                bodyManagerView1.UpdatePhone(manager.Manager_Phone);
                // Add more fields as necessary
            }
            else
            {
                MessageBox.Show("Manager not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                headerManagerView1.UpdateHeader(null);
                bodyManagerView1.UpdateEmail(null);
                bodyManagerView1.UpdatePhone(null);
            }
        }

        public ManagerView(string UID)
        {
            InitializeComponent();
            // Assuming you have a method to load manager details by UID
            LoadManagerDetails(UID);
        }
    }
}
