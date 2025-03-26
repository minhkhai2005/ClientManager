namespace HeaderManagerView
{
    partial class HeaderManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderManagerView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ManagerPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ManagerName = new System.Windows.Forms.Label();
            this.ManagerRole = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerPicture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.06897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.93104F));
            this.tableLayoutPanel1.Controls.Add(this.ManagerPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ManagerPicture
            // 
            this.ManagerPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerPicture.Image = ((System.Drawing.Image)(resources.GetObject("ManagerPicture.Image")));
            this.ManagerPicture.Location = new System.Drawing.Point(20, 20);
            this.ManagerPicture.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.ManagerPicture.Name = "ManagerPicture";
            this.ManagerPicture.Size = new System.Drawing.Size(126, 119);
            this.ManagerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManagerPicture.TabIndex = 0;
            this.ManagerPicture.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ManagerName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ManagerRole, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(156, 22);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 22, 12, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.18803F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.81197F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 115);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ManagerName
            // 
            this.ManagerName.AutoSize = true;
            this.ManagerName.Font = new System.Drawing.Font("Afacad Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerName.Location = new System.Drawing.Point(3, 0);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(210, 39);
            this.ManagerName.TabIndex = 0;
            this.ManagerName.Text = "Trần Minh Khải";
            // 
            // ManagerRole
            // 
            this.ManagerRole.AutoSize = true;
            this.ManagerRole.Font = new System.Drawing.Font("Afacad Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.ManagerRole.Location = new System.Drawing.Point(6, 39);
            this.ManagerRole.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.ManagerRole.Name = "ManagerRole";
            this.ManagerRole.Size = new System.Drawing.Size(67, 21);
            this.ManagerRole.TabIndex = 1;
            this.ManagerRole.Text = "Manager";
            this.ManagerRole.Click += new System.EventHandler(this.ManagerRole_Click);
            // 
            // HeaderManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HeaderManagerView";
            this.Size = new System.Drawing.Size(578, 159);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerPicture)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ManagerPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ManagerName;
        private System.Windows.Forms.Label ManagerRole;
    }
}
