using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forGot_passWord_control
{
    public partial class forGot_passWord_control: UserControl
    {
        public forGot_passWord_control()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 192, 255, 255))) // Màu #2980B9 với độ trong suốt 100
            {
                e.Graphics.FillRectangle(brush, pictureBox1.ClientRectangle);
            }
        }
      

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 192, 255, 255))) // Màu DeepSkyBlue trong suốt
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }
    }
}
