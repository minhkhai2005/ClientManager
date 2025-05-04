using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace card_displaying
{
    public partial class card_displaying_store_in4 : UserControl
    {
        public event EventHandler<string> ViewBtnClicked;
        public event EventHandler<string> MessageBtnClicked;
        public card_displaying_store_in4()
        {
            InitializeComponent();
            SetRoundedCorners(panel2, panel2.Width / 2); // Đặt bán kính bằng một nửa chiều rộng để tạo hình tròn
        }

        private void SetRoundedCorners(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, panel.Width, panel.Height);
            panel.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting code if needed
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2); // Màu xám, độ dày 2px
            g.DrawLine(pen, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 1); // Màu xám, độ dày 2px
            g.DrawLine(pen, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
        }

        private void ViewBtn_Click(object sender, System.EventArgs e)
        {
            ViewBtnClicked?.Invoke(this, StoreID.Text);
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            MessageBtnClicked?.Invoke(this, StoreID.Text);
        }
    }
}

