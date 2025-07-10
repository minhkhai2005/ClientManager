using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace StoreDetail
{
    public partial class addNewInventory: Form
    {
        public string storeID = string.Empty; // Store ID to be set externally
        public event EventHandler InventoryAdded; // Event to notify when a new inventory is added
        private static string GenerateRandomProductCode()
        {
            var rand = new Random();
            string code;

            do
            {
                int number = rand.Next(0, 100000000); // 0 → 9999
                code = $"P{number}";          // VD: P0321
            }
            while (DatabaseAccess.Product.GetProductByID(code) != null); // Lặp đến khi không trùng

            return code;
        }
        private bool ValidateInput()
        {
            // Check if there any required fields are empty
            if (string.IsNullOrWhiteSpace(ProdNameTextBox.Text))
            {
                MessageBox.Show("Product name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(ProdPriceTextBox.Text) || !decimal.TryParse(ProdPriceTextBox.Text, out _))
            {
                MessageBox.Show("Product price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(InventoryQuantityTextBox.Text) || !int.TryParse(InventoryQuantityTextBox.Text, out _))
            {
                MessageBox.Show("Product quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if (string.IsNullOrWhiteSpace(ProdProviderTextBox.Text))
            {
                MessageBox.Show("Product provider cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(InventoryAlertQuantityTextBox.Text) || !int.TryParse(InventoryAlertQuantityTextBox.Text, out _))
            {
                MessageBox.Show("Alert quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                return true;
        }
        public addNewInventory()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInput())
            {
                return; // If validation fails, exit the method
            }
            // generate new product code
            string newProductCode = GenerateRandomProductCode();

            // get product information
            DatabaseAccess.Product p = new DatabaseAccess.Product();
            p.Product_ID = newProductCode;
            p.Product_Name = ProdNameTextBox.Text;
            p.Product_Price = double.Parse(ProdPriceTextBox.Text);
            p.Product_Provider = ProdProviderTextBox.Text;
            DatabaseAccess.Product.CreateNewProduct(p);

            // get inventory information
            DatabaseAccess.Inventory i = new DatabaseAccess.Inventory();
            i.Product_ID = newProductCode;
            i.Store_ID = storeID;
            i.Inventory_Stock = int.Parse(InventoryQuantityTextBox.Text);
            i.Inventory_AlertQuantity = int.Parse(InventoryAlertQuantityTextBox.Text);
            i.Inventory_Status = StatusRadioBtn.Checked;
            DatabaseAccess.Inventory.CreateNewInventory(i);

            // Show success message and close the form
            MessageBox.Show("New product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InventoryAdded?.Invoke(this, EventArgs.Empty); // Raise the event to notify subscribers
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusRadioBtn.Checked)
            {
                StatusRadioBtn.Text = "Active";
            }
            else
            {
                StatusRadioBtn.Text = "Inactive";
            }
        }
    }
}
