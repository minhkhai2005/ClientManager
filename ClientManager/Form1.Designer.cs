namespace ClientManager
{
    partial class Form1
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
            this.noInternetConnection1 = new NoInternetConnectionControl.NoInternetConnection();
            this.SuspendLayout();
            // 
            // noInternetConnection1
            // 
            this.noInternetConnection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.noInternetConnection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noInternetConnection1.Location = new System.Drawing.Point(0, 0);
            this.noInternetConnection1.MinimumSize = new System.Drawing.Size(1400, 1000);
            this.noInternetConnection1.Name = "noInternetConnection1";
            this.noInternetConnection1.Size = new System.Drawing.Size(1400, 1000);
            this.noInternetConnection1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 961);
            this.Controls.Add(this.noInternetConnection1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NoInternetConnectionControl.NoInternetConnection noInternetConnection1;
    }
}

