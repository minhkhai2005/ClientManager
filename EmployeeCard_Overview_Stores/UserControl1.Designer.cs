namespace EmployeeCard_Overview_Stores
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeePicture = new System.Windows.Forms.PictureBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeRole = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeePicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeRole, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePicture.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePicture.Image")));
            this.EmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.EmployeePicture.Name = "EmployeePicture";
            this.tableLayoutPanel1.SetRowSpan(this.EmployeePicture, 2);
            this.EmployeePicture.Size = new System.Drawing.Size(83, 74);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePicture.TabIndex = 0;
            this.EmployeePicture.TabStop = false;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ViewBtn.FlatAppearance.BorderSize = 0;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.Color.White;
            this.ViewBtn.Location = new System.Drawing.Point(333, 22);
            this.ViewBtn.MaximumSize = new System.Drawing.Size(90, 35);
            this.ViewBtn.Name = "ViewBtn";
            this.tableLayoutPanel1.SetRowSpan(this.ViewBtn, 2);
            this.ViewBtn.Size = new System.Drawing.Size(90, 35);
            this.ViewBtn.TabIndex = 1;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Afacad Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(92, 0);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(174, 36);
            this.EmployeeName.TabIndex = 2;
            this.EmployeeName.Text = "Trần Minh Khải";
            // 
            // EmployeeRole
            // 
            this.EmployeeRole.AutoSize = true;
            this.EmployeeRole.Font = new System.Drawing.Font("Afacad Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.EmployeeRole.Location = new System.Drawing.Point(92, 40);
            this.EmployeeRole.Name = "EmployeeRole";
            this.EmployeeRole.Size = new System.Drawing.Size(64, 19);
            this.EmployeeRole.TabIndex = 3;
            this.EmployeeRole.Text = "Employee";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(430, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox EmployeePicture;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeRole;
    }
}
