using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mesenger__Tab
{
    public partial class MesengerTab : UserControl
    {
        public MesengerTab()
        {
            InitializeComponent();
            txtMessage.KeyDown += TxtMessage_KeyDown; // Lắng nghe sự kiện phím
        }

        // Xử lý khi nhấn phím trong txtMessage
        private void TxtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift) 
            {
                e.SuppressKeyPress = true; // Ngăn chặn xuống dòng mặc định
                SendMessage();
            }
        }

        // Xử lý khi nhấn nút gửi tin
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        // Hàm gửi tin nhắn
        private void SendMessage()
        {
            string message = txtMessage.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                rtbMessages.AppendText("You: " + message + Environment.NewLine);
                txtMessage.Clear(); // Xóa nội dung sau khi gửi
                rtbMessages.SelectionStart = rtbMessages.Text.Length;
                rtbMessages.ScrollToCaret();
            }
        }

        private void lblPhotoText_Click(object sender, EventArgs e)
        {

        }

        private void storePhoto_Click(object sender, EventArgs e)
        {

        }
    }
}

