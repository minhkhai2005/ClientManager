using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace Body_product_edit
{
    public partial class Body_product_edit : UserControl
    {
        public event EventHandler CancelButtonClicked;
        public event EventHandler SaveButtonClicked;
        public event EventHandler InvalidPriceInput;
        public event EventHandler ImportButtonClicked;
        public Body_product_edit()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void UpdateProductDetails(
            string productName,
            int stock,
            double price,
            int AlertQuantity,
            bool status)
        {
            ProductNameTextBox.Text = productName;
            StockTextBox.Text = stock.ToString();
            ProductPriceTextBox.Text = price.ToString();
            AlertQuantityTextBox.Text = AlertQuantity.ToString();
            StatusCheckBox.Checked = status;
        }

        private void StatusCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (StatusCheckBox.Checked)
            {
                StatusCheckBox.Text = "Active";
            }
            else
            {
                StatusCheckBox.Text = "Inactive";
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Are you sure you want to save the changes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                return;
            }
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public DatabaseAccess.Inventory GetInventory()
        {
            return new DatabaseAccess.Inventory
            {
                Inventory_Stock = int.Parse(StockTextBox.Text),
                Inventory_AlertQuantity = int.Parse(AlertQuantityTextBox.Text),
                Inventory_Status = StatusCheckBox.Checked
            };
        }
        public string GetProductName()
        {
            return ProductNameTextBox.Text.Trim();
        }
        public double GetProductPrice()
        {
            if (double.TryParse(ProductPriceTextBox.Text, out double price))
            {
                return price;
            }
            else
            {
                InvalidPriceInput?.Invoke(this, EventArgs.Empty);
                return -1;
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            ImportButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
