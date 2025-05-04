namespace ProductImport
{
    partial class ProductImport
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
            this.body_product_import1 = new Body_product_import.Body_product_import();
            this.header_product_import1 = new header_product_import.header_product_import();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.body_product_import1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.header_product_import1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.62039F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // body_product_import1
            // 
            this.body_product_import1.BackColor = System.Drawing.Color.White;
            this.body_product_import1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_product_import1.Location = new System.Drawing.Point(2, 119);
            this.body_product_import1.Margin = new System.Windows.Forms.Padding(2);
            this.body_product_import1.Name = "body_product_import1";
            this.body_product_import1.Size = new System.Drawing.Size(380, 340);
            this.body_product_import1.TabIndex = 0;
            // 
            // header_product_import1
            // 
            this.header_product_import1.BackColor = System.Drawing.Color.White;
            this.header_product_import1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_product_import1.Location = new System.Drawing.Point(2, 2);
            this.header_product_import1.Margin = new System.Windows.Forms.Padding(2);
            this.header_product_import1.Name = "header_product_import1";
            this.header_product_import1.Size = new System.Drawing.Size(380, 113);
            this.header_product_import1.TabIndex = 1;
            // 
            // ProductImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductImport";
            this.Text = "Import Product";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Body_product_import.Body_product_import body_product_import1;
        private header_product_import.header_product_import header_product_import1;
    }
}

