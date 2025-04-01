using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Header_Product_edit
{
    public partial class Header_Product_edit: UserControl
    {
        public Header_Product_edit()
        {
            InitializeComponent();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private bool isActive = true;

        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                panelStatus.BackColor = Color.Red;
                lblStatus.Text = "Closed";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                panelStatus.BackColor = Color.Green;
                lblStatus.Text = "Active";
                lblStatus.ForeColor = Color.Green;
            }

            isActive = !isActive; // Đảo trạng thái
        }

        private void panelStatus_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(panelStatus.BackColor);
            g.FillEllipse(brush, 0, 0, panelStatus.Width, panelStatus.Height);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            panelStatus.Paint += new PaintEventHandler(panelStatus_Paint);
        }

    }
}

