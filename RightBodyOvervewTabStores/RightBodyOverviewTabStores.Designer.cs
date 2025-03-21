namespace RightBodyOvervewTabStores
{
    partial class RightBodyOverviewTabStores
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LanguagesBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RevenueText = new System.Windows.Forms.Label();
            this.RevenueNumber = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderText = new System.Windows.Forms.Label();
            this.OrderNumber = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 1210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.LanguagesBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(920, 230);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LanguagesBox
            // 
            this.LanguagesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguagesBox.FormattingEnabled = true;
            this.LanguagesBox.Location = new System.Drawing.Point(650, 6);
            this.LanguagesBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LanguagesBox.Name = "LanguagesBox";
            this.LanguagesBox.Size = new System.Drawing.Size(238, 33);
            this.LanguagesBox.Sorted = true;
            this.LanguagesBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RevenueText);
            this.flowLayoutPanel1.Controls.Add(this.RevenueNumber);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(632, 218);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // RevenueText
            // 
            this.RevenueText.AutoSize = true;
            this.RevenueText.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueText.Location = new System.Drawing.Point(6, 0);
            this.RevenueText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RevenueText.Name = "RevenueText";
            this.RevenueText.Size = new System.Drawing.Size(254, 85);
            this.RevenueText.TabIndex = 0;
            this.RevenueText.Text = "Revenue";
            // 
            // RevenueNumber
            // 
            this.RevenueNumber.AutoSize = true;
            this.RevenueNumber.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueNumber.Location = new System.Drawing.Point(6, 85);
            this.RevenueNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RevenueNumber.Name = "RevenueNumber";
            this.RevenueNumber.Size = new System.Drawing.Size(235, 85);
            this.RevenueNumber.TabIndex = 1;
            this.RevenueNumber.Text = "$10000";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.OrderText);
            this.flowLayoutPanel2.Controls.Add(this.OrderNumber);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 248);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(920, 230);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // OrderText
            // 
            this.OrderText.AutoSize = true;
            this.OrderText.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderText.Location = new System.Drawing.Point(6, 0);
            this.OrderText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OrderText.Name = "OrderText";
            this.OrderText.Size = new System.Drawing.Size(211, 85);
            this.OrderText.TabIndex = 0;
            this.OrderText.Text = "Orders";
            // 
            // OrderNumber
            // 
            this.OrderNumber.AutoSize = true;
            this.OrderNumber.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumber.Location = new System.Drawing.Point(6, 85);
            this.OrderNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(136, 85);
            this.OrderNumber.TabIndex = 1;
            this.OrderNumber.Text = "500";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.TimeBox);
            this.flowLayoutPanel3.Controls.Add(this.formsPlot1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 490);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(920, 714);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // TimeBox
            // 
            this.TimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(6, 6);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(238, 33);
            this.TimeBox.Sorted = true;
            this.TimeBox.TabIndex = 0;
            // 
            // formsPlot1
            // 
            this.formsPlot1.DisplayScale = 0F;
            this.formsPlot1.Location = new System.Drawing.Point(6, 51);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(916, 629);
            this.formsPlot1.TabIndex = 1;
            // 
            // RightBodyOverviewTabStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RightBodyOverviewTabStores";
            this.Size = new System.Drawing.Size(932, 1210);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox LanguagesBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label RevenueText;
        private System.Windows.Forms.Label RevenueNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label OrderText;
        private System.Windows.Forms.Label OrderNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox TimeBox;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}
