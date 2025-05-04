using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurationPage
{
    public partial class ConfigurationPage: UserControl
    {
        public ConfigurationPage()
        {
            InitializeComponent();
            updateNotificationSetting();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateNotificationSetting();
        }
        private void updateNotificationSetting()
        {
            if (checkBox1.Checked)
            {
                // Code to enable notifications
                checkBox1.Text = "Enabled";
            }
            else
            {
                // Code to disable notifications
                checkBox1.Text = "Disabled";
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
