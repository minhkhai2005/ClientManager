namespace Sign_In
{
    partial class Sign_in
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
            this.sign_In_control1 = new signIn_control.sign_In_control();
            this.SuspendLayout();
            // 
            // sign_In_control1
            // 
            this.sign_In_control1.AutoSize = true;
            this.sign_In_control1.BackColor = System.Drawing.Color.White;
            this.sign_In_control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sign_In_control1.Location = new System.Drawing.Point(0, 0);
            this.sign_In_control1.Margin = new System.Windows.Forms.Padding(2);
            this.sign_In_control1.Name = "sign_In_control1";
            this.sign_In_control1.Size = new System.Drawing.Size(1061, 811);
            this.sign_In_control1.TabIndex = 0;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 811);
            this.Controls.Add(this.sign_In_control1);
            this.Name = "Sign_in";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private signIn_control.sign_In_control sign_In_control1;
    }
}

