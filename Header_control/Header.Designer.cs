namespace Header_control
{
    partial class Header
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.softwareName = new System.Windows.Forms.Label();
            this.uesrname = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.avt = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avt)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.071429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.285714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.07143F));
            this.tableLayoutPanel1.Controls.Add(this.logo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.softwareName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uesrname, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.userRole, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.avt, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1867, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::Header_control.Properties.Resources.AnyConv_com__svgviewer_output;
            this.logo.Location = new System.Drawing.Point(3, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.tableLayoutPanel1.SetRowSpan(this.logo, 2);
            this.logo.Size = new System.Drawing.Size(126, 119);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // softwareName
            // 
            this.softwareName.AutoSize = true;
            this.softwareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.softwareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.softwareName.Location = new System.Drawing.Point(135, 0);
            this.softwareName.Name = "softwareName";
            this.tableLayoutPanel1.SetRowSpan(this.softwareName, 2);
            this.softwareName.Size = new System.Drawing.Size(167, 123);
            this.softwareName.TabIndex = 1;
            this.softwareName.Text = "USMS";
            this.softwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uesrname
            // 
            this.uesrname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uesrname.AutoSize = true;
            this.uesrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uesrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.uesrname.Location = new System.Drawing.Point(1625, 0);
            this.uesrname.Name = "uesrname";
            this.uesrname.Size = new System.Drawing.Size(189, 61);
            this.uesrname.TabIndex = 3;
            this.uesrname.Text = "Tran Minh Khai";
            this.uesrname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uesrname.Click += new System.EventHandler(this.uesrname_Click);
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.userRole.Location = new System.Drawing.Point(1625, 61);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(90, 25);
            this.userRole.TabIndex = 4;
            this.userRole.Text = "Manager";
            this.userRole.Click += new System.EventHandler(this.userRole_Click);
            // 
            // avt
            // 
            this.avt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avt.Image = global::Header_control.Properties.Resources.AnyConv_com__avatar_boy_svgrepo_com__3_;
            this.avt.Location = new System.Drawing.Point(1486, 2);
            this.avt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avt.MaximumSize = new System.Drawing.Size(133, 118);
            this.avt.Name = "avt";
            this.tableLayoutPanel1.SetRowSpan(this.avt, 2);
            this.avt.Size = new System.Drawing.Size(133, 118);
            this.avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avt.TabIndex = 2;
            this.avt.TabStop = false;
            this.avt.Click += new System.EventHandler(this.avt_Click);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1867, 123);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label softwareName;
        private System.Windows.Forms.PictureBox avt;
        private System.Windows.Forms.Label uesrname;
        private System.Windows.Forms.Label userRole;
    }
}
