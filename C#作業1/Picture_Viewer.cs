using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class Picture_Viewer : Form
    {
        public Picture_Viewer()
        {
            InitializeComponent();
        }

        private void picB1_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic1Show();
            pvs.Show();
        }

        private void pictB2_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic2Show();
            pvs.Show();
        }

        private void picB3_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic3Show();
            pvs.Show();
        }

        private void picB4_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic4Show();
            pvs.Show();
        }

        private void picB5_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic5Show();
            pvs.Show();
        }

        private void picB6_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic6Show();
            pvs.Show();
        }

        private void picB7_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic7Show();
            pvs.Show();
        }

        private void picB8_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic8Show();
            pvs.Show();
        }

        private void picB9_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic9Show();
            pvs.Show();
        }

        private void picB10_Click(object sender, EventArgs e)
        {
            Picture_Viewer_Show pvs = new Picture_Viewer_Show();
            pvs.Pic10Show();
            pvs.Show();
        }
    }
}
