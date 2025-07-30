using MiniMart.Models;
using MiniMart.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMart
{
    public partial class AddUser : Form
    {
        UserRepo userRepo=new UserRepo();
        public AddUser()
        {           
            InitializeComponent();
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            btnUpdateUser.Visible = false;        
            btnAddUser.Visible = true;        
            btnCancel.Visible = true;
            lblUsernameDisplay.Visible = false;
            BindRoleList();
            BindStatusList();
        }
        private void AddUser_Activated(object sender, EventArgs e)
        {
            if (this.Owner != null)
            { 
                this.Owner.Enabled=false;
            }
        }
        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;
            }
        }
        public void BindRoleList()
        {
            var data = userRepo.GetRolelist();
            txtRoleId.DataSource = data;
            txtRoleId.Text = "Choose Role";
            txtRoleId.DisplayMember = "roleName";
            txtRoleId.ValueMember = "roleId";
        }
        public void BindStatusList()
        {
            // Initialize the ComboBox with Active/Inactive options
            var items = new List<KeyValuePair<string, bool>>()
        {
            new KeyValuePair<string, bool>("Active", true),
            new KeyValuePair<string, bool>("Inactive", false)
            };

            cmStatus.DisplayMember = "Key";
            cmStatus.ValueMember = "Value";

            // Bind the list to the ComboBox
            cmStatus.DataSource = items;
            cmStatus.SelectedIndex = 0;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void roleId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtClear()
        {
            txtUsername.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();

            txtCPassword.Clear();
            txtHasPassword.Clear();
            txtDesignation.Clear();

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //check username valid or not
            string usernameU = txtUsername.Text.Trim();
            var data = userRepo.usernameValidation(usernameU);

            if (data == null)
            {
                usernameU = txtUsername.Text.Trim();
            }
            else
            {
                string userNameString = data.userName;

                if (userNameString == usernameU)
                {
                    MessageBox.Show("Please Enter User name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }

            }

            string emailU = txtEmail.Text.Trim();
            string phoneU = txtPhone.Text.Trim();

            DateTime fromDate = Convert.ToDateTime(txtDtFromDate.Text);
            DateTime toDate = Convert.ToDateTime(txtDtToDate.Text);

            if (string.IsNullOrEmpty(usernameU) || !Regex.IsMatch(usernameU, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                MessageBox.Show("Username should be one uppercase, number and special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }            
            else if (txtFirstName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter First name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            else if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(emailU) || !Regex.IsMatch(emailU, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(phoneU) || !Regex.IsMatch(phoneU, @"^\d{10}$"))
            {
                MessageBox.Show("Please Enter phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtRoleId.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoleId.Focus();
                return;
            }
            else if (txtHasPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHasPassword.Focus();
                return;
            }
            else if (txtCPassword.Text != txtHasPassword.Text)
            {
                errorPasswordEqual.SetError(txtHasPassword, "Enter Same Password");
                txtHasPassword.Focus();
                return;
            }
            else if (fromDate > toDate )
            {
                errorFromDate.SetError(txtDtToDate, "Enter Expired Date should be higher than join date");
                txtDtToDate.Focus();
                return;
            }
            else if (txtDesignation.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesignation.Focus();
                return;
            }

            else
            {
                UserModel um = new UserModel();
                um.userName = usernameU;
                um.firstName = txtFirstName.Text;
                um.lastName = txtLastName.Text;
                um.email = emailU;
                um.address = txtAddress.Text;
                um.phone = phoneU;
                um.roleId = Convert.ToInt32(txtRoleId.SelectedValue);
                um.hasPassword = txtHasPassword.Text;
                um.dtFromDate = txtDtFromDate.Text;
                um.dtToDate = txtDtToDate.Text;
                um.designation = txtDesignation.Text;
                um.status = ((KeyValuePair<string, bool>)cmStatus.SelectedItem).Value;

                var insertUserD = userRepo.addUser(um);
                if (insertUserD > 0)
                {
                    MessageBox.Show("Data Insert Successfully");
                    txtClear();
                }
                
                //this.DialogResult = DialogResult.OK;
            }
            
        }
        public int userIdee;
        public void EditUser(UserModel um)
        {
            btnUpdateUser.Visible = true;
            btnAddUser.Visible = false;
            lblUserId.Visible = false;
            txtUsername.Visible = false;

            lblUsernameDisplay.Visible = true;

            this.Text = "Edit User";
            this.lblTitle.Text = "Edit User";

            var userIdEdit= Convert.ToInt32(this.lblUserId.Text = "" + um.userId);

            this.lblUsernameDisplay.Text = um.userName;
            this.txtFirstName.Text = um.firstName;
            this.txtLastName.Text = um.lastName;
            this.txtEmail.Text = um.email;
            this.txtAddress.Text = um.address;
            this.txtPhone.Text = um.phone;
            this.txtRoleId.SelectedValue = um.roleId;
            this.txtHasPassword.Text = um.hasPassword;
            this.txtCPassword.Text = um.hasPassword;
            this.txtDtFromDate.Text = um.dtFromDate;
            this.txtDtToDate.Text = um.dtToDate;
            this.txtDesignation.Text = um.designation;
            this.cmStatus.SelectedValue = um.status;

            this.userIdee = userIdEdit;

}
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
 
            string emailU = txtEmail.Text.Trim();
            string phoneU = txtPhone.Text.Trim();

            DateTime fromDate = Convert.ToDateTime(txtDtFromDate.Text);
            DateTime toDate = Convert.ToDateTime(txtDtToDate.Text);

            if (txtFirstName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter First name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            else if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(emailU) || !Regex.IsMatch(emailU, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(phoneU) || !Regex.IsMatch(phoneU, @"^\d{10}$"))
            {
                MessageBox.Show("Please Enter phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtRoleId.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoleId.Focus();
                return;
            }
            else if (txtHasPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHasPassword.Focus();
                return;
            }
            else if (txtCPassword.Text != txtHasPassword.Text)
            {
                errorPasswordEqual.SetError(txtHasPassword, "Enter Same Password");
                txtHasPassword.Focus();
                return;
            }
            else if (fromDate > toDate)
            {
                errorFromDate.SetError(txtDtToDate, "Enter Expired Date should be higher than join date");
                txtDtToDate.Focus();
                return;
            }
            else if (txtDesignation.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesignation.Focus();
                return;
            }

            else
            {
                UserModel um = new UserModel();
                um.firstName = txtFirstName.Text;
                um.lastName = txtLastName.Text;
                um.email = emailU;
                um.address = txtAddress.Text;
                um.phone = phoneU;
                um.roleId = Convert.ToInt32(txtRoleId.SelectedValue);
                um.hasPassword = txtHasPassword.Text;
                um.dtFromDate = txtDtFromDate.Text;
                um.dtToDate = txtDtToDate.Text;
                um.designation = txtDesignation.Text;
                um.status = ((KeyValuePair<string, bool>)cmStatus.SelectedItem).Value;

                 um.userId = this.userIdee;

                var updateUserD = userRepo.updateUser(um);
                if (updateUserD > 0)
                {
                    MessageBox.Show("User Update successfully");
                    this.Close();
                }              

                //this.DialogResult = DialogResult.OK;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void txtDtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtDtFromDate.MinDate = DateTime.Today;
        }

        private void txtDtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtDtToDate.MinDate = DateTime.Today;
        }
        private void txtHasPassword_Leave(object sender, EventArgs e)
        {
            if (txtHasPassword.Text == string.Empty)
            {
                errorHasPassword.SetError(txtHasPassword, "Enter Password");
                txtHasPassword.Focus();
            }
            else
            {
                errorPasswordEqual.Clear();
                errorHasPassword.Clear();
            }
        }
        private void txtCPassword_Leave(object sender, EventArgs e)
        {
            if (txtCPassword.Text != txtHasPassword.Text)
            {
                errorPasswordEqual.SetError(txtHasPassword, "Enter Same Password");
                txtHasPassword.Focus();
            }
            else
            {
                errorPasswordEqual.Clear();
                errorHasPassword.Clear();
            }
        }
        private void txtDtToDate_Leave(object sender, EventArgs e)
        {

            DateTime fromDate = Convert.ToDateTime(txtDtFromDate.Text);
            DateTime toDate = Convert.ToDateTime(txtDtToDate.Text);
            if (fromDate > toDate) 
            {
                errorToDate.SetError(txtDtToDate, "Enter expired Date should be higher than join date");
                txtDtToDate.Focus();
            }
            else
            {
                errorFromDate.Clear();
                errorToDate.Clear();
            }
        }

        private void txtDtFromDate_Leave(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(txtDtFromDate.Text);
            DateTime toDate = Convert.ToDateTime(txtDtToDate.Text);
            if (fromDate > toDate)
            {
                errorFromDate.SetError(txtDtToDate, "Enter expired Date should be higher than join date");
                txtDtToDate.Focus();
            }
            else
            {
                errorFromDate.Clear();
                errorToDate.Clear();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            string usernameCheck = txtUsername.Text.Trim();

            var data = userRepo.usernameValidation(usernameCheck);

            if (data == null)
            {
                errorUserName.Clear();
                txtFirstName.Focus();
            }
            else
            {
                string userNameString = data.userName;

                if (usernameCheck == string.Empty)
                {
                    errorUserName.SetError(txtUsername, "Enter Password");
                    txtUsername.Focus();
                }
                else if (userNameString == usernameCheck)
                {
                    errorUserName.SetError(txtUsername, "Please Enter Different User name");
                    txtUsername.Focus();
                }
                else
                {
                    errorUserName.Clear();
                }
            }

        }

        private void cmStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
