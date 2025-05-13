﻿using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Customer__View
{
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        public string CustomerName => txtName.Text.Trim();
        public string Phone => txtPhone.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public string DateOfBirth => txtDOB.Text.Trim();

        public event EventHandler OnCancelClicked;
        public event EventHandler OnDoneClicked;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerName) ||
                string.IsNullOrWhiteSpace(Phone) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(DateOfBirth))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OnDoneClicked?.Invoke(this, EventArgs.Empty);
        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
