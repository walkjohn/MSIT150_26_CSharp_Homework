using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace C_作業1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Form1 hello=new Form1();
            hello.TopLevel = false;                                              //取消視窗一跳出就在最上層
            splitContainer2.Panel2.Controls.Clear();                   //在面板2清除之前所有視窗
            splitContainer2.Panel2.Controls.Add(hello);             //在面板2秀出在左上角   
            hello.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
          Loan bank = new Loan();
          bank.TopLevel = false;
          splitContainer2.Panel2.Controls.Clear();
          splitContainer2.Panel2.Controls.Add(bank);
          bank.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Simple_Calculator calc = new Simple_Calculator();
            calc.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(calc);
            calc.Show();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            OrderFood of = new OrderFood();
            of.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(of);
            of.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tic_Tac_Toe ttt = new Tic_Tac_Toe ();   
            ttt.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(ttt);
            ttt.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Guess_Number gn = new Guess_Number();
            gn.TopLevel = false;    
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(gn);
            gn.Show();
        }

        private void btnScoreComparison_Click(object sender, EventArgs e)
        {
            ScoreComparison sc = new ScoreComparison();
            sc.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(sc);
            sc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array1 arr1 = new Array1();
            arr1.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(arr1);
            arr1.Show();
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            NotePad np = new NotePad();
            np.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(np);
            np.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver ss = new ScreenSaver();
            ss.TopLevel = true;
            splitContainer2.Panel2.Controls.Clear();
            ss.WindowState = FormWindowState.Maximized; ;
            ss.Show();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();
            paint.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(paint);
            paint.Show();
        }

        private void btnPicViewer_Click(object sender, EventArgs e)
        {
            Picture_Viewer pv = new Picture_Viewer();
            pv.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pv);
            pv.Show();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Grade g = new Grade();
            g.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(g);
            g.Show();
        }
    }
}
