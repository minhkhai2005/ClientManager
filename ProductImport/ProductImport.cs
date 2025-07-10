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

namespace ProductImport
{
    public partial class ProductImport: Form
    {
        DatabaseAccess.Product product { get; set; }
        DatabaseAccess.Inventory inventory { get; set; }
        bool isInvalidInput = false;
        public ProductImport()
        {
            InitializeComponent();
            body_product_import1.InvalidInput += (s, e) => isInvalidInput = true;
        }
        public static string GenerateRandomCode()
        {
            var rand = new Random();
            string code;

            do
            {
                int number = rand.Next(0, 100000000); 
                code = $"IM{number}";          
            }
            while (DatabaseAccess.Import.GetImportByID(code) != null); // Lặp đến khi không trùng

            return code;
        }
        public ProductImport(DatabaseAccess.Product p, DatabaseAccess.Inventory i)
        {
            InitializeComponent();
            product = p;
            inventory = i;
            header_product_import1.UpdateProductName(product.Product_Name);
            header_product_import1.UpdateProductID(inventory.Product_ID.ToString());
            body_product_import1.inventory = inventory;
            body_product_import1.product = product;
            body_product_import1.UpdateProviderName(product.Product_Provider);
            body_product_import1.CancelButtonClicked += (s, e) => this.Close();
            body_product_import1.ImportButtonClicked += (s, e) => ImportProduct();
            body_product_import1.InvalidInput += (s, e) => isInvalidInput = true;
        }
        public void ImportProduct()
        {
            DatabaseAccess.Import import = new DatabaseAccess.Import
            {
                Import_ID = GenerateRandomCode(),
                Product_ID = inventory.Product_ID,
                Store_ID = inventory.Store_ID,
                Import_Provider = product.Product_Provider,
                Import_Quantity = body_product_import1.GetQuantity(),
                Import_Price = body_product_import1.GetPrice(),
                Import_Total = body_product_import1.GetTotal(),
                Import_Date = body_product_import1.GetDate(),
            };
            if (isInvalidInput)
            {
                MessageBox.Show("Please correct the invalid input before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Task.Run(() => import.CreateNewImport());
            MessageBox.Show("Product imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
