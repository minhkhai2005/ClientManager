using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mesenger__Tab
{
    partial class MesengerTab
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem overviewMenu, inventoryMenu, employeesMenu, messageMenu, invoicesMenu;
        private Panel mainPanel;
        private Label lblStoreName, lblStoreAddress, lblPhotoText;
        private RichTextBox rtbMessages, txtMessage; // Thêm txtMessage
        private Button btnSend;

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.overviewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblPhotoText = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreAddress = new System.Windows.Forms.Label();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewMenu,
            this.inventoryMenu,
            this.employeesMenu,
            this.messageMenu,
            this.invoicesMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(935, 33);
            this.menuStrip.TabIndex = 4;
            // 
            // overviewMenu
            // 
            this.overviewMenu.BackColor = System.Drawing.Color.Silver;
            this.overviewMenu.ForeColor = System.Drawing.Color.Black;
            this.overviewMenu.Name = "overviewMenu";
            this.overviewMenu.Size = new System.Drawing.Size(108, 29);
            this.overviewMenu.Text = "Overview";
            // 
            // inventoryMenu
            // 
            this.inventoryMenu.BackColor = System.Drawing.Color.Silver;
            this.inventoryMenu.ForeColor = System.Drawing.Color.Black;
            this.inventoryMenu.Name = "inventoryMenu";
            this.inventoryMenu.Size = new System.Drawing.Size(106, 29);
            this.inventoryMenu.Text = "Inventory";
            // 
            // employeesMenu
            // 
            this.employeesMenu.BackColor = System.Drawing.Color.Silver;
            this.employeesMenu.ForeColor = System.Drawing.Color.Black;
            this.employeesMenu.Name = "employeesMenu";
            this.employeesMenu.Size = new System.Drawing.Size(123, 29);
            this.employeesMenu.Text = "Employees";
            // 
            // messageMenu
            // 
            this.messageMenu.BackColor = System.Drawing.Color.White;
            this.messageMenu.ForeColor = System.Drawing.Color.Black;
            this.messageMenu.Name = "messageMenu";
            this.messageMenu.Size = new System.Drawing.Size(107, 29);
            this.messageMenu.Text = "Message";
            // 
            // invoicesMenu
            // 
            this.invoicesMenu.BackColor = System.Drawing.Color.Silver;
            this.invoicesMenu.ForeColor = System.Drawing.Color.Black;
            this.invoicesMenu.Name = "invoicesMenu";
            this.invoicesMenu.Size = new System.Drawing.Size(98, 29);
            this.invoicesMenu.Text = "Invoices";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.lblPhotoText);
            this.mainPanel.Controls.Add(this.lblStoreName);
            this.mainPanel.Controls.Add(this.lblStoreAddress);
            this.mainPanel.Location = new System.Drawing.Point(10, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(924, 138);
            this.mainPanel.TabIndex = 3;
            // 
            // lblPhotoText
            // 
            this.lblPhotoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhotoText.BackColor = System.Drawing.Color.Silver;
            this.lblPhotoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhotoText.Location = new System.Drawing.Point(798, 22);
            this.lblPhotoText.Name = "lblPhotoText";
            this.lblPhotoText.Size = new System.Drawing.Size(89, 90);
            this.lblPhotoText.TabIndex = 0;
            this.lblPhotoText.Text = "Photo";
            this.lblPhotoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhotoText.Click += new System.EventHandler(this.lblPhotoText_Click);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblStoreName.Location = new System.Drawing.Point(20, 22);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(307, 29);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "Addidas Nguyễn Ảnh Thủ";
            // 
            // lblStoreAddress
            // 
            this.lblStoreAddress.AutoSize = true;
            this.lblStoreAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStoreAddress.Location = new System.Drawing.Point(20, 65);
            this.lblStoreAddress.Name = "lblStoreAddress";
            this.lblStoreAddress.Size = new System.Drawing.Size(661, 25);
            this.lblStoreAddress.TabIndex = 1;
            this.lblStoreAddress.Text = "357a Đ. Nguyễn Ảnh Thủ, Trung Mỹ Tây, Quận 12, Hồ Chí Minh, Việt Nam";
            // 
            // rtbMessages
            // 
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbMessages.Location = new System.Drawing.Point(10, 180);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbMessages.Size = new System.Drawing.Size(913, 502);
            this.rtbMessages.TabIndex = 2;
            this.rtbMessages.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMessage.Location = new System.Drawing.Point(10, 701);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtMessage.Size = new System.Drawing.Size(764, 91);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSend.Location = new System.Drawing.Point(813, 724);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MesengerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "MesengerTab";
            this.Size = new System.Drawing.Size(935, 833);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}





