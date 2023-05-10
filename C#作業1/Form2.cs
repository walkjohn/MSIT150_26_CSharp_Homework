using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnWhoAreYou_Click(object sender, EventArgs e)
        {
           Form1 frm = new Form1();
            frm.Show();
        }

        private void btnSelfDefinedMethod_Click(object sender, EventArgs e)
        {
            SelfDefinedMethod();
        }

        void SelfDefinedMethod()
        {
            MessageBox.Show("This is the Method I define");
        }

        private void btnReturnBirthYear_Click(object sender, EventArgs e) //回傳生日年分
        {
            string result = BirthYear(20);
            MessageBox.Show(result);
        }
        string BirthYear(int Age)
        {
           int bYear = DateTime.Now.Year - Age;
           return "出生年為"+bYear+"年";
        }

        private void btnMyClass_Click(object sender, EventArgs e)   //存取修飾詞比較
        {
             MyClass mc = new MyClass();
            //mc.Method1();
            //mc.Method2();
            mc.Method3();
            mc.Method4();
        }

        private void btnEncapsulation_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method5();
        }

        private void btnPartialClass_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method6();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
           Member George   = new Member();
            George.Name = "Federer";
            George.Age = 40;
            MessageBox.Show("Name: " + George.Name + "\nAge: " + George.Age);

            Member Mary = new Member
            {
                Name = "Nadal",
                Age = 35
            };
            MessageBox.Show("Name: " + Mary.Name + "\nAge: " + Mary.Age);
        }
    }
}
