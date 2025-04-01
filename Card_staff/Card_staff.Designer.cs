namespace Card_staff
{
    partial class Card_staff
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Card_staff.Properties.Resources.avatar_boy_svgrepo_com;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Afacad", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trần Minh Khải";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Afacad", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee’s role";
            // 
            // MessageBtn
            // 
            this.MessageBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MessageBtn.Location = new System.Drawing.Point(656, 36);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Size = new System.Drawing.Size(92, 29);
            this.MessageBtn.TabIndex = 3;
            this.MessageBtn.Text = "Message";
            this.MessageBtn.UseVisualStyleBackColor = true;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ViewBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ViewBtn.Location = new System.Drawing.Point(754, 35);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(92, 29);
            this.ViewBtn.TabIndex = 4;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelStatus.Location = new System.Drawing.Point(260, 27);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(20, 20);
            this.panelStatus.TabIndex = 5;
            this.panelStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Card_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.MessageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Card_staff";
            this.Size = new System.Drawing.Size(953, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MessageBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Panel panelStatus;
    }
}
