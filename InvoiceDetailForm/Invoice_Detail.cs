using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceDetailForm
{
    public partial class Invoice_Detail : UserControl
    {
        public Invoice_Detail()
        {
            InitializeComponent();
            SetupInvoiceTable();
            LoadInvoiceData();
        }



        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
        }

        private void SetupInvoiceTable()
        {
            dgvInvoice.ColumnCount = 3;

            dgvInvoice.Columns[0].Name = "Item";
            dgvInvoice.Columns[1].Name = "Quantity";
            dgvInvoice.Columns[2].Name = "Cost";

            dgvInvoice.Columns[0].Width = 200;
            dgvInvoice.Columns[1].Width = 100;
            dgvInvoice.Columns[2].Width = 100;

            dgvInvoice.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvInvoice.ReadOnly = true;
            dgvInvoice.AllowUserToAddRows = false;

        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInvoice.ColumnCount = 3;
            dgvInvoice.Columns[0].Name = "Item";
            dgvInvoice.Columns[1].Name = "Quantity";
            dgvInvoice.Columns[2].Name = "Cost";

        }
    
            private void LoadInvoiceData()
            {
            dgvInvoice.Rows.Add("White shoe", 1, "$200");
            dgvInvoice.Rows.Add("Red T-Shirt", 3, "$150");
            dgvInvoice.Rows.Add("Blue pant", 2, "$300");

            lblTotalQuantity.Text = "Total 6";
            lblTotalCost.Text = "$1250";

            lblTime.Text = "Time 15:00:00 - 11/03/2025";
            lblSeller.Text = "Addidas Nguyễn Ánh Thư";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing invoice...");
        }

    }
}

