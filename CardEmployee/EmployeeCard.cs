using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CardEmployee
{
    public partial class EmployeeCard : UserControl
    {
        private string connectionString = "Your Connection String"; //Điền connection string của bạn vào đây

        public EmployeeCard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TenNhanVien, ChucVu, Addidas, TrangThai, Anh FROM NhanVien"; //Sửa query cho phù hợp

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy dữ liệu từ database
                                labelName.Text = reader["TenNhanVien"].ToString();
                                labelRole.Text = reader["ChucVu"].ToString();
                                labelAdditionalInfo.Text = reader["Addidas"].ToString();

                                // Cập nhật trạng thái và màu sắc
                                string trangThai = reader["TrangThai"].ToString();
                                labelStatus.Text = trangThai;
                                panelStatusColor.BackColor = (trangThai == "On duty") ? Color.Green : Color.Red;

                                // Hiển thị ảnh
                                if (reader["Anh"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["Anh"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBoxPhoto.Image = Image.FromStream(ms);
                                        labelInitial.Visible = false;
                                        labelPhotoText.Visible = false;
                                    }
                                }
                                else
                                {
                                    pictureBoxPhoto.Image = null;
                                    labelInitial.Visible = true;
                                    labelInitial.Text = GetNameInitial(labelName.Text);
                                    labelPhotoText.Visible = true;
                                }
                            }
                            else
                            {
                                // Nếu không có dữ liệu, hiển thị dữ liệu mặc định
                                labelName.Text = "Trần Minh Khải";
                                labelRole.Text = "Employee's role";
                                labelAdditionalInfo.Text = "Addidas Nguyễn Ảnh Thủ";
                                labelStatus.Text = "On duty";
                                panelStatusColor.BackColor = Color.Green;
                                pictureBoxPhoto.Image = null;
                                labelInitial.Visible = true;
                                labelInitial.Text = GetNameInitial(labelName.Text);
                                labelPhotoText.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetNameInitial(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "";

            string[] parts = name.Split(' ');
            if (parts.Length > 0)
            {
                return parts[parts.Length - 1].Substring(0, 1).ToUpper();
            }
            return name.Substring(0, 1).ToUpper();
        }

        private void labelPhotoText_Click(object sender, EventArgs e)
        {

        }

        private void labelPhotoText_Click_1(object sender, EventArgs e)
        {

        }
    }
}
