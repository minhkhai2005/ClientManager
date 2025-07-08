using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeaderProductView
{
    public partial class HeaderProductView : UserControl
    {
        public HeaderProductView()
        {
            InitializeComponent();
        }
        public void SetProductDetails(string productName, string productID, int stock, int sold, double price, double revenue, bool inventoryStatus)
        {
            ProductName.Text = productName;
            ProductID.Text = productID;
            Price.Text = price.ToString();
            Stock.Text = stock.ToString();
            Sold.Text = sold.ToString();
            Revenue.Text = revenue.ToString("C2");
            if (inventoryStatus)
            {
                InventoryStatus.Text = "Active";
                InventoryStatus.ForeColor = Color.Green;
            }
            else
            {
                InventoryStatus.Text = "Inactive";
                InventoryStatus.ForeColor = Color.Red;
            }
        }
    }
}
    
