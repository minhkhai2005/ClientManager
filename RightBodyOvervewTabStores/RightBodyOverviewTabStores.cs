using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace RightBodyOvervewTabStores
{
    
    public partial class RightBodyOverviewTabStores: UserControl
    {
       
        public RightBodyOverviewTabStores()
        {
            InitializeComponent();
            //DisplayBarChart();
        }
        public void UpdateRevenue(double revenue)
        {
            RevenueNumber.Text = $"${revenue:0.00}";
        }
        public void UpdateOrders(int orders)
        {
            OrderNumber.Text = orders.ToString();
        }

    }
}
