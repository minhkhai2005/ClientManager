using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_add
{
    public partial class Product_add: UserControl
    {
        public Product_add()
        {
            InitializeComponent();
        }

        private void PictureBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // You can now use the selected file path
                    string selectedImagePath = openFileDialog.FileName;

                    // Example: Display the selected image in a PictureBox (if you have one)
                    if (pictureBox1 != null)
                    {
                        pictureBox1.Image = Image.FromFile(selectedImagePath);
                    }
                }
            }
        }
    }
}
