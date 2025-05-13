using System;
using System.Windows.Forms;

namespace CustomerCard
{
    public partial class CustomerCard : UserControl
    {
        public CustomerCard()
        {
            InitializeComponent();
        }

        // Public properties để set data từ bên ngoài
        public string CustomerName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        public string CustomerID
        {
            get { return labelCustomerID.Text; }
            set { labelCustomerID.Text = value; }
        }

        public string Phone
        {
            get { return labelPhone.Text; }
            set { labelPhone.Text = value; }
        }
    }
}
