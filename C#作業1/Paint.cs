using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        ColorDialog dlg = new ColorDialog();
        private void btnColor_Click(object sender, EventArgs e)
        {    
            dlg.ShowDialog();
            labColor.BackColor = dlg.Color;
        }

        int labsize=0;
        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            labsize = trackBarSize.Value;
            labSize.Text= labsize.ToString();
            //待修，變動顯示數值異常
        }

        int x0, y0;  

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X; 
            y0=e.Y;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picBox.Refresh();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            picBox.Image = new Bitmap(672,450);
            Graphics g = Graphics.FromImage(picBox.Image);
            g.Clear(Color.White);
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(picBox.Image);
                Pen p = new Pen(dlg.Color, int.Parse(trackBarSize.Value.ToString()));
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                picBox.Refresh();
            }
        }
   
    }

}
