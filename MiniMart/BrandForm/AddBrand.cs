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

namespace MiniMart.BrandForm
{
    public partial class AddBrand : Form
    {
        BrandRepo _brandRepo = new BrandRepo();
        public AddBrand()
        {
            InitializeComponent();
        }
        private void AddBrand_Load(object sender, EventArgs e)
        {
            BindBrandStatus();
            btnAddBrand.Visible = true;
            btnUpdateBrand.Visible = false;
            txtBrandName.Focus();
        }
        private void txtClearBrand()
        { 
            txtBrandName.Clear();
        }
        private void AddBrand_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;
            }
        }
        public void BindBrandStatus()
        {
            // Initialize the ComboBox with Active/Inactive options
            var items = new List<KeyValuePair<string, bool>>()
        {
            new KeyValuePair<string, bool>("Active", true),
            new KeyValuePair<string, bool>("Inactive", false)
            };

            cbBrandStatus.DisplayMember = "Key";
            cbBrandStatus.ValueMember = "Value";

            // Bind the list to the ComboBox
            cbBrandStatus.DataSource = items;
            cbBrandStatus.SelectedIndex = 0;
        }
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Brand name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandName.Focus();
                return;
            }
            else 
            {
                BrandModel bm= new BrandModel();
                bm.brandName = txtBrandName.Text;
                bm.status = ((KeyValuePair<string, bool>)cbBrandStatus.SelectedItem).Value;

                var data = _brandRepo.AddBrand(bm);
                if (data > 0)
                {
                    MessageBox.Show("Brand Insert Successfully");
                    txtClearBrand();
                    txtBrandName.Focus();
                }
            }
        }
        private int brandIdd;
        public void EditBrand(BrandModel bm)
        {
            btnAddBrand.Visible = false;
            btnUpdateBrand.Visible = true;

            this.Text = "Edit Category";
            this.lblBrandTitle.Text = "Edit Category";

            this.txtBrandName.Text = bm.brandName;
            this.cbBrandStatus.SelectedValue = bm.status;
            this.brandIdd = bm.brandId;

        }
        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Brand name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandName.Focus();
                return;
            }
            else
            {
                BrandModel bm = new BrandModel();
                bm.brandId = brandIdd;
                bm.brandName= txtBrandName.Text;
                bm.status = ((KeyValuePair<string, bool>)cbBrandStatus.SelectedItem).Value;

                var data = _brandRepo.UpdateBrand(bm);
                if (data > 0)
                {
                    MessageBox.Show("Brand Update Successfully");
                    this.Close();
                }
            }

        }
        private void btnCategoryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
