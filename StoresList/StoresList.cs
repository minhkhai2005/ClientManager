using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreDetail;

namespace StoresList
{
    public partial class StoreList: UserControl
    {
        public event EventHandler<string> ViewBtnClicked;
        public event EventHandler<string> MessageBtnClicked;
        public StoreList()
        {
            InitializeComponent();
            card_displaying_store_in41.ViewBtnClicked += ViewBtnClick;
            card_displaying_store_in41.MessageBtnClicked += MessageBtnClick;
        }

        private void ViewBtnClick(object sender, string StoreID)
        {
            ViewBtnClicked?.Invoke(this, StoreID);
        }

        private void MessageBtnClick(object sender, string StoreID)
        {
            MessageBtnClicked?.Invoke(this, StoreID);
        }
    }
}
