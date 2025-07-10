namespace Header_Product_edit
{
    partial class Header_Product_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header_Product_edit));
            this.ProductPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ProductPhoto.Image")));
            this.ProductPhoto.Location = new System.Drawing.Point(13, 11);
            this.ProductPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.Size = new System.Drawing.Size(75, 81);
            this.ProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPhoto.TabIndex = 0;
            this.ProductPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(94, 12);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(250, 26);
            this.ProductNameLabel.TabIndex = 5;
            this.ProductNameLabel.Text = "Product’s name";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(97, 34);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(58, 19);
            this.ProductIDLabel.TabIndex = 6;
            this.ProductIDLabel.Text = "ID: 1234";
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(366, 34);
            this.StockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(30, 19);
            this.StockLabel.TabIndex = 7;
            this.StockLabel.Text = "900";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(457, 36);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(37, 13);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "$1200";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblStatus.Location = new System.Drawing.Point(98, 66);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Active";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // Header_Product_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductPhoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Header_Product_edit";
            this.Size = new System.Drawing.Size(583, 100);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label lblStatus;
    }
}
