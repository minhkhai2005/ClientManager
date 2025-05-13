namespace CardEmployee
{
    partial class EmployeeCard
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.labelPhotoText = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelInitial = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelStatusColor = new System.Windows.Forms.Panel();
            this.panelBorder.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Controls.Add(this.panelPhoto);
            this.panelBorder.Controls.Add(this.labelInitial);
            this.panelBorder.Controls.Add(this.buttonView);
            this.panelBorder.Controls.Add(this.buttonMessage);
            this.panelBorder.Controls.Add(this.labelStatus);
            this.panelBorder.Controls.Add(this.labelAdditionalInfo);
            this.panelBorder.Controls.Add(this.labelRole);
            this.panelBorder.Controls.Add(this.labelName);
            this.panelBorder.Controls.Add(this.panelStatusColor);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(400, 173);
            this.panelBorder.TabIndex = 0;
            // 
            // panelPhoto
            // 
            this.panelPhoto.BackColor = System.Drawing.Color.LightGray;
            this.panelPhoto.Controls.Add(this.labelPhotoText);
            this.panelPhoto.Controls.Add(this.pictureBoxPhoto);
            this.panelPhoto.Location = new System.Drawing.Point(11, 11);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(130, 150);
            this.panelPhoto.TabIndex = 18;
            // 
            // labelPhotoText
            // 
            this.labelPhotoText.BackColor = System.Drawing.Color.Transparent;
            this.labelPhotoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhotoText.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoText.Location = new System.Drawing.Point(0, 0);
            this.labelPhotoText.Name = "labelPhotoText";
            this.labelPhotoText.Size = new System.Drawing.Size(130, 150);
            this.labelPhotoText.TabIndex = 1;
            this.labelPhotoText.Text = "Photo";
            this.labelPhotoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(130, 150);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelInitial
            // 
            this.labelInitial.BackColor = System.Drawing.Color.Transparent;
            this.labelInitial.Font = new System.Drawing.Font("Afacad", 24F, System.Drawing.FontStyle.Bold);
            this.labelInitial.ForeColor = System.Drawing.Color.Black;
            this.labelInitial.Location = new System.Drawing.Point(11, 11);
            this.labelInitial.Name = "labelInitial";
            this.labelInitial.Size = new System.Drawing.Size(140, 150);
            this.labelInitial.TabIndex = 17;
            this.labelInitial.Text = "K";
            this.labelInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInitial.Visible = false;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(313, 138);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 16;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            // 
            // buttonMessage
            // 
            this.buttonMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMessage.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessage.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessage.ForeColor = System.Drawing.Color.Black;
            this.buttonMessage.Location = new System.Drawing.Point(232, 138);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonMessage.TabIndex = 15;
            this.buttonMessage.Text = "Message";
            this.buttonMessage.UseVisualStyleBackColor = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(172, 93);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(58, 17);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "On duty";
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.AutoSize = true;
            this.labelAdditionalInfo.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalInfo.Location = new System.Drawing.Point(156, 73);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(97, 17);
            this.labelAdditionalInfo.TabIndex = 13;
            this.labelAdditionalInfo.Text = "Additional Info";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(156, 53);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(37, 17);
            this.labelRole.TabIndex = 12;
            this.labelRole.Text = "Role";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(155, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // panelStatusColor
            // 
            this.panelStatusColor.BackColor = System.Drawing.Color.Green;
            this.panelStatusColor.Location = new System.Drawing.Point(159, 94);
            this.panelStatusColor.Name = "panelStatusColor";
            this.panelStatusColor.Size = new System.Drawing.Size(10, 10);
            this.panelStatusColor.TabIndex = 10;
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBorder);
            this.Font = new System.Drawing.Font("Afacad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(400, 173);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.panelPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Label labelPhotoText;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelStatusColor;
    }
}
