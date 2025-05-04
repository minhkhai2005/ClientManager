namespace InventoryProductCard
{
    partial class ProductCard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.priceNum = new System.Windows.Forms.Label();
            this.stockNum = new System.Windows.Forms.Label();
            this.soldNum = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.activeStatus = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.soldLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.894737F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.10526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.priceNum, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.stockNum, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.soldNum, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.activeStatus, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.soldLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.productID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.editBtn, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // priceNum
            // 
            this.priceNum.AutoSize = true;
            this.priceNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceNum.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.priceNum.Location = new System.Drawing.Point(470, 40);
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(111, 40);
            this.priceNum.TabIndex = 11;
            this.priceNum.Text = "$1200";
            this.priceNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stockNum
            // 
            this.stockNum.AutoSize = true;
            this.stockNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockNum.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.stockNum.Location = new System.Drawing.Point(221, 40);
            this.stockNum.Name = "stockNum";
            this.stockNum.Size = new System.Drawing.Size(126, 40);
            this.stockNum.TabIndex = 9;
            this.stockNum.Text = "900";
            this.stockNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // soldNum
            // 
            this.soldNum.AutoSize = true;
            this.soldNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldNum.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.soldNum.Location = new System.Drawing.Point(353, 40);
            this.soldNum.Name = "soldNum";
            this.soldNum.Size = new System.Drawing.Size(111, 40);
            this.soldNum.TabIndex = 10;
            this.soldNum.Text = "112";
            this.soldNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Font = new System.Drawing.Font("Afacad SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(470, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(111, 40);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activeStatus
            // 
            this.activeStatus.AutoSize = true;
            this.activeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeStatus.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.activeStatus.Location = new System.Drawing.Point(587, 0);
            this.activeStatus.Name = "activeStatus";
            this.tableLayoutPanel1.SetRowSpan(this.activeStatus, 2);
            this.activeStatus.Size = new System.Drawing.Size(111, 80);
            this.activeStatus.TabIndex = 6;
            this.activeStatus.Text = "●Active";
            this.activeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockLabel.Font = new System.Drawing.Font("Afacad SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(221, 0);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(126, 40);
            this.stockLabel.TabIndex = 3;
            this.stockLabel.Text = "Stock";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soldLabel
            // 
            this.soldLabel.AutoSize = true;
            this.soldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldLabel.Font = new System.Drawing.Font("Afacad SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldLabel.Location = new System.Drawing.Point(353, 0);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(111, 40);
            this.soldLabel.TabIndex = 4;
            this.soldLabel.Text = "Sold";
            this.soldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(87, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName.Font = new System.Drawing.Font("Afacad SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(96, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(119, 40);
            this.productName.TabIndex = 1;
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productID.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.productID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productID.Location = new System.Drawing.Point(96, 40);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(119, 40);
            this.productID.TabIndex = 2;
            this.productID.Text = "ID: 1234";
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Afacad Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.editBtn.Location = new System.Drawing.Point(704, 27);
            this.editBtn.MaximumSize = new System.Drawing.Size(75, 25);
            this.editBtn.Name = "editBtn";
            this.tableLayoutPanel1.SetRowSpan(this.editBtn, 2);
            this.editBtn.Size = new System.Drawing.Size(75, 25);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Afacad Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(821, 27);
            this.viewBtn.MaximumSize = new System.Drawing.Size(75, 25);
            this.viewBtn.Name = "viewBtn";
            this.tableLayoutPanel1.SetRowSpan(this.viewBtn, 2);
            this.viewBtn.Size = new System.Drawing.Size(75, 25);
            this.viewBtn.TabIndex = 13;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(940, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.Label priceNum;
        private System.Windows.Forms.Label stockNum;
        private System.Windows.Forms.Label soldNum;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label activeStatus;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}
