using System;
using System.Collections;
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
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        Subject sub;

        private void SubjectAndGrade()
        {
            int score = 0, score1 = 0, score2 = 0;
            bool isNumChinese = int.TryParse(txtChinese.Text, out score);

            if (!isNumChinese)
            {
                MessageBox.Show("請輸入國文的正確分數");
                txtChinese.Clear();
                txtChinese.Focus();
            }
            else
                sub.Chinese = int.Parse(txtChinese.Text);


            bool isNumEnglish = int.TryParse(txtEnglish.Text, out score1);
            if (!isNumEnglish)
            {
                MessageBox.Show("請輸入英文的正確分數");
                txtEnglish.Clear();
                txtEnglish.Focus();
            }
            else
                sub.English = int.Parse(txtEnglish.Text);

            bool isNumMath = int.TryParse(txtMath.Text, out score2);
            if (!isNumMath)
            {
                MessageBox.Show("請輸入數學的正確分數");
                txtMath.Clear();
                txtMath.Focus();
            }
            else
                sub.Math = int.Parse(txtMath.Text);

            //sub.Chinese = int.Parse(txtChinese.Text);
            //sub.English = int.Parse(txtEnglish.Text);
            //sub.Math = int.Parse(txtMath.Text);
        }

        void ShowGrade()
        {
            //labShow.Text = "產品\n";
            //decimal totalPrice = 0;
            //for (int i = 0; i < lsPro.Count; i++)
            //{
            //    labShow.Text += $"名稱: {((Product)lsPro[i]).Name} , " +
            //        $"單價: {((Product)lsPro[i]).Price:c0}\n";
            //    totalPrice += ((Product)lsPro[i]).Price;
            //}
            //labShow.Text += $"\n-------------\n數量: {lsPro.Count}" +
            //   $"\n單價加總: {totalPrice:c0}\n單價平均: {totalPrice / lsPro.Count:c2}";
        }

        ArrayList lsPro = new ArrayList();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sub.Name = txtName.Text;
            SubjectAndGrade();

            lsPro.Add(sub);
            ShowGrade();
        }
    }
}
