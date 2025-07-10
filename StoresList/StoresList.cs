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
using static Sign_In.Sign_in;
using static ListViewColumnSorter;

namespace StoresList
{
    public partial class StoreList: UserControl
    {
        private ListViewColumnSorter lvwColumnSorter;
        public event EventHandler<string> StoreSelected;
        public List<DatabaseAccess.Store> stores { get; set; }
        public StoreList()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.StoresListView.ListViewItemSorter = lvwColumnSorter;
        }

        public void UpdateStoreList()
        {
            StoresListView.Items.Clear();
            StoresListView.ListViewItemSorter = null; // turn off sorting temporarily
            StoresListView.BeginUpdate();
            foreach (var store in stores)
            {
                ListViewItem item = new ListViewItem(store.Store_ID);
                item.SubItems.Add(store.Store_Name);
                item.SubItems.Add(store.Store_Address);
                item.SubItems.Add(store.Store_Status ? "Open" : "Closed");
                item.Tag = store; // Store the entire store object in the Tag property
                StoresListView.Items.Add(item);
            }
            StoresListView.EndUpdate();
            StoresListView.ListViewItemSorter = lvwColumnSorter; // re-enable sorting
            StoresListView.Sort(); // Sort the list view after updating
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (StoresListView.SelectedItems.Count > 0)
            {
                var selectedItem = StoresListView.SelectedItems[0];
                var store = selectedItem.Tag as DatabaseAccess.Store;
                if (store != null)
                {
                    StoreSelected?.Invoke(this, store.Store_ID);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Store ad = new Add_Store();
            ad.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FetchStoresList()
        {
            stores = DatabaseAccess.GetStoresByManagerID(Session.UID);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.StoresListView.Sort();
        }
    }
}
