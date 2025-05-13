namespace InvoiceCard
{
    partial class InvoiceCard
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.labelTimeText = new System.Windows.Forms.Label();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelNoItemsText = new System.Windows.Forms.Label();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.labelNoItems = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.panelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Controls.Add(this.labelTimeText);
            this.panelBorder.Controls.Add(this.labelTotalText);
            this.panelBorder.Controls.Add(this.labelNoItemsText);
            this.panelBorder.Controls.Add(this.buttonDetail);
            this.panelBorder.Controls.Add(this.labelNoItems);
            this.panelBorder.Controls.Add(this.labelTotal);
            this.panelBorder.Controls.Add(this.labelTime);
            this.panelBorder.Controls.Add(this.labelInvoiceNumber);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(715, 41);
            this.panelBorder.TabIndex = 0;
            // 
            // labelTimeText
            // 
            this.labelTimeText.AutoSize = true;
            this.labelTimeText.Location = new System.Drawing.Point(231, 7);
            this.labelTimeText.Name = "labelTimeText";
            this.labelTimeText.Size = new System.Drawing.Size(30, 13);
            this.labelTimeText.TabIndex = 5;
            this.labelTimeText.Text = "Time";
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Location = new System.Drawing.Point(350, 7);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(31, 13);
            this.labelTotalText.TabIndex = 6;
            this.labelTotalText.Text = "Total";
            // 
            // labelNoItemsText
            // 
            this.labelNoItemsText.AutoSize = true;
            this.labelNoItemsText.Location = new System.Drawing.Point(448, 7);
            this.labelNoItemsText.Name = "labelNoItemsText";
            this.labelNoItemsText.Size = new System.Drawing.Size(46, 13);
            this.labelNoItemsText.TabIndex = 7;
            this.labelNoItemsText.Text = "NO Item";
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetail.ForeColor = System.Drawing.Color.White;
            this.buttonDetail.Location = new System.Drawing.Point(600, 7);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(96, 23);
            this.buttonDetail.TabIndex = 4;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = false;
            // 
            // labelNoItems
            // 
            this.labelNoItems.AutoSize = true;
            this.labelNoItems.Location = new System.Drawing.Point(463, 20);
            this.labelNoItems.Name = "labelNoItems";
            this.labelNoItems.Size = new System.Drawing.Size(13, 13);
            this.labelNoItems.TabIndex = 3;
            this.labelNoItems.Text = "4";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(350, 20);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "$1200";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(197, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(116, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "15:00:00 - 11/03/2025";
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceNumber.Location = new System.Drawing.Point(13, 9);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(115, 21);
            this.labelInvoiceNumber.TabIndex = 0;
            this.labelInvoiceNumber.Text = "Invoice #7710";
            // 
            // InvoiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBorder);
            this.Name = "InvoiceCard";
            this.Size = new System.Drawing.Size(715, 41);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelNoItems;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Label labelTimeText;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Label labelNoItemsText;
    }
}
