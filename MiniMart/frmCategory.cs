using MiniMart.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart
{
    public partial class frmCategory : Form
    {
        CategoryRepo _categoryRepo = new CategoryRepo();
        public frmCategory()
        {
            InitializeComponent();
        }
        private void categoryAllList()
        { 
            DataTable dt = new DataTable();
            dt.Columns.Add("catId");
            dt.Columns.Add("sn");
            dt.Columns.Add("Category Name");
            dt.Columns.Add("Status");

            var data = _categoryRepo.GetCategoryList();
            var sn = 1;

            foreach (var item in data)
            {
                var row = dt.NewRow();
                row["catId"] = item.catId;
                row["sn"] = sn;
                row["Category Name"] = item.categoryName;
                //row["Status"] = item.status;

                var statusDataa = item.status;
                if (statusDataa == true)
                {
                    row["Status"] = "Active";

                }
                else if (statusDataa == false)
                {
                    row["Status"] = "Pending";
                }
                sn++;
                dt.Rows.Add(row);
            }
            this.dataGridViewCategory.DataSource = dt;
            dataGridViewCategory.Columns["catId"].Visible = false;

            // Check if columns already added to prevent duplication
            if (!dataGridViewCategory.Columns.Contains("Edit"))
            {
                // Edit Button Column
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dataGridViewCategory.Columns.Add(editButton);
            }

            // Delete Button Column
            if (!dataGridViewCategory.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridViewCategory.Columns.Add(deleteButton);
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show(this);
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["catId"].Value);

                if (grid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var data = _categoryRepo.categoryGetById(id);
                    if (data == null) return;
                    AddCategory au = new AddCategory();
                    au.Show(this);
                    au.EditCategory(data);
                }
                else if (grid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirm = MessageBox.Show($"Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete logic here
                        _categoryRepo.deleteCategory(id);
                        categoryAllList();
                    }
                }
            }
        }

        private void frmCategory_Activated(object sender, EventArgs e)
        {
            categoryAllList();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
