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
    public partial class Loan_Report : Form
    {
        public Loan_Report()
        {
            InitializeComponent();
        }
     
        public void AllReport()
        {
            txtLoan.Text = Loan.amount1.ToString();
            txtRate.Text = Loan.amount2.ToString();
            txtInstallment.Text = Loan.amount3.ToString();
            txtPMT.Text = Loan.PMT.ToString();   //待解決: 抓不到值
            txtMp.Text = Loan.total.ToString();    //待解決: 還無法四捨五入
  
        }
    }
}
