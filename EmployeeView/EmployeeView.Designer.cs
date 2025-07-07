using Microsoft.SqlServer.Server;

namespace EmployeeView
{
    partial class EmployeeView
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
        private void InitializeComponent(string employeeID)
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerEmployeeView1 = new HeaderEmployeeView.HeaderEmployeeView();
            this.bodyEmployeeView1 = new BodyEmployeeView.BodyEmployeeView(employeeID);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerEmployeeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bodyEmployeeView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.20321F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.79679F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // headerEmployeeView1
            // 
            this.headerEmployeeView1.BackColor = System.Drawing.Color.White;
            this.headerEmployeeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerEmployeeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerEmployeeView1.Location = new System.Drawing.Point(3, 3);
            this.headerEmployeeView1.Name = "headerEmployeeView1";
            this.headerEmployeeView1.Size = new System.Drawing.Size(778, 141);
            this.headerEmployeeView1.TabIndex = 0;
            // 
            // bodyEmployeeView1
            // 
            this.bodyEmployeeView1.BackColor = System.Drawing.Color.White;
            this.bodyEmployeeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyEmployeeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyEmployeeView1.Location = new System.Drawing.Point(3, 150);
            this.bodyEmployeeView1.Name = "bodyEmployeeView1";
            this.bodyEmployeeView1.Padding = new System.Windows.Forms.Padding(5);
            this.bodyEmployeeView1.Size = new System.Drawing.Size(778, 408);
            this.bodyEmployeeView1.TabIndex = 1;
            this.bodyEmployeeView1.SaveBtnClick += new System.EventHandler(this.bodyEmployeeView1_SaveBtnClick);
            this.bodyEmployeeView1.CancelBtnClick += new System.EventHandler(this.bodyEmployeeView1_CancelBtnClick);
            this.bodyEmployeeView1.DelBtnClick += new System.EventHandler(this.bodyEmployeeView1_DelBtnClick);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeView";
            this.Text = "Employee Detail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerEmployeeView1 = new HeaderEmployeeView.HeaderEmployeeView();
            this.bodyEmployeeView1 = new BodyEmployeeView.BodyEmployeeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerEmployeeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bodyEmployeeView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.20321F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.79679F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // headerEmployeeView1
            // 
            this.headerEmployeeView1.BackColor = System.Drawing.Color.White;
            this.headerEmployeeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerEmployeeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerEmployeeView1.Location = new System.Drawing.Point(3, 3);
            this.headerEmployeeView1.Name = "headerEmployeeView1";
            this.headerEmployeeView1.Size = new System.Drawing.Size(778, 141);
            this.headerEmployeeView1.TabIndex = 0;
            // 
            // bodyEmployeeView1
            // 
            this.bodyEmployeeView1.BackColor = System.Drawing.Color.White;
            this.bodyEmployeeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyEmployeeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyEmployeeView1.Location = new System.Drawing.Point(3, 150);
            this.bodyEmployeeView1.Name = "bodyEmployeeView1";
            this.bodyEmployeeView1.Padding = new System.Windows.Forms.Padding(5);
            this.bodyEmployeeView1.Size = new System.Drawing.Size(778, 408);
            this.bodyEmployeeView1.TabIndex = 1;
            this.bodyEmployeeView1.SaveBtnClick += new System.EventHandler(this.bodyEmployeeView1_SaveBtnClick);
            this.bodyEmployeeView1.CancelBtnClick += new System.EventHandler(this.bodyEmployeeView1_CancelBtnClick);
            this.bodyEmployeeView1.DelBtnClick += new System.EventHandler(this.bodyEmployeeView1_DelBtnClick);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeView";
            this.Text = "Employee Detail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HeaderEmployeeView.HeaderEmployeeView headerEmployeeView1;
        private BodyEmployeeView.BodyEmployeeView bodyEmployeeView1;
    }
}

