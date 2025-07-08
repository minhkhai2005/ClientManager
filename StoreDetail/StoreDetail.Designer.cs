namespace StoreDetail
{
    partial class StoreDetail
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rightBodyOverviewTabStores1 = new RightBodyOvervewTabStores.RightBodyOverviewTabStores();
            this.leftBodyOverviewTabStores1 = new LeftBodyOverviewTabStores.LeftBodyOverviewTabStores();
            this.overviewHeader = new OverviewStoresTab.UserControl1();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.header_Inventory_Stores1 = new Header_Inventory_Stores.Header_Inventory_Stores();
            this.InventoryListView = new System.Windows.Forms.ListView();
            this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.header_Inventory_Stores2 = new Header_Inventory_Stores.Header_Inventory_Stores();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.header_Inventory_Stores3 = new Header_Inventory_Stores.Header_Inventory_Stores();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.InvoiceTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.header_Inventory_Stores4 = new Header_Inventory_Stores.Header_Inventory_Stores();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvoiceListView = new System.Windows.Forms.ListView();
            this.InvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.MessageTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.InvoiceTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OverviewTab);
            this.tabControl1.Controls.Add(this.InventoryTab);
            this.tabControl1.Controls.Add(this.EmployeeTab);
            this.tabControl1.Controls.Add(this.MessageTab);
            this.tabControl1.Controls.Add(this.InvoiceTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 831);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // OverviewTab
            // 
            this.OverviewTab.Controls.Add(this.tableLayoutPanel1);
            this.OverviewTab.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab.Location = new System.Drawing.Point(4, 30);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverviewTab.Size = new System.Drawing.Size(931, 797);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            this.OverviewTab.UseVisualStyleBackColor = true;
            this.OverviewTab.Enter += new System.EventHandler(this.OverviewTab_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rightBodyOverviewTabStores1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.leftBodyOverviewTabStores1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.overviewHeader, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.68675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.31326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 791);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rightBodyOverviewTabStores1
            // 
            this.rightBodyOverviewTabStores1.BackColor = System.Drawing.Color.White;
            this.rightBodyOverviewTabStores1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightBodyOverviewTabStores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightBodyOverviewTabStores1.Location = new System.Drawing.Point(465, 174);
            this.rightBodyOverviewTabStores1.Name = "rightBodyOverviewTabStores1";
            this.rightBodyOverviewTabStores1.Size = new System.Drawing.Size(457, 614);
            this.rightBodyOverviewTabStores1.TabIndex = 1;
            // 
            // leftBodyOverviewTabStores1
            // 
            this.leftBodyOverviewTabStores1.BackColor = System.Drawing.Color.White;
            this.leftBodyOverviewTabStores1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftBodyOverviewTabStores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftBodyOverviewTabStores1.Location = new System.Drawing.Point(3, 174);
            this.leftBodyOverviewTabStores1.Name = "leftBodyOverviewTabStores1";
            this.leftBodyOverviewTabStores1.Size = new System.Drawing.Size(456, 614);
            this.leftBodyOverviewTabStores1.TabIndex = 2;
            // 
            // overviewHeader
            // 
            this.overviewHeader.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.overviewHeader, 2);
            this.overviewHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewHeader.Location = new System.Drawing.Point(3, 3);
            this.overviewHeader.Name = "overviewHeader";
            this.overviewHeader.Size = new System.Drawing.Size(919, 165);
            this.overviewHeader.TabIndex = 3;
            this.overviewHeader.MsgBtnClicked += new System.EventHandler(this.overviewHeader_MsgBtnClicked);
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.tableLayoutPanel2);
            this.InventoryTab.Location = new System.Drawing.Point(4, 30);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(931, 797);
            this.InventoryTab.TabIndex = 1;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            this.InventoryTab.Enter += new System.EventHandler(this.InventoryTab_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.addBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.header_Inventory_Stores1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.InventoryListView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.95238F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(925, 791);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Afacad Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(3, 741);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 29);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // header_Inventory_Stores1
            // 
            this.header_Inventory_Stores1.BackColor = System.Drawing.Color.White;
            this.header_Inventory_Stores1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_Inventory_Stores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_Inventory_Stores1.Location = new System.Drawing.Point(4, 5);
            this.header_Inventory_Stores1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header_Inventory_Stores1.Name = "header_Inventory_Stores1";
            this.header_Inventory_Stores1.Size = new System.Drawing.Size(917, 130);
            this.header_Inventory_Stores1.TabIndex = 3;
            // 
            // InventoryListView
            // 
            this.InventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductName,
            this.columnProductID,
            this.columnProductPrice,
            this.columnProductStock,
            this.columnProductSold,
            this.columnProductStatus});
            this.InventoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryListView.FullRowSelect = true;
            this.InventoryListView.HideSelection = false;
            this.InventoryListView.Location = new System.Drawing.Point(3, 143);
            this.InventoryListView.Name = "InventoryListView";
            this.InventoryListView.Size = new System.Drawing.Size(919, 592);
            this.InventoryListView.TabIndex = 4;
            this.InventoryListView.UseCompatibleStateImageBehavior = false;
            this.InventoryListView.View = System.Windows.Forms.View.Details;
            this.InventoryListView.ItemActivate += new System.EventHandler(this.InventoryListView_ItemActivate);
            // 
            // columnProductName
            // 
            this.columnProductName.Text = "Name";
            this.columnProductName.Width = 200;
            // 
            // columnProductID
            // 
            this.columnProductID.Text = "ID";
            this.columnProductID.Width = 120;
            // 
            // columnProductPrice
            // 
            this.columnProductPrice.Text = "Price";
            this.columnProductPrice.Width = 120;
            // 
            // columnProductStock
            // 
            this.columnProductStock.Text = "Stock";
            // 
            // columnProductSold
            // 
            this.columnProductSold.Text = "Sold";
            // 
            // columnProductStatus
            // 
            this.columnProductStatus.Text = "Status";
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.tableLayoutPanel3);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 30);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(931, 797);
            this.EmployeeTab.TabIndex = 2;
            this.EmployeeTab.Text = "Employee";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            this.EmployeeTab.Enter += new System.EventHandler(this.EmployeeTab_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.header_Inventory_Stores2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addEmployeeBtn, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.EmployeeListView, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.81313F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.18687F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(925, 791);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // header_Inventory_Stores2
            // 
            this.header_Inventory_Stores2.BackColor = System.Drawing.Color.White;
            this.header_Inventory_Stores2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_Inventory_Stores2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_Inventory_Stores2.Location = new System.Drawing.Point(4, 5);
            this.header_Inventory_Stores2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header_Inventory_Stores2.Name = "header_Inventory_Stores2";
            this.header_Inventory_Stores2.Size = new System.Drawing.Size(917, 131);
            this.header_Inventory_Stores2.TabIndex = 0;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployeeBtn.Location = new System.Drawing.Point(3, 756);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(91, 32);
            this.addEmployeeBtn.TabIndex = 2;
            this.addEmployeeBtn.Text = "Add";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.BackColor = System.Drawing.Color.White;
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeName,
            this.IDColumn,
            this.Status});
            this.EmployeeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeListView.FullRowSelect = true;
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(3, 144);
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.Size = new System.Drawing.Size(919, 606);
            this.EmployeeListView.TabIndex = 3;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            this.EmployeeListView.ItemActivate += new System.EventHandler(this.EmployeeListView_ItemActivate);
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Name";
            this.EmployeeName.Width = 224;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 139;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 224;
            // 
            // MessageTab
            // 
            this.MessageTab.Controls.Add(this.tableLayoutPanel4);
            this.MessageTab.Location = new System.Drawing.Point(4, 30);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.Padding = new System.Windows.Forms.Padding(3);
            this.MessageTab.Size = new System.Drawing.Size(931, 797);
            this.MessageTab.TabIndex = 3;
            this.MessageTab.Text = "Message";
            this.MessageTab.UseVisualStyleBackColor = true;
            this.MessageTab.Enter += new System.EventHandler(this.MessageTab_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel4.Controls.Add(this.header_Inventory_Stores3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.richTextBox2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.sendBtn, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87952F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.39759F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72289F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(925, 791);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // header_Inventory_Stores3
            // 
            this.header_Inventory_Stores3.BackColor = System.Drawing.Color.White;
            this.header_Inventory_Stores3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.header_Inventory_Stores3, 2);
            this.header_Inventory_Stores3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_Inventory_Stores3.Location = new System.Drawing.Point(5, 8);
            this.header_Inventory_Stores3.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.header_Inventory_Stores3.Name = "header_Inventory_Stores3";
            this.header_Inventory_Stores3.Size = new System.Drawing.Size(915, 141);
            this.header_Inventory_Stores3.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(919, 542);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 708);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(814, 80);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(823, 728);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(99, 39);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            // 
            // InvoiceTab
            // 
            this.InvoiceTab.Controls.Add(this.tableLayoutPanel5);
            this.InvoiceTab.Location = new System.Drawing.Point(4, 30);
            this.InvoiceTab.Name = "InvoiceTab";
            this.InvoiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.InvoiceTab.Size = new System.Drawing.Size(931, 797);
            this.InvoiceTab.TabIndex = 4;
            this.InvoiceTab.Text = "Invoices";
            this.InvoiceTab.UseVisualStyleBackColor = true;
            this.InvoiceTab.Enter += new System.EventHandler(this.InvoiceTab_Enter);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.header_Inventory_Stores4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.43373F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.56626F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(925, 791);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // header_Inventory_Stores4
            // 
            this.header_Inventory_Stores4.BackColor = System.Drawing.Color.White;
            this.header_Inventory_Stores4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_Inventory_Stores4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_Inventory_Stores4.Location = new System.Drawing.Point(3, 3);
            this.header_Inventory_Stores4.Name = "header_Inventory_Stores4";
            this.header_Inventory_Stores4.Size = new System.Drawing.Size(919, 139);
            this.header_Inventory_Stores4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InvoiceListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 640);
            this.panel1.TabIndex = 2;
            // 
            // InvoiceListView
            // 
            this.InvoiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvoiceID,
            this.InvoiceTime,
            this.InvoiceTotal,
            this.NumItems,
            this.StatusColumn});
            this.InvoiceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceListView.FullRowSelect = true;
            this.InvoiceListView.HideSelection = false;
            this.InvoiceListView.Location = new System.Drawing.Point(0, 0);
            this.InvoiceListView.Name = "InvoiceListView";
            this.InvoiceListView.Size = new System.Drawing.Size(917, 638);
            this.InvoiceListView.TabIndex = 0;
            this.InvoiceListView.UseCompatibleStateImageBehavior = false;
            this.InvoiceListView.View = System.Windows.Forms.View.Details;
            this.InvoiceListView.ItemActivate += new System.EventHandler(this.InvoiceListView_ItemActivate);
            // 
            // InvoiceID
            // 
            this.InvoiceID.Text = "ID";
            this.InvoiceID.Width = 147;
            // 
            // InvoiceTime
            // 
            this.InvoiceTime.Text = "Time";
            this.InvoiceTime.Width = 156;
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.Text = "Total";
            this.InvoiceTotal.Width = 239;
            // 
            // NumItems
            // 
            this.NumItems.Text = "Number of items";
            this.NumItems.Width = 194;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 100;
            // 
            // StoreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "StoreDetail";
            this.Size = new System.Drawing.Size(939, 831);
            this.tabControl1.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.InventoryTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.MessageTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.InvoiceTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.TabPage MessageTab;
        private System.Windows.Forms.TabPage InvoiceTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RightBodyOvervewTabStores.RightBodyOverviewTabStores rightBodyOverviewTabStores1;
        private LeftBodyOverviewTabStores.LeftBodyOverviewTabStores leftBodyOverviewTabStores1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addBtn;
        private Header_Inventory_Stores.Header_Inventory_Stores header_Inventory_Stores1;
        private OverviewStoresTab.UserControl1 overviewHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Header_Inventory_Stores.Header_Inventory_Stores header_Inventory_Stores2;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.ListView EmployeeListView;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Header_Inventory_Stores.Header_Inventory_Stores header_Inventory_Stores3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Header_Inventory_Stores.Header_Inventory_Stores header_Inventory_Stores4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView InvoiceListView;
        private System.Windows.Forms.ColumnHeader InvoiceID;
        private System.Windows.Forms.ColumnHeader InvoiceTime;
        private System.Windows.Forms.ColumnHeader InvoiceTotal;
        private System.Windows.Forms.ColumnHeader NumItems;
        private System.Windows.Forms.ListView InventoryListView;
        private System.Windows.Forms.ColumnHeader columnProductName;
        private System.Windows.Forms.ColumnHeader columnProductID;
        private System.Windows.Forms.ColumnHeader columnProductPrice;
        private System.Windows.Forms.ColumnHeader columnProductStock;
        private System.Windows.Forms.ColumnHeader columnProductSold;
        private System.Windows.Forms.ColumnHeader columnProductStatus;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
    }
}
