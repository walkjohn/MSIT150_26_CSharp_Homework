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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnName1_Click(object sender, EventArgs e)
        {
            string Name1= txtName1.Text;
            string Name2 = txtName2.Text;
            string Name3 = txtName3.Text;
            string Name4 = txtName4.Text;
            MessageBox.Show("Hello，我是" + Name1+ "\n英文名字是" + Name2 + "\n性別是" + Name3 + "\n星座是" +Name4 + "\n很高興認識你!");
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            string Name1 = txtName1.Text;
            string Name2 = txtName2.Text;
            string Name3 = txtName3.Text;
            string Name4 = txtName4.Text;
            MessageBox.Show("Hi，我是" + Name1 + "\n英文名字是" + Name2 + "\n性別是" + Name3 + "\n星座是" + Name4 + "\n很高興認識你!");
         
            //todo 從這開始...
        }
    }
}
