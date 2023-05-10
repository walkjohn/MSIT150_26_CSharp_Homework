using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace C_作業1
{
    public partial class OrderFood : Form
    {
        public OrderFood()
        {
            InitializeComponent();
        }

        Food food;
        int q1=0 ;
        int q2=0 ;
        int q3=0;
        int q4=0 ;
        private void btnStrawberry_Click(object sender, EventArgs e)
        {          
            q1++;
            CartList();
            TotalPrice();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {         
            q2++;
            CartList();
            TotalPrice();
        }

        private void btnVanilla_Click(object sender, EventArgs e)
        {
            q3++;
            CartList();
            TotalPrice();
        }

        private void btnTaro_Click(object sender, EventArgs e)
        {
            q4++;
            CartList();
            TotalPrice();
        }

        private void CartList()    //直接定義方法，判斷所有項目。按鈕按下後再呼叫方法，判斷完後秀出購物清單
        {
            labCart.Text = string.Empty;

            if(q1>=1)
                labCart.Text += "草莓泡芙 x" + q1 + ",共NTD" + q1 * 80 + "元";
            if (q2 >= 1)
                labCart.Text += "\n巧克力泡芙 x" + q2 + ",共NTD" + q2 * 70 + "元";
            if (q3 >= 1)
                labCart.Text += "\n香草奶油泡芙 x" + q3 + ",共NTD" + q3 * 60 + "元";
            if (q4 >= 1)
                labCart.Text += "\n芋頭泡芙 x" + q4 + ",共NTD" + q4 * 90 + "元";

        }

        private void TotalPrice()    //直接定義方法，判斷所有項目。按鈕按下後再呼叫方法，判斷完後秀出總金額字串
        {
            labTotalPrice.Text = string.Empty;

            if (q1 >= 1 || q2 >= 1 || q3 >= 1 || q4 >= 1)
                labTotalPrice.Text = (q1 * 80 + q2 * 70 + q3 * 60 + q4 * 90).ToString();

        }


        private void btnClearCart_Click(object sender, EventArgs e)
        {
            labCart.Text = string.Empty;  // 購物清單清空
            labCart.Text = "尚未點餐";
            labTotalPrice.Text = string.Empty; //總金額清空
            labTotalPrice.Text = "0";
            q1 = q2 = q3 = q4 = 0;
        }

        double tp;
        private void btnCash_Click(object sender, EventArgs e)
        {
           tp = CashOrCard(q1, q2, q3, q4);
            if (tp == 0)
                MessageBox.Show("!尚未點餐", "確認付款");
            else
                MessageBox.Show("應付總額為: NTD" + tp + "元", "確認付款");
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            tp = CashOrCard(q1, q2, q3, q4);
            if (tp == 0)
                MessageBox.Show("!尚未點餐");
            else 
                MessageBox.Show("9折優惠後應付總額為: NTD" + Math.Round(tp*0.9) + "元", "確認付款");
        }


        int cc = 0;
        private static double CashOrCard(double Strawberry, double Chocolate, double Vanilla, double Taro)
        {
            double cc = Strawberry * 80 + Chocolate * 70 + Vanilla * 60 + Taro * 90;
            return cc;
        }  //定義一個可以計算總金額數字並回傳的方法


    }
}
