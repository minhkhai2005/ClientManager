using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Header_Product_edit
{
    public partial class Header_Product_edit : UserControl
    {
        public Header_Product_edit()
        {
            InitializeComponent();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private bool isActive = true;

        public void UpdateProductDetails(
            string prodName,
            string prodID,
            bool status,
            int stock,
            double price)
        {
            ProductNameLabel.Text = prodName;
            ProductIDLabel.Text = prodID;
            if (status)
            {
                lblStatus.Text = "Active";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Inactive";
                lblStatus.ForeColor = Color.Red;
            }
            StockLabel.Text = stock.ToString();
            PriceLabel.Text = price.ToString("C2");
        }
    }
}

