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
    public partial class AddCategory : Form
    {
        CategoryRepo _catRepo = new CategoryRepo();
        public AddCategory()
        {
            InitializeComponent();
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {
            BindCategoryStatus();
            btnUpdateCategory.Visible = false;
            btnAddCategory.Visible = true;
            txtCategoryName.Focus();
        }
        private void txtClear()
        {
            txtCategoryName.Clear();
        }
        private void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;
            }
        }
        public void BindCategoryStatus()
        {
            // Initialize the ComboBox with Active/Inactive options
            var items = new List<KeyValuePair<string, bool>>()
        {
            new KeyValuePair<string, bool>("Active", true),
            new KeyValuePair<string, bool>("Inactive", false)
            };

            cbCategoryStatus.DisplayMember = "Key";
            cbCategoryStatus.ValueMember = "Value";

            // Bind the list to the ComboBox
            cbCategoryStatus.DataSource = items;
            cbCategoryStatus.SelectedIndex = 0;
        }
        private void btnCategoryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Category name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
                return;
            }
            else
            {
                CategoryModel cm = new CategoryModel();
                cm.categoryName = txtCategoryName.Text;
                cm.status = ((KeyValuePair<string, bool>)cbCategoryStatus.SelectedItem).Value;

                var result = _catRepo.addCategory(cm);
                if (result > 0)
                {
                    MessageBox.Show("Category Insert Successfully");
                    txtClear();
                }

            }
        }
        private int categoryId;
        public void EditCategory(CategoryModel cm)
        {
            btnAddCategory.Visible = false;
            btnUpdateCategory.Visible = true;

            this.Text = "Edit Category";
            this.lblCategoryTitle.Text = "Edit Category";

            this.txtCategoryName.Text = cm.categoryName;
            this.cbCategoryStatus.SelectedValue = cm.status;
            this.categoryId = cm.catId;

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Category name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
                return;
            }
            else
            {
                CategoryModel cm = new CategoryModel();
                cm.catId = categoryId;
                cm.categoryName = txtCategoryName.Text;
                cm.status = ((KeyValuePair<string, bool>)cbCategoryStatus.SelectedItem).Value;

                var result = _catRepo.updateCategory(cm);
                if (result > 0)
                {
                    MessageBox.Show("Category Update Successfully");
                    this.Close();
                }

            }
        }

    }
}
