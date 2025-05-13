using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class NotificationCard : UserControl
    {
        public NotificationCard()
        {
            InitializeComponent();
        }

        // Public properties để set dữ liệu từ bên ngoài
        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }

        public string Time
        {
            get { return labelTime.Text; }
            set { labelTime.Text = value; }
        }

        public string StoreName
        {
            get { return labelStoreName.Text; }
            set { labelStoreName.Text = value; }
        }

        // Event handler cho nút View (nếu cần)
        public event EventHandler ViewButtonClick;

        private void buttonView_Click(object sender, EventArgs e)
        {
            ViewButtonClick?.Invoke(this, e); // Kích hoạt sự kiện khi nút View được nhấn
        }
    }
}
