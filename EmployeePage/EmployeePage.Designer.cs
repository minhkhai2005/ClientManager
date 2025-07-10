namespace EmployeePage
{
    partial class EmployeePage
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
            this.EmployeeTitle = new System.Windows.Forms.Label();
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeeTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 1083);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EmployeeTitle
            // 
            this.EmployeeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTitle.AutoSize = true;
            this.EmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTitle.Location = new System.Drawing.Point(4, 12);
            this.EmployeeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeTitle.Name = "EmployeeTitle";
            this.EmployeeTitle.Size = new System.Drawing.Size(1259, 36);
            this.EmployeeTitle.TabIndex = 0;
            this.EmployeeTitle.Text = "Employee";
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeStore,
            this.EmployeeStatus});
            this.EmployeeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeListView.FullRowSelect = true;
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(4, 64);
            this.EmployeeListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.Size = new System.Drawing.Size(1259, 957);
            this.EmployeeListView.TabIndex = 1;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            this.EmployeeListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.EmployeeListView_ColumnClick);
            this.EmployeeListView.ItemActivate += new System.EventHandler(this.EmployeeListView_ItemActivate);
            this.EmployeeListView.SelectedIndexChanged += new System.EventHandler(this.EmployeeListView_SelectedIndexChanged);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "ID";
            this.EmployeeID.Width = 75;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Name";
            this.EmployeeName.Width = 182;
            // 
            // EmployeeStore
            // 
            this.EmployeeStore.Text = "Store";
            this.EmployeeStore.Width = 138;
            // 
            // EmployeeStatus
            // 
            this.EmployeeStatus.Text = "Status";
            this.EmployeeStatus.Width = 192;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(4, 1029);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 50);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeePage";
            this.Size = new System.Drawing.Size(1267, 1083);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EmployeeTitle;
        private System.Windows.Forms.ListView EmployeeListView;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader EmployeeStore;
        private System.Windows.Forms.ColumnHeader EmployeeStatus;
        private System.Windows.Forms.Button addBtn;
    }
}
