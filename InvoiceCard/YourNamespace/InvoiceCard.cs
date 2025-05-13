using System;
using System.Windows.Forms;

namespace InvoiceCard
{
    public partial class InvoiceCard : UserControl
    {
        public InvoiceCard()
        {
            InitializeComponent();
        }

        // Public properties để set data từ bên ngoài
        public string InvoiceNumber
        {
            get { return labelInvoiceNumber.Text; }
            set { labelInvoiceNumber.Text = value; }
        }

        public string Time
        {
            get { return labelTime.Text; }
            set { labelTime.Text = value; }
        }

        public string Total
        {
            get { return labelTotal.Text; }
            set { labelTotal.Text = value; }
        }

        public string NoItems
        {
            get { return labelNoItems.Text; }
            set { labelNoItems.Text = value; }
        }
    }
}
