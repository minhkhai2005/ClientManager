namespace Header_Inventory_Stores
{
    partial class Header_Inventory_Stores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header_Inventory_Stores));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StorePicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StoreName = new System.Windows.Forms.Label();
            this.StoreAddress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Controls.Add(this.StorePicture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StorePicture
            // 
            this.StorePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorePicture.Image = ((System.Drawing.Image)(resources.GetObject("StorePicture.Image")));
            this.StorePicture.Location = new System.Drawing.Point(817, 10);
            this.StorePicture.Margin = new System.Windows.Forms.Padding(10);
            this.StorePicture.Name = "StorePicture";
            this.StorePicture.Size = new System.Drawing.Size(123, 94);
            this.StorePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture.TabIndex = 1;
            this.StorePicture.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.StoreName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StoreAddress, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(801, 108);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // StoreName
            // 
            this.StoreName.AutoSize = true;
            this.StoreName.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName.Location = new System.Drawing.Point(3, 0);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(188, 43);
            this.StoreName.TabIndex = 0;
            this.StoreName.Text = "Tên cửa hàng";
            // 
            // StoreAddress
            // 
            this.StoreAddress.AutoSize = true;
            this.StoreAddress.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAddress.Location = new System.Drawing.Point(3, 64);
            this.StoreAddress.Name = "StoreAddress";
            this.StoreAddress.Size = new System.Drawing.Size(218, 21);
            this.StoreAddress.TabIndex = 1;
            this.StoreAddress.Text = "Địa chỉ cửa hàng địa chỉ cửa hàng";
            // 
            // Header_Inventory_Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Header_Inventory_Stores";
            this.Size = new System.Drawing.Size(950, 114);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox StorePicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label StoreName;
        private System.Windows.Forms.Label StoreAddress;
    }
}
