using MiniMart.BrandForm;
using MiniMart.ProductForm;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (frmLogin.loginName != null) {
                displayUserName.Text= frmLogin.loginName;
                //AboutBox1 about = new AboutBox1();
                //about.Show();
                if (frmLogin.loginType != null && frmLogin.loginType == "Seller")
                {
                    userToolStripMenuItem.Enabled = false;
                    userToolStripMenuItem.ForeColor = Color.Red;
                }
            }

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab=new AboutBox1();
            ab.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory ad=new frmCategory();
            ad.Show();
        }

        private void addBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrand fb = new frmBrand();
            fb.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct fp = new frmProduct();
            fp.Show();
        }

        private void testingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooking fb =new frmBooking();
            fb.Show();
        }
    }
}
