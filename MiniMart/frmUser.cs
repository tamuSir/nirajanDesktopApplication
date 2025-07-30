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

namespace MiniMart
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            //getAllUserList();
            //userList.CellClick += userList_CellClick;
        }

        UserRepo _user= new UserRepo();

        private void getAllUserList() 
        { 
            DataTable dt = new DataTable();
            dt.Columns.Add("userId");
            dt.Columns.Add("sn");
            dt.Columns.Add("UserName");
            dt.Columns.Add("Name");
            dt.Columns.Add("email");
            dt.Columns.Add("address");
            dt.Columns.Add("phone");
            dt.Columns.Add("Role");
            dt.Columns.Add("From Date");
            dt.Columns.Add("To Date");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Status");
            //dt.Columns.Add("Action");

            var data = _user.GetUserList();
            var sn = 1;
            foreach (var item in data)
            {
                var row = dt.NewRow();
                row["userId"]=item.userId;
                row["sn"]=sn;
                row["UserName"] = item.userName;
                row["Name"] = item.firstName  +' '+  item.lastName;
                row["email"] = item.email;
                row["address"] = item.address;
                row["phone"] = item.phone;
                row["Role"] = item.roleName;
                row["From Date"] = item.dtFromDate;
                row["To Date"] = item.dtToDate;
                row["Designation"] = item.designation;
                //row["Status"] = item.status;

                var statusData = item.status;
                if (statusData == true)
                {
                    row["Status"] = "Active";

                }
                else if (statusData == false)
                {
                    row["Status"] = "Pending";

                }
                sn++;

                dt.Rows.Add(row);
            }
            this.userList.DataSource = dt;
            userList.Columns["userId"].Visible = false;

            // Check if columns already added to prevent duplication
            if (!userList.Columns.Contains("Edit"))
            {
                // Edit Button Column
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                userList.Columns.Add(editButton);
            }

            // Delete Button Column
            if (!userList.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                userList.Columns.Add(deleteButton);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show(this);

            //if (au.ShowDialog() == DialogResult.OK)
            //{
            //    getAllUserList();
            //}
        }

        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["userId"].Value);

                if (grid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var data = _user.UserGetById(id);
                    if (data == null) return;
                    AddUser au = new AddUser();
                    au.Show(this);
                    au.EditUser(data);
                }
                else if (grid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirm = MessageBox.Show($"Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete logic here
                        _user.deleteUser(id);
                        getAllUserList();
                    }
                }
            }
        }

        private void frmUser_Activated(object sender, EventArgs e)
        {
            getAllUserList();
        }
    }
}
