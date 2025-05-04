namespace ProductEdit
{
    partial class ProductEdit
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
            this.header_Product_edit1 = new Header_Product_edit.Header_Product_edit();
            this.body_product_edit1 = new Body_product_edit.Body_product_edit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.header_Product_edit1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.body_product_edit1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.91326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.08675F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // header_Product_edit1
            // 
            this.header_Product_edit1.BackColor = System.Drawing.Color.White;
            this.header_Product_edit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_Product_edit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_Product_edit1.Location = new System.Drawing.Point(2, 2);
            this.header_Product_edit1.Margin = new System.Windows.Forms.Padding(2);
            this.header_Product_edit1.Name = "header_Product_edit1";
            this.header_Product_edit1.Size = new System.Drawing.Size(780, 136);
            this.header_Product_edit1.TabIndex = 0;
            // 
            // body_product_edit1
            // 
            this.body_product_edit1.BackColor = System.Drawing.Color.White;
            this.body_product_edit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.body_product_edit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_product_edit1.Location = new System.Drawing.Point(2, 142);
            this.body_product_edit1.Margin = new System.Windows.Forms.Padding(2);
            this.body_product_edit1.Name = "body_product_edit1";
            this.body_product_edit1.Size = new System.Drawing.Size(780, 467);
            this.body_product_edit1.TabIndex = 1;
            // 
            // ProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductEdit";
            this.Text = "Edit Product";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Header_Product_edit.Header_Product_edit header_Product_edit1;
        private Body_product_edit.Body_product_edit body_product_edit1;
    }
}

