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
    public partial class frmBooking : Form
    {
        private readonly Bitmap availableIcon = Properties.Resources.available_room;
        private readonly Bitmap provisionalIcon = Properties.Resources.provisional_room;
        public frmBooking()
        {
            InitializeComponent();
        }
        private void frmBooking_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = availableIcon;
                    c.Click += pictureBox1_Click;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                if (pictureBox.Image == availableIcon)
                {
                    pictureBox.Image = provisionalIcon;
                }
                else if (pictureBox.Image == provisionalIcon)
                {
                    pictureBox.Image = availableIcon;
                }
                else
                {
                    pictureBox.Image = availableIcon;
                }
            }
        }
    }
}
