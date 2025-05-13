namespace YourNamespace
{
    partial class NotificationCard
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBorder = new System.Windows.Forms.Panel();
            this.buttonView = new System.Windows.Forms.Button();
            this.labelStoreName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Controls.Add(this.buttonView);
            this.panelBorder.Controls.Add(this.labelStoreName);
            this.panelBorder.Controls.Add(this.labelTime);
            this.panelBorder.Controls.Add(this.labelTitle);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(715, 32);
            this.panelBorder.TabIndex = 0;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(603, 5);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(95, 20);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Font = new System.Drawing.Font("Afacad", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreName.Location = new System.Drawing.Point(338, 8);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(75, 15);
            this.labelStoreName.TabIndex = 2;
            this.labelStoreName.Text = "Store\'s name";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Afacad", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(163, 8);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(34, 15);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "08:00";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Afacad", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(14, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // NotificationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBorder);
            this.Name = "NotificationCard";
            this.Size = new System.Drawing.Size(715, 32);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label labelStoreName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTitle;
    }
}
