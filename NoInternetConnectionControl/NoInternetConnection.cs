using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoInternetConnectionControl
{
    public partial class NoInternetConnection: UserControl
    {
        private string[] languagesComboBox;
        public NoInternetConnection()
        {
            InitializeComponent();
            Color backColor = Color.FromArgb(236,240,241);
            this.BackColor = backColor;
            languagesComboBox = new string[] {"English", "Vietnamese" };
            comboBox1.Items.AddRange(languagesComboBox);
            comboBox1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retryButton_Click(object sender, EventArgs e)
        {

        }

        private void retryButton_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void retryButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
