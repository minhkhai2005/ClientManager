namespace Product_add
{
    partial class Product_add
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
            this.Name_TXT = new System.Windows.Forms.TextBox();
            this.Price_TXT = new System.Windows.Forms.TextBox();
            this.Stock_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_TXT
            // 
            this.Name_TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_TXT.Location = new System.Drawing.Point(70, 41);
            this.Name_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_TXT.Name = "Name_TXT";
            this.Name_TXT.Size = new System.Drawing.Size(148, 20);
            this.Name_TXT.TabIndex = 0;
            // 
            // Price_TXT
            // 
            this.Price_TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price_TXT.Location = new System.Drawing.Point(70, 106);
            this.Price_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Price_TXT.Name = "Price_TXT";
            this.Price_TXT.Size = new System.Drawing.Size(148, 20);
            this.Price_TXT.TabIndex = 1;
            // 
            // Stock_TXT
            // 
            this.Stock_TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stock_TXT.Location = new System.Drawing.Point(70, 73);
            this.Stock_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stock_TXT.Name = "Stock_TXT";
            this.Stock_TXT.Size = new System.Drawing.Size(148, 20);
            this.Stock_TXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Afacad", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBtn
            // 
            this.PictureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureBtn.Font = new System.Drawing.Font("Afacad", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBtn.ForeColor = System.Drawing.Color.White;
            this.PictureBtn.Location = new System.Drawing.Point(19, 225);
            this.PictureBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBtn.Name = "PictureBtn";
            this.PictureBtn.Size = new System.Drawing.Size(62, 24);
            this.PictureBtn.TabIndex = 7;
            this.PictureBtn.Text = "Picture";
            this.PictureBtn.UseVisualStyleBackColor = false;
            this.PictureBtn.Click += new System.EventHandler(this.PictureBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Afacad", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CancelBtn.Location = new System.Drawing.Point(130, 330);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(64, 27);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Afacad", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(210, 330);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(64, 27);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // Product_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PictureBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stock_TXT);
            this.Controls.Add(this.Price_TXT);
            this.Controls.Add(this.Name_TXT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Product_add";
            this.Size = new System.Drawing.Size(300, 406);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TXT;
        private System.Windows.Forms.TextBox Price_TXT;
        private System.Windows.Forms.TextBox Stock_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PictureBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}
