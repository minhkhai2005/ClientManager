using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_Up_control
{
    public partial class sign_Up_control: UserControl
    {
        public sign_Up_control()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb( 120,192, 255, 255))) // Màu xanh #2980B9 với độ trong suốt 100
            {
                e.Graphics.FillRectangle(brush, pictureBox1.ClientRectangle);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 192, 255, 255))) // Màu DeepSkyBlue trong suốt
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sign_Up_control_Load(object sender, EventArgs e)
        {

        }
    }

}
