using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;
using ProductImport;

namespace ProductEdit
{
    public partial class ProductEdit: Form
    {
        DatabaseAccess.Inventory inventory { get; set; }
        DatabaseAccess.Product product { get; set; }
        bool isValidPrice = true;
        public ProductEdit()
        {
            InitializeComponent();
            body_product_edit1.CancelButtonClicked += (s, e) => this.Close();
            body_product_edit1.SaveButtonClicked += (s, e) => SaveInventory();
            body_product_edit1.InvalidPriceInput += (s, e) => isValidPrice = false;
        }
        public ProductEdit(DatabaseAccess.Inventory i, DatabaseAccess.Product p)
        {
            InitializeComponent();
            inventory = i;
            product = p;
            body_product_edit1.UpdateProductDetails(
                product.Product_Name,
                inventory.Inventory_Stock,
                product.Product_Price,
                inventory.Inventory_AlertQuantity,
                inventory.Inventory_Status
            );
            header_Product_edit1.UpdateProductDetails(
                product.Product_Name,
                inventory.Product_ID,
                inventory.Inventory_Status,
                inventory.Inventory_Stock,
                product.Product_Price
            );
            body_product_edit1.CancelButtonClicked += (s, e) => this.Close();
            body_product_edit1.SaveButtonClicked += (s, e) => SaveInventory();
            body_product_edit1.InvalidPriceInput += (s, e) => isValidPrice = false;
            body_product_edit1.ImportButtonClicked += (s, e) =>
            {
                ProductImport.ProductImport importForm = new ProductImport.ProductImport(product, inventory);
                importForm.ShowDialog();
            };
        }
        private void SaveInventory()
        {
            var temp = body_product_edit1.GetInventory();
            inventory.Inventory_Stock = temp.Inventory_Stock;
            inventory.Inventory_AlertQuantity = temp.Inventory_AlertQuantity;
            inventory.Inventory_Status = temp.Inventory_Status;

            string productName = body_product_edit1.GetProductName();
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Product name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                product.Product_Name = productName;
            }
            double productPrice = body_product_edit1.GetProductPrice();
            if (!isValidPrice)
            {
                MessageBox.Show("Invalid price input. Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                product.Product_Price = productPrice;
            }

            Task.Run(() => { inventory.UpdateInventory(); product.UpdateProduct(); });
            MessageBox.Show("Product details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
