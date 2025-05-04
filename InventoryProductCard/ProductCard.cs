using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProductCard
{
    
    public partial class ProductCard: UserControl
    {
        public event EventHandler<string> ViewBtnClick;

        public event EventHandler<string> EditBtnClick;
        public ProductCard()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (ViewBtnClick != null)
            {
                ViewBtnClick.Invoke(this, productID.Text);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (EditBtnClick != null)
            {
                EditBtnClick.Invoke(this, productID.Text);
            }
               
        }
    }
}
