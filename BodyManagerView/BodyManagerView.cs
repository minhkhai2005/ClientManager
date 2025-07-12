using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyManagerView
{
    public partial class BodyManagerView: UserControl
    {
        public BodyManagerView()
        {
            InitializeComponent();
        }
        public void UpdateEmail(string email)
        {
            textBox1.Text = email;
        }
        public void UpdatePhone(string phone)
        {
            textBox2.Text = phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
