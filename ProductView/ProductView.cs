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
using ProductEdit;

namespace ProductView
{
    public partial class ProductView: Form
    {
        DatabaseAccess.Inventory inventory { get; set; }
        DatabaseAccess.Product product { get; set; }
        DatabaseAccess.Store store { get; set; }
        public ProductView()
        {
            InitializeComponent();
        }

        public ProductView(string storeID, string prodID)
        {
            InitializeComponent();
            inventory = DatabaseAccess.Inventory.GetInventoryByID(storeID, prodID);
            LoadProductDetails(inventory);
        }
        private void LoadProductDetails(DatabaseAccess.Inventory inventory) { 
            product = DatabaseAccess.Product.GetProductByID(inventory.Product_ID);
            store = DatabaseAccess.Store.GetStoreByID(inventory.Store_ID);
            int NumberOfSold = store.GetNumberOfSoldItem(store.Store_ID,inventory.Product_ID);
            double revenue = product.Product_Price * NumberOfSold;
            headerProductView1.SetProductDetails(
                product.Product_Name,
                inventory.Product_ID,
                inventory.Inventory_Stock,
                NumberOfSold,
                product.Product_Price,
                revenue,
                inventory.Inventory_Status
            );
            ImportListView.Items.Clear();
            List<DatabaseAccess.Import> imports = DatabaseAccess.Import.GetImports(store.Store_ID, product.Product_ID);
            foreach (var import in imports)
            {
                ListViewItem item = new ListViewItem(product.Product_Name);
                item.SubItems.Add(import.Import_ID);
                item.SubItems.Add(import.Import_Quantity.ToString());
                item.SubItems.Add(import.Import_Provider);
                item.SubItems.Add(import.Import_Price.ToString("C2"));
                item.SubItems.Add(import.Import_Total.ToString("C2"));
                item.SubItems.Add(import.Import_Date.ToShortDateString());
                ImportListView.Items.Add(item);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProductEdit.ProductEdit productEdit = new ProductEdit.ProductEdit(inventory, product);
            productEdit.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
