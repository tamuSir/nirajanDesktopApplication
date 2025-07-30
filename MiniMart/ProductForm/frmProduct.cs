using MiniMart.BrandForm;
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

namespace MiniMart.ProductForm
{
    public partial class frmProduct : Form
    {
        ProductRepo _productRepo =new ProductRepo();
        public frmProduct()
        {
            InitializeComponent();
        }
        private void ProductList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("sn");
            dt.Columns.Add("productId");
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Production Date");
            dt.Columns.Add("Expiry Date");
            dt.Columns.Add("Category");
            dt.Columns.Add("Brand");
            dt.Columns.Add("Status");

            var data = _productRepo.productAllList();
            var sn = 1;
            foreach (var item in data)
            {
                var row = dt.NewRow();
                row["productId"] = item.productId;
                row["sn"] = sn;
                row["Product Name"] = item.productName;
                row["Price"] = item.price;
                row["Quantity"] = item.quantity;
                row["Production Date"] = item.production_date;
                row["Expiry Date"] = item.expiry_date;
                row["Category"] = item.categoryName;
                row["Brand"] = item.brandName;
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
            this.dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.Columns["productId"].Visible = false;

            // Check if columns already added to prevent duplication
            if (!dataGridViewProduct.Columns.Contains("Edit"))
            {
                // Edit Button Column
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dataGridViewProduct.Columns.Add(editButton);
            }

            // Delete Button Column
            if (!dataGridViewProduct.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridViewProduct.Columns.Add(deleteButton);
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show(this);
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["productId"].Value);

                if (grid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var data = _productRepo.productGetById(id);
                    if (data == null) return;
                    AddProduct ap = new AddProduct();
                    ap.Show(this);
                    ap.EditProduct(data);
                }
                else if (grid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirm = MessageBox.Show($"Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete logic here
                        _productRepo.productDelete(id);
                        ProductList();
                    }
                }
            }
        }

        private void frmProduct_Activated(object sender, EventArgs e)
        {
            ProductList();
        }
    }
}
