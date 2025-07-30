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
    public partial class frmBrand : Form
    {
        BrandRepo _brandRepo=new BrandRepo();
        public frmBrand()
        {
            InitializeComponent();
        }
        private void BrandList()
        { 
            DataTable dt = new DataTable();
            dt.Columns.Add("sn");
            dt.Columns.Add("brandId");
            dt.Columns.Add("Brand Name");
            dt.Columns.Add("Status");

            var data=_brandRepo.GetALLBrandList();
            var sn=1;
            foreach (var item in data)
            {
                var row = dt.NewRow();
                row["brandId"] = item.brandId;
                row["sn"] = sn;
                row["Brand Name"] = item.brandName;
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
            this.dataGridViewBrand.DataSource = dt;
            dataGridViewBrand.Columns["brandId"].Visible = false;

            // Check if columns already added to prevent duplication
            if (!dataGridViewBrand.Columns.Contains("Edit"))
            {
                // Edit Button Column
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dataGridViewBrand.Columns.Add(editButton);
            }

            // Delete Button Column
            if (!dataGridViewBrand.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridViewBrand.Columns.Add(deleteButton);
            }

        }
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand ad=new AddBrand();
            ad.Show(this);
        }

        private void dataGridViewBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["brandId"].Value);

                if (grid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var data = _brandRepo.getBrandById(id);
                    if (data == null) return;
                    AddBrand ab = new AddBrand();
                    ab.Show(this);
                    ab.EditBrand(data);
                }
                else if (grid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirm = MessageBox.Show($"Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete logic here
                        _brandRepo.deleteBrand(id);
                        BrandList();
                    }
                }
            }
        }

        private void frmBrand_Activated(object sender, EventArgs e)
        {
            BrandList();
        }
    }
}
