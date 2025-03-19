namespace OverviewStoresTab
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StorePicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StoreName = new System.Windows.Forms.Label();
            this.StoreAddress = new System.Windows.Forms.Label();
            this.StoreStatus = new System.Windows.Forms.Label();
            this.msgBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.StorePicture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StorePicture
            // 
            this.StorePicture.Image = ((System.Drawing.Image)(resources.GetObject("StorePicture.Image")));
            this.StorePicture.Location = new System.Drawing.Point(812, 11);
            this.StorePicture.Margin = new System.Windows.Forms.Padding(10);
            this.StorePicture.Name = "StorePicture";
            this.StorePicture.Size = new System.Drawing.Size(128, 128);
            this.StorePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture.TabIndex = 0;
            this.StorePicture.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.StoreName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StoreAddress, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.StoreStatus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.msgBtn, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 147);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // StoreName
            // 
            this.StoreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StoreName.AutoSize = true;
            this.StoreName.Font = new System.Drawing.Font("Afacad", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName.Location = new System.Drawing.Point(3, 0);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(281, 46);
            this.StoreName.TabIndex = 0;
            this.StoreName.Text = "Addidas Nguyễn Ảnh Thủ";
            this.StoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoreName.Click += new System.EventHandler(this.StoreName_Click);
            // 
            // StoreAddress
            // 
            this.StoreAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StoreAddress.AutoSize = true;
            this.StoreAddress.Font = new System.Drawing.Font("Afacad", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAddress.Location = new System.Drawing.Point(3, 46);
            this.StoreAddress.Name = "StoreAddress";
            this.StoreAddress.Size = new System.Drawing.Size(392, 33);
            this.StoreAddress.TabIndex = 1;
            this.StoreAddress.Text = "357a Đ. Nguyễn Ảnh Thủ, Trung Mỹ Tây, Quận 12, Hồ Chí Minh, Việt Nam";
            this.StoreAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StoreStatus
            // 
            this.StoreStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StoreStatus.AutoSize = true;
            this.StoreStatus.Font = new System.Drawing.Font("Afacad Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.StoreStatus.Location = new System.Drawing.Point(3, 79);
            this.StoreStatus.Name = "StoreStatus";
            this.StoreStatus.Size = new System.Drawing.Size(60, 33);
            this.StoreStatus.TabIndex = 2;
            this.StoreStatus.Text = "● Open";
            this.StoreStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msgBtn
            // 
            this.msgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.msgBtn.FlatAppearance.BorderSize = 0;
            this.msgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgBtn.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.msgBtn.Location = new System.Drawing.Point(10, 115);
            this.msgBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Size = new System.Drawing.Size(109, 29);
            this.msgBtn.TabIndex = 3;
            this.msgBtn.Text = "Message";
            this.msgBtn.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(953, 155);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(953, 155);
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
        private System.Windows.Forms.Label StoreStatus;
        private System.Windows.Forms.Button msgBtn;
    }
}
