namespace ManagerView
{
    partial class ManagerView
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
            this.bodyManagerView1 = new BodyManagerView.BodyManagerView();
            this.headerManagerView1 = new HeaderManagerView.HeaderManagerView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.headerManagerView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bodyManagerView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.63732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.36268F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bodyManagerView1
            // 
            this.bodyManagerView1.BackColor = System.Drawing.Color.White;
            this.bodyManagerView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyManagerView1.Location = new System.Drawing.Point(3, 122);
            this.bodyManagerView1.Name = "bodyManagerView1";
            this.bodyManagerView1.Padding = new System.Windows.Forms.Padding(12);
            this.bodyManagerView1.Size = new System.Drawing.Size(578, 636);
            this.bodyManagerView1.TabIndex = 1;
            // 
            // headerManagerView1
            // 
            this.headerManagerView1.BackColor = System.Drawing.Color.White;
            this.headerManagerView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerManagerView1.Location = new System.Drawing.Point(3, 3);
            this.headerManagerView1.Name = "headerManagerView1";
            this.headerManagerView1.Size = new System.Drawing.Size(578, 113);
            this.headerManagerView1.TabIndex = 0;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManagerView";
            this.Text = "Manager Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HeaderManagerView.HeaderManagerView headerManagerView1;
        private BodyManagerView.BodyManagerView bodyManagerView1;
    }
}

