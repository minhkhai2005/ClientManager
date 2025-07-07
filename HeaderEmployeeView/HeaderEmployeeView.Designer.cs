namespace HeaderEmployeeView
{
    partial class HeaderEmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderEmployeeView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeePicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeStore = new System.Windows.Forms.Label();
            this.PictureBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeePicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePicture.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePicture.Image")));
            this.EmployeePicture.Location = new System.Drawing.Point(10, 10);
            this.EmployeePicture.Margin = new System.Windows.Forms.Padding(10);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(135, 128);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePicture.TabIndex = 0;
            this.EmployeePicture.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.EmployeeName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PictureBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.EmployeeStore, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 142);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(3, 0);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(194, 35);
            this.EmployeeName.TabIndex = 0;
            this.EmployeeName.Text = "Tên nhân viên";
            this.EmployeeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeStore
            // 
            this.EmployeeStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeStore.AutoSize = true;
            this.EmployeeStore.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.EmployeeStore.Location = new System.Drawing.Point(3, 49);
            this.EmployeeStore.Name = "EmployeeStore";
            this.EmployeeStore.Size = new System.Drawing.Size(87, 21);
            this.EmployeeStore.TabIndex = 2;
            this.EmployeeStore.Text = "Nơi làm việc";
            // 
            // PictureBtn
            // 
            this.PictureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PictureBtn.FlatAppearance.BorderSize = 0;
            this.PictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureBtn.Font = new System.Drawing.Font("Afacad SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBtn.ForeColor = System.Drawing.Color.White;
            this.PictureBtn.Location = new System.Drawing.Point(3, 108);
            this.PictureBtn.Name = "PictureBtn";
            this.PictureBtn.Size = new System.Drawing.Size(101, 31);
            this.PictureBtn.TabIndex = 3;
            this.PictureBtn.Text = "Picture";
            this.PictureBtn.UseVisualStyleBackColor = false;
            // 
            // HeaderEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HeaderEmployeeView";
            this.Size = new System.Drawing.Size(778, 148);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox EmployeePicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeStore;
        private System.Windows.Forms.Button PictureBtn;
    }
}
