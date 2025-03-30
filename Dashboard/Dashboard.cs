using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
   
    public partial class Dashboard: UserControl
    {
        readonly List<string> TimeBoxItems = new List<String> { "Month", "Week", "Day" };

        public Dashboard()
        {
            InitializeComponent();
            TimeBox.DataSource = TimeBoxItems;
        }

        private void RevenueText_Click(object sender, EventArgs e)
        {

        }
    }
}
