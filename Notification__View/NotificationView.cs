using System;
using System.Windows.Forms;

namespace Notification__View
{
    public partial class NotificationView : UserControl
    {
        public NotificationView()
        {
            InitializeComponent();
            lblStoreName.Text = "UIT Stores Management Software";
        }

        public string MessageContent => txtMessage.Text.Trim();

        public event EventHandler OnCancelClicked;
        public event EventHandler OnDoneClicked;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageContent))
            {
                MessageBox.Show("Please enter a message.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OnDoneClicked?.Invoke(this, EventArgs.Empty);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStoreName_Click(object sender, EventArgs e)
        {

        }
    }
}
