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

namespace Body_product_import
{
    public partial class Body_product_import: UserControl
    {

        public event EventHandler CancelButtonClicked;
        public event EventHandler ImportButtonClicked;
        public event EventHandler InvalidInput;
        public DatabaseAccess.Inventory inventory { get; set; }
        public DatabaseAccess.Product product { get; set; }
        public Body_product_import()
        {
            InitializeComponent();
        }
        public void UpdateProviderName(string provider)
        {
            ProviderTextBox.Text = provider;
        }
        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Text = string.Empty;
            }
            else
            {   
                // ignore price is blank
                if (string.IsNullOrWhiteSpace(PriceTextBox.Text))
                {
                    return;
                }
                if (!double.TryParse(PriceTextBox.Text, out double price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PriceTextBox.Text = string.Empty;
                }
                else
                {
                    TotalTextBox.Text = (quantity * price).ToString();
                }
            }
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(PriceTextBox.Text, out double price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTextBox.Text = string.Empty;
            }
            else
            {
                // ignore quantity is blank
                if (string.IsNullOrWhiteSpace(QuantityTextBox.Text))
                {
                    return;
                }
                if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Text = string.Empty;
                }
                else
                {
                    TotalTextBox.Text = (quantity * price).ToString();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Are you sure you want to import this product?", "Confirm Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) { 
                ImportButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }
        public int GetQuantity()
        {
            if (int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                return quantity;
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InvalidInput?.Invoke(this, EventArgs.Empty);
                return 0;
            }
        }
        public double GetPrice()
        {
            if (double.TryParse(PriceTextBox.Text, out double price))
            {
                return price;
            }
            else
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InvalidInput?.Invoke(this, EventArgs.Empty);
                return 0;
            }
        }
        public double GetTotal()
        {
            if (double.TryParse(TotalTextBox.Text, out double total))
            {
                return total;
            }
            else
            {
                MessageBox.Show("Please enter a valid total.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InvalidInput?.Invoke(this, EventArgs.Empty);
                return 0;
            }
        }
        public DateTime GetDate()
        {
            return dateTimePicker1.Value;
        }
    }
}
