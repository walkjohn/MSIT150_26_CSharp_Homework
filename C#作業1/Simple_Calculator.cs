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
    public partial class Simple_Calculator : Form
    {
        public Simple_Calculator()
        {
            InitializeComponent();
        }


        Calculator calc;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToInt32(txtNum1.Text);
            calc.num2 = Convert.ToInt32(txtNum2.Text);
            labAns.Text=(calc.num1 + calc.num2).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToInt32(txtNum1.Text);
            calc.num2 = Convert.ToInt32(txtNum2.Text);
            labAns.Text = (calc.num1 - calc.num2).ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToInt32(txtNum1.Text);
            calc.num2 = Convert.ToInt32(txtNum2.Text);
            labAns.Text = (calc.num1 * calc.num2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal Ans;
            calc.num1 = decimal.Parse(txtNum1.Text);
            calc.num2 = decimal.Parse(txtNum2.Text);
            Ans = (calc.num1 / calc.num2);
            Ans = decimal.Round(Ans,4);
            labAns.Text = Ans.ToString();

        }
    }
}
