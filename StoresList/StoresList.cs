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
using DatabaseClass;

namespace StoresList
{
    public partial class StoreList: UserControl
    {
        public event EventHandler<string> StoreSelected;
        public StoreList()
        {
            InitializeComponent();
        }

        public void UpdateStoreList(List<DatabaseAccess.Store> stores)
        {
            listView1.Items.Clear();
            foreach (var store in stores)
            {
                ListViewItem item = new ListViewItem(store.Store_ID);
                item.SubItems.Add(store.Store_Name);
                item.SubItems.Add(store.Store_Address);
                item.SubItems.Add(store.Status);
                item.Tag = store; // Store the entire store object in the Tag property
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                var store = selectedItem.Tag as DatabaseAccess.Store;
                if (store != null)
                {
                    StoreSelected?.Invoke(this, store.Store_ID);
                }
            }
        }
    }
}
