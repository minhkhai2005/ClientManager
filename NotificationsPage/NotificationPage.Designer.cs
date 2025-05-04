namespace NotificationsPage
{
    partial class NotificationPage
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
            this.NotificationTitle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NotiTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotiTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotiStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotiID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NotificationTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.922551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.07745F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 878);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NotificationTitle
            // 
            this.NotificationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationTitle.AutoSize = true;
            this.NotificationTitle.Font = new System.Drawing.Font("Afacad", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationTitle.Location = new System.Drawing.Point(3, 9);
            this.NotificationTitle.Name = "NotificationTitle";
            this.NotificationTitle.Size = new System.Drawing.Size(945, 32);
            this.NotificationTitle.TabIndex = 0;
            this.NotificationTitle.Text = "Notification";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NotiID,
            this.NotiTitle,
            this.NotiTime,
            this.NotiStore});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(945, 821);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // NotiTitle
            // 
            this.NotiTitle.Text = "Title";
            this.NotiTitle.Width = 218;
            // 
            // NotiTime
            // 
            this.NotiTime.Text = "Time";
            this.NotiTime.Width = 138;
            // 
            // NotiStore
            // 
            this.NotiStore.Text = "Store";
            this.NotiStore.Width = 152;
            // 
            // NotiID
            // 
            this.NotiID.Text = "ID";
            // 
            // NotificationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NotificationPage";
            this.Size = new System.Drawing.Size(951, 878);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NotificationTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NotiTitle;
        private System.Windows.Forms.ColumnHeader NotiTime;
        private System.Windows.Forms.ColumnHeader NotiStore;
        private System.Windows.Forms.ColumnHeader NotiID;
    }
}
