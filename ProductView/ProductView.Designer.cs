namespace ProductView
{
    partial class ProductView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerProductView1 = new HeaderProductView.HeaderProductView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImportListView = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerProductView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.73159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.26841F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // headerProductView1
            // 
            this.headerProductView1.BackColor = System.Drawing.Color.White;
            this.headerProductView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerProductView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerProductView1.Location = new System.Drawing.Point(3, 3);
            this.headerProductView1.Name = "headerProductView1";
            this.headerProductView1.Size = new System.Drawing.Size(778, 139);
            this.headerProductView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImportListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // ImportListView
            // 
            this.ImportListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductID,
            this.Quantity,
            this.Provider,
            this.Price,
            this.Cost,
            this.Date});
            this.ImportListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportListView.FullRowSelect = true;
            this.ImportListView.HideSelection = false;
            this.ImportListView.Location = new System.Drawing.Point(3, 25);
            this.ImportListView.Name = "ImportListView";
            this.ImportListView.Size = new System.Drawing.Size(772, 432);
            this.ImportListView.TabIndex = 0;
            this.ImportListView.UseCompatibleStateImageBehavior = false;
            this.ImportListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product";
            this.ProductName.Width = 89;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ID";
            this.ProductID.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 105;
            // 
            // Provider
            // 
            this.Provider.Text = "Provider";
            this.Provider.Width = 92;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 81;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 68;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 69;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductView";
            this.Text = "Product Detail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HeaderProductView.HeaderProductView headerProductView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ImportListView;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader Date;
    }
}

