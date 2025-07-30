using Microsoft.AspNetCore.Authentication.Cookies;
using MiniMart.App_Code;
using MiniMart.Models;
using MiniMart.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart
{
    public partial class frmLogin : Form
    {
        GlobalConnection gc = new GlobalConnection();
        UserRepo _userRepo=new UserRepo();
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string loginName, loginType;
        public static int sessionRoleId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region first attempt login this make login fast
            //try
            //{
            //    gc.cn.Open();
            //    if (MainClass.IsValidUser(txtUsername.Text, txtPassword.Text) == false)
            //    {
            //        MessageBox.Show("Invalid username and password");
            //        return;
            //    }
            //    else
            //    {
            //        //MessageBox.Show("Login Success");
            //        this.Hide();
            //        loginName = txtUsername.Text;

            //        Dashboard dashboard = new Dashboard();
            //        dashboard.Show();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
            //finally
            //{
            //    gc.cn.Close();
            //}
            #endregion

            #region this is second attempt login
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            var data = _userRepo.Login(username,password);
            if (data != null)
            {
                this.Hide();
                loginName = txtUsername.Text;
                string loginTypeName = data.roleName;
                loginType = loginTypeName;
                sessionRoleId = data.roleId;

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password");
                return;
            }

            #endregion

        }

        private void cbShowHidePsd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowHidePsd.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
