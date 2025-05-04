namespace ProductAdd
{
    partial class ProductAdd
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
            this.product_add1 = new Product_add.Product_add();
            this.SuspendLayout();
            // 
            // product_add1
            // 
            this.product_add1.BackColor = System.Drawing.Color.White;
            this.product_add1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_add1.Location = new System.Drawing.Point(0, 0);
            this.product_add1.Margin = new System.Windows.Forms.Padding(2);
            this.product_add1.Name = "product_add1";
            this.product_add1.Size = new System.Drawing.Size(384, 461);
            this.product_add1.TabIndex = 0;
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.product_add1);
            this.Name = "ProductAdd";
            this.Text = "Add New Product";
            this.ResumeLayout(false);

        }

        #endregion

        private Product_add.Product_add product_add1;
    }
}

