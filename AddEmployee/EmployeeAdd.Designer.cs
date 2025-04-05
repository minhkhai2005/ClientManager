using System.Windows.Forms;

namespace EmployeeAdd
{
    partial class EmployeeAdd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.informationLabel = new System.Windows.Forms.Label();
            this.employeeStartDateLabel = new System.Windows.Forms.Label();
            this.employeeRoleLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.storeIdLabel = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Afacad", 12F, System.Drawing.FontStyle.Bold);
            this.informationLabel.Location = new System.Drawing.Point(34, 21);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(125, 28);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = "Information";
            // 
            // employeeStartDateLabel
            // 
            this.employeeStartDateLabel.AutoSize = true;
            this.employeeStartDateLabel.Location = new System.Drawing.Point(38, 74);
            this.employeeStartDateLabel.Name = "employeeStartDateLabel";
            this.employeeStartDateLabel.Size = new System.Drawing.Size(127, 16);
            this.employeeStartDateLabel.TabIndex = 1;
            this.employeeStartDateLabel.Text = "Employee start date";
            // 
            // employeeRoleLabel
            // 
            this.employeeRoleLabel.AutoSize = true;
            this.employeeRoleLabel.Location = new System.Drawing.Point(38, 105);
            this.employeeRoleLabel.Name = "employeeRoleLabel";
            this.employeeRoleLabel.Size = new System.Drawing.Size(105, 16);
            this.employeeRoleLabel.TabIndex = 2;
            this.employeeRoleLabel.Text = "Employee\'s role";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(38, 133);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(46, 16);
            this.salaryLabel.TabIndex = 3;
            this.salaryLabel.Text = "Salary";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(38, 161);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 16);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(38, 189);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(32, 16);
            this.shiftLabel.TabIndex = 5;
            this.shiftLabel.Text = "Shift";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(417, 75);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 16);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(417, 102);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(78, 16);
            this.dateOfBirthLabel.TabIndex = 7;
            this.dateOfBirthLabel.Text = "Date of birth";
            // 
            // storeIdLabel
            // 
            this.storeIdLabel.AutoSize = true;
            this.storeIdLabel.Location = new System.Drawing.Point(417, 130);
            this.storeIdLabel.Name = "storeIdLabel";
            this.storeIdLabel.Size = new System.Drawing.Size(55, 16);
            this.storeIdLabel.TabIndex = 8;
            this.storeIdLabel.Text = "Store ID";
            this.storeIdLabel.Click += new System.EventHandler(this.storeIdLabel_Click);
            // 
            // txtRole
            // 
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.Location = new System.Drawing.Point(171, 103);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(228, 22);
            this.txtRole.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(171, 131);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(228, 22);
            this.txtSalary.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(171, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // txtShift
            // 
            this.txtShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShift.Location = new System.Drawing.Point(171, 187);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(228, 22);
            this.txtShift.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(534, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtStoreID
            // 
            this.txtStoreID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreID.Location = new System.Drawing.Point(534, 130);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(228, 22);
            this.txtStoreID.TabIndex = 15;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(171, 75);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(228, 22);
            this.dtpStartDate.TabIndex = 16;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(534, 102);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(228, 22);
            this.dtpDOB.TabIndex = 17;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(676, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 25);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(571, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 25);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.storeIdLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.employeeRoleLabel);
            this.Controls.Add(this.employeeStartDateLabel);
            this.Controls.Add(this.informationLabel);
            this.Name = "EmployeeForm";
            this.Size = new System.Drawing.Size(780, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label informationLabel;
        private Label employeeStartDateLabel;
        private Label employeeRoleLabel;
        private Label salaryLabel;
        private Label phoneLabel;
        private Label shiftLabel;
        private Label emailLabel;
        private Label dateOfBirthLabel;
        private Label storeIdLabel;
        private TextBox txtRole;
        private TextBox txtSalary;
        private TextBox txtPhone;
        private TextBox txtShift;
        private TextBox txtEmail;
        private TextBox txtStoreID;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDOB;
        private Button btnAdd;
        private Button btnCancel;
    }
}


