using MiniMart.Models;
using MiniMart.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.ProductForm
{
    public partial class AddProduct : Form
    {
        ProductRepo _productRepo = new ProductRepo();
        public AddProduct()
        {
            InitializeComponent();
        }

        int roleIdData = frmLogin.sessionRoleId;
        private void AddProduct_Load(object sender, EventArgs e)
        {
            BindCategoryList();
            BindBrandList();
            ProductStatusList();
            btnAddProduct.Visible = true;
            btnUpdateProduct.Visible = false;
            txtProductName.Focus();
        }
        public void BindCategoryList()
        {
            var data = _productRepo.categoryDropDown();
            cbCategory.DataSource = data;
            cbCategory.Text = "Choose Category";
            cbCategory.DisplayMember = "categoryName";
            cbCategory.ValueMember = "catId";
        }
        public void BindBrandList()
        {
            var data = _productRepo.brandDropDown();
            cbBrand.DataSource = data;
            cbBrand.Text = "Choose Brand";
            cbBrand.DisplayMember = "brandName";
            cbBrand.ValueMember = "brandId";
        }
        public void ProductStatusList()
        {
            // Initialize the ComboBox with Active/Inactive options
            var items = new List<KeyValuePair<string, bool>>()
        {
            new KeyValuePair<string, bool>("Active", true),
            new KeyValuePair<string, bool>("Inactive", false)
            };

            cmProductStatus.DisplayMember = "Key";
            cmProductStatus.ValueMember = "Value";
              
            //Product Bind the list to the ComboBox
            cmProductStatus.DataSource = items;
            cmProductStatus.SelectedIndex = 0;
        }
        private void txtProductClear()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
        private void btnProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DateTime productionDate = Convert.ToDateTime(txtProductionDate.Text);
            DateTime expiryDate = Convert.ToDateTime(txtExpiryDate.Text);

            if (txtProductName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            else if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            else if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            else if (productionDate > expiryDate || txtProductionDate.Text == string.Empty)
            {
                MessageBox.Show("Production date should be greater than expiry date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            else 
            {
                ProductModel pm = new ProductModel();
                pm.productName= txtProductName.Text;
                pm.price= txtPrice.Text.Trim();
                int quantityData= Convert.ToInt32(txtQuantity.Text);
                pm.quantity= quantityData;
                pm.production_date = txtProductionDate.Text;
                pm.expiry_date = txtExpiryDate.Text;
                pm.intRoleId = roleIdData;
                pm.categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                pm.brandId = Convert.ToInt32(cbBrand.SelectedValue);
                pm.status = ((KeyValuePair<string, bool>)cmProductStatus.SelectedItem).Value;

                var result = _productRepo.addProduct(pm);
                if (result > 0)
                {
                    MessageBox.Show("Product Insert Successfully");
                    txtProductClear();
                }
            }
        }

        private int productIdd;
        public void EditProduct(ProductModel pm)
        {
            btnAddProduct.Visible = false;
            btnUpdateProduct.Visible = true;

            this.Text = "Edit Product";
            this.lblProductTitle.Text = "Edit Product";

            this.txtProductName.Text = pm.productName;
            this.txtPrice.Text = pm.price;
            Convert.ToInt32(this.txtQuantity.Text ="" +pm.quantity);
            this.txtProductionDate.Text = pm.production_date;
            this.txtExpiryDate.Text = pm.expiry_date;
            this.cbCategory.SelectedValue = pm.categoryId;
            this.cbBrand.SelectedValue = pm.brandId;
            this.cmProductStatus.SelectedValue = pm.status;
            this.productIdd = pm.productId;

        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            DateTime productionDate = Convert.ToDateTime(txtProductionDate.Text);
            DateTime expiryDate = Convert.ToDateTime(txtExpiryDate.Text);

            if (txtProductName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            else if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            else if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            else if (productionDate > expiryDate || txtProductionDate.Text == string.Empty)
            {
                MessageBox.Show("Production date should be greater than expiry date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            else
            {
                ProductModel pm = new ProductModel();
                pm.productId = productIdd;
                pm.productName = txtProductName.Text;
                pm.price = txtPrice.Text.Trim();
                int quantityData = Convert.ToInt32(txtQuantity.Text);
                pm.quantity = quantityData;
                pm.production_date = txtProductionDate.Text;
                pm.expiry_date = txtExpiryDate.Text;
                pm.intRoleId = roleIdData;
                pm.categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                pm.brandId = Convert.ToInt32(cbBrand.SelectedValue);
                pm.status = ((KeyValuePair<string, bool>)cmProductStatus.SelectedItem).Value;

                var result = _productRepo.productUpdate(pm);
                if (result > 0)
                {
                    MessageBox.Show("Product update Successfully");
                    this.Close();
                }
            }
        }

        private void txtProductionDate_Leave(object sender, EventArgs e)
        {
            DateTime productionDate = Convert.ToDateTime(txtProductionDate.Text);
            DateTime expiryDate = Convert.ToDateTime(txtExpiryDate.Text);
            if (productionDate > expiryDate)
            {
                errorProductionDate.SetError(txtExpiryDate, "Enter expired Date should be higher than join date");
                txtExpiryDate.Focus();
            }
            else
            {
                errorProductionDate.Clear();
                errorExpiryDate.Clear();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }
    }
}
