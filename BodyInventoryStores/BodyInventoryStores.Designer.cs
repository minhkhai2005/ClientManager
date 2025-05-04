namespace BodyInventoryStores
{
    partial class BodyInventoryStores
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.productCard1 = new InventoryProductCard.ProductCard();
            this.productCard2 = new InventoryProductCard.ProductCard();
            this.productCard3 = new InventoryProductCard.ProductCard();
            this.productCard4 = new InventoryProductCard.ProductCard();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.58989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.410112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 712);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.productCard1);
            this.flowLayoutPanel1.Controls.Add(this.productCard2);
            this.flowLayoutPanel1.Controls.Add(this.productCard3);
            this.flowLayoutPanel1.Controls.Add(this.productCard4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(944, 639);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Afacad Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(3, 648);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // productCard1
            // 
            this.productCard1.BackColor = System.Drawing.Color.White;
            this.productCard1.Location = new System.Drawing.Point(3, 3);
            this.productCard1.Name = "productCard1";
            this.productCard1.Size = new System.Drawing.Size(940, 80);
            this.productCard1.TabIndex = 0;
            // 
            // productCard2
            // 
            this.productCard2.BackColor = System.Drawing.Color.White;
            this.productCard2.Location = new System.Drawing.Point(3, 89);
            this.productCard2.Name = "productCard2";
            this.productCard2.Size = new System.Drawing.Size(940, 80);
            this.productCard2.TabIndex = 1;
            // 
            // productCard3
            // 
            this.productCard3.BackColor = System.Drawing.Color.White;
            this.productCard3.Location = new System.Drawing.Point(3, 175);
            this.productCard3.Name = "productCard3";
            this.productCard3.Size = new System.Drawing.Size(940, 80);
            this.productCard3.TabIndex = 2;
            // 
            // productCard4
            // 
            this.productCard4.BackColor = System.Drawing.Color.White;
            this.productCard4.Location = new System.Drawing.Point(3, 261);
            this.productCard4.Name = "productCard4";
            this.productCard4.Size = new System.Drawing.Size(940, 80);
            this.productCard4.TabIndex = 3;
            // 
            // BodyInventoryStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BodyInventoryStores";
            this.Size = new System.Drawing.Size(950, 712);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addBtn;
        private InventoryProductCard.ProductCard productCard1;
        private InventoryProductCard.ProductCard productCard2;
        private InventoryProductCard.ProductCard productCard3;
        private InventoryProductCard.ProductCard productCard4;
    }
}
