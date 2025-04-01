using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_staff
{
    public partial class Card_staff: UserControl
    {
        public Card_staff()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Chống răng cưa

            // Vẽ nền trong suốt để tránh hiển thị góc vuông
            g.Clear(this.BackColor);

            using (Brush brush = new SolidBrush(panelStatus.BackColor)) // Lấy màu của Panel
            {
                int diameter = Math.Min(panelStatus.Width, panelStatus.Height); // Giữ hình tròn đúng tỷ lệ
                g.FillEllipse(brush, 0, 0, diameter, diameter); // Vẽ hình tròn
            }
        }
    }
}
