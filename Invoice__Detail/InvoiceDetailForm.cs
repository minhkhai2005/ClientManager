using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Invoice__Detail
{
    public partial class InvoiceDetailForm : UserControl
    {
        public InvoiceDetailForm()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            lblTime.Text = "15:00:00 - 11/03/2025";
            lblEmployee.Text = "Addidas Nguyễn Ánh Thủ";

            // Tạo bảng dữ liệu
            DataTable dt = new DataTable();
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Cost", typeof(string));

            // Dữ liệu mẫu
            dt.Rows.Add("White shoe", 1, "$200");
            dt.Rows.Add("Red T-Shirt", 3, "$150");
            dt.Rows.Add("Blue pant", 2, "$300");

            // Tính tổng
            int totalQuantity = 0;
            decimal totalPrice = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalQuantity += Convert.ToInt32(row["Quantity"]);
                decimal cost = decimal.Parse(row["Cost"].ToString().Replace("$", ""));
                totalPrice += cost;
            }

            dgvInvoice.DataSource = dt;

            // Font
            dgvInvoice.DefaultCellStyle.Font = new Font("Afacad", 12F);
            dgvInvoice.ColumnHeadersDefaultCellStyle.Font = new Font("Afacad", 12F, FontStyle.Bold);

            // Gán giá trị tổng vào Label bên dưới bảng
            lblTotalLabel.Text = "Total:";
            lblTotalQuantity.Text = $"{totalQuantity}";
            lblTotalCost.Text = $"${totalPrice}";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Invoice...");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
