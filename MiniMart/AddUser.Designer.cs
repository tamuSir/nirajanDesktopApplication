namespace MiniMart
{
    partial class AddUser
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHasPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoleId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDtToDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.errorPasswordEqual = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHasPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFromDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorToDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordEqual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHasPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(2, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(816, 57);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(53, 72);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(207, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblfirstName
            // 
            this.lblfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstName.Location = new System.Drawing.Point(53, 98);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(104, 28);
            this.lblfirstName.TabIndex = 1;
            this.lblfirstName.Text = "First Name";
            this.lblfirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblfirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(207, 102);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(207, 128);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(207, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "phone";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(207, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHasPassword
            // 
            this.txtHasPassword.Location = new System.Drawing.Point(207, 258);
            this.txtHasPassword.Name = "txtHasPassword";
            this.txtHasPassword.Size = new System.Drawing.Size(154, 20);
            this.txtHasPassword.TabIndex = 8;
            this.txtHasPassword.UseSystemPasswordChar = true;
            this.txtHasPassword.Leave += new System.EventHandler(this.txtHasPassword_Leave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Join Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoleId
            // 
            this.txtRoleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoleId.FormattingEnabled = true;
            this.txtRoleId.Location = new System.Drawing.Point(207, 233);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(154, 21);
            this.txtRoleId.TabIndex = 7;
            this.txtRoleId.SelectedIndexChanged += new System.EventHandler(this.roleId_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Designation";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(207, 360);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(154, 20);
            this.txtDesignation.TabIndex = 12;
            // 
            // txtDtFromDate
            // 
            this.txtDtFromDate.CustomFormat = "yyyy/MM/dd";
            this.txtDtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtFromDate.Location = new System.Drawing.Point(207, 309);
            this.txtDtFromDate.MinDate = new System.DateTime(2025, 5, 18, 0, 0, 0, 0);
            this.txtDtFromDate.Name = "txtDtFromDate";
            this.txtDtFromDate.Size = new System.Drawing.Size(154, 20);
            this.txtDtFromDate.TabIndex = 10;
            this.txtDtFromDate.Value = new System.DateTime(2025, 5, 18, 0, 0, 0, 0);
            this.txtDtFromDate.ValueChanged += new System.EventHandler(this.txtDtFromDate_ValueChanged);
            this.txtDtFromDate.Leave += new System.EventHandler(this.txtDtFromDate_Leave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Contract To Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDtToDate
            // 
            this.txtDtToDate.CustomFormat = "yyyy/MM/dd";
            this.txtDtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtToDate.Location = new System.Drawing.Point(207, 334);
            this.txtDtToDate.MinDate = new System.DateTime(2025, 5, 18, 0, 0, 0, 0);
            this.txtDtToDate.Name = "txtDtToDate";
            this.txtDtToDate.Size = new System.Drawing.Size(154, 20);
            this.txtDtToDate.TabIndex = 11;
            this.txtDtToDate.ValueChanged += new System.EventHandler(this.txtDtToDate_ValueChanged);
            this.txtDtToDate.Leave += new System.EventHandler(this.txtDtToDate_Leave);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Green;
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddUser.Location = new System.Drawing.Point(204, 415);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 34);
            this.btnAddUser.TabIndex = 13;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Confirm Password";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(207, 283);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Size = new System.Drawing.Size(154, 20);
            this.txtCPassword.TabIndex = 9;
            this.txtCPassword.UseSystemPasswordChar = true;
            this.txtCPassword.Leave += new System.EventHandler(this.txtCPassword_Leave);
            // 
            // errorPasswordEqual
            // 
            this.errorPasswordEqual.ContainerControl = this;
            // 
            // errorHasPassword
            // 
            this.errorHasPassword.ContainerControl = this;
            // 
            // errorFromDate
            // 
            this.errorFromDate.ContainerControl = this;
            // 
            // errorToDate
            // 
            this.errorToDate.ContainerControl = this;
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(76, 59);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 13);
            this.lblUserId.TabIndex = 15;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateUser.Location = new System.Drawing.Point(285, 415);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(76, 34);
            this.btnUpdateUser.TabIndex = 17;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.BackColor = System.Drawing.Color.Red;
            this.lblUsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDisplay.ForeColor = System.Drawing.Color.White;
            this.lblUsernameDisplay.Location = new System.Drawing.Point(237, 72);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(95, 23);
            this.lblUsernameDisplay.TabIndex = 18;
            this.lblUsernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmStatus
            // 
            this.cmStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmStatus.FormattingEnabled = true;
            this.cmStatus.Location = new System.Drawing.Point(207, 386);
            this.cmStatus.Name = "cmStatus";
            this.cmStatus.Size = new System.Drawing.Size(154, 21);
            this.cmStatus.TabIndex = 19;
            this.cmStatus.SelectedIndexChanged += new System.EventHandler(this.cmStatus_SelectedIndexChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 452);
            this.Controls.Add(this.cmStatus);
            this.Controls.Add(this.lblUsernameDisplay);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtDtToDate);
            this.Controls.Add(this.txtDtFromDate);
            this.Controls.Add(this.txtRoleId);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHasPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Activated += new System.EventHandler(this.AddUser_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordEqual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHasPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHasPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtRoleId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.DateTimePicker txtDtFromDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtDtToDate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.ErrorProvider errorPasswordEqual;
        private System.Windows.Forms.ErrorProvider errorHasPassword;
        private System.Windows.Forms.ErrorProvider errorFromDate;
        private System.Windows.Forms.ErrorProvider errorToDate;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.ComboBox cmStatus;
        private System.Windows.Forms.Label label1;
    }
}