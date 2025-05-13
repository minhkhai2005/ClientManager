using System.Windows.Forms;

namespace Notification__View
{
    partial class NotificationView
    {
        private System.Windows.Forms.Panel panelTextBox;


        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.LightGray;
            this.panelContainer.Controls.Add(this.panelTop);
            this.panelContainer.Controls.Add(this.panelBottom);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Size = new System.Drawing.Size(600, 800);
            this.panelContainer.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblStoreName);
            this.panelTop.Location = new System.Drawing.Point(20, 20);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(560, 120);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Afacad", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notification";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Italic);
            this.lblStoreName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblStoreName.Location = new System.Drawing.Point(20, 60);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(308, 25);
            this.lblStoreName.TabIndex = 1;
            this.lblStoreName.Text = "UIT Stores Management Software";
            this.lblStoreName.Click += new System.EventHandler(this.lblStoreName_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnDone);
            this.panelBottom.Controls.Add(this.panelTextBox);
            this.panelBottom.Location = new System.Drawing.Point(20, 160);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(560, 600);
            this.panelBottom.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Afacad", 12F);
            this.txtMessage.Location = new System.Drawing.Point(2, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(534, 489);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(420, 520);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 40);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panelTextBox
            // 
            this.panelTextBox.BackColor = System.Drawing.Color.White;
            this.panelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextBox.Controls.Add(this.txtMessage);
            this.panelTextBox.Location = new System.Drawing.Point(10, 10);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(538, 480);
            this.panelTextBox.TabIndex = 3;
            // 
            // NotificationView
            // 
            this.Controls.Add(this.panelContainer);
            this.Name = "NotificationView";
            this.Size = new System.Drawing.Size(600, 800);
            this.panelContainer.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelTextBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

