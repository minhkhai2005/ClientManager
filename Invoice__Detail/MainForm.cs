using System;
using System.Windows.Forms;

namespace Invoice__Detail
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadUserControl();
        }

        private void LoadUserControl()
        {
            InvoiceDetailForm invoiceControl = new InvoiceDetailForm();
            invoiceControl.Dock = DockStyle.Fill;

            this.Controls.Add(invoiceControl); // Thêm UserControl vào MainForm
        }
    }
}
