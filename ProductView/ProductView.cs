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

namespace ProductView
{
    public partial class ProductView: Form
    {
        DatabaseAccess.Inventory inventory { get; set; }
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
            var prod = DatabaseAccess.Product.GetProductByID(inventory.Product_ID);
            var store = DatabaseAccess.Store.GetStoreByID(inventory.Store_ID);
            int NumberOfSold = store.GetNumberOfSoldItem(inventory.Product_ID);
            double revenue = prod.Product_Price * NumberOfSold;
            headerProductView1.SetProductDetails(
                prod.Product_Name,
                inventory.Product_ID,
                inventory.Inventory_Stock,
                NumberOfSold,
                prod.Product_Price,
                revenue,
                inventory.Inventory_Status
            );
            ImportListView.Items.Clear();
            List<DatabaseAccess.Import> imports = DatabaseAccess.Import.GetImports(store.Store_ID, prod.Product_ID);
            foreach (var import in imports)
            {
                ListViewItem item = new ListViewItem(prod.Product_Name);
                item.SubItems.Add(import.Product_ID);
                item.SubItems.Add(import.Import_Quantity.ToString());
                item.SubItems.Add(import.Import_Provider);
                item.SubItems.Add(prod.Product_Price.ToString("C2"));
                item.SubItems.Add(import.Import_Price.ToString("C2"));
                item.SubItems.Add(import.Import_Date.ToShortDateString());
                ImportListView.Items.Add(item);
            }
        }
    }
}
