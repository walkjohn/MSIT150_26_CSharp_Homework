using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void txtLoan_KeyPress(object sender, KeyPressEventArgs e)    //使用者只能輸入數字和刪除，無法輸入小數點
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)   //使用者只能輸入數字和刪除，無法輸入小數點
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInstallment_KeyPress(object sender, KeyPressEventArgs e)  //使用者只能輸入數字和刪除
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static double amount1, amount2, amount3, total, PMT;
        private void btnRepayMonth_Click(object sender, EventArgs e)
        {
            amount1 = double.Parse(txtLoan.Text);                  //double.Parse強制將文字轉數字
            amount2 = double.Parse(txtRate.Text);
            amount3 = double.Parse(txtInstallment.Text);

            double PMT = MonthlyPay(amount1, amount2, amount3); 
            MessageBox.Show("每月應還金額" + Math.Round(PMT) + "元");
        }
        double MonthlyPay(double Loan, double Rate, double Installment)      //計算每月應還本息總額(定值)
        {
            double result;
            double interest = 1 + (Rate / 1200);
            result = Math.Pow(interest, Installment);
            double amp =(result * (Rate / 1200)) / (result - 1);
            double mp = Loan * amp;

            return mp;
        }

        private void btnRepayAll_Click(object sender, EventArgs e)
        {
            amount1 = double.Parse(txtLoan.Text);                  //double.Parse強制將文字轉數字
            amount2 = double.Parse(txtRate.Text);
            amount3 = double.Parse(txtInstallment.Text);
            total = MonthlyPay(amount1, amount2, amount3)*amount3;
            MessageBox.Show("應還總金額為" + Math.Round(total) + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Loan_Report report = new Loan_Report();
            report.AllReport();
            report.Show();
        }
    }



    }

